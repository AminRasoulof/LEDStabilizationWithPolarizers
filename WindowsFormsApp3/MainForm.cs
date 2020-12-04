using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Thorlabs.Elliptec;
using Thorlabs.Elliptec.ELLO_DLL;
using System.IO.Ports;
using System.IO;
using NationalInstruments.NI4882;
using System.Text.RegularExpressions;


//Minimum motion of the mount is 0.002 deg -> let's consider ten times this limit 0.02 deg which according to I=I0 cos2(theta) gives a 1.20e-5% control. Then as the starting point 
//I choose 1e-3% control = 0.18deg which is 90 times larger than the minimum incremental rotation.

namespace LEDStabilization
{
    public partial class MainForm : Form
    {
		string filePath="";
		ELLDevices ellDevices;
		double lockRatio;
		Device dmm;
		string portELLStage;
		System.Windows.Forms.Timer getFeedBack;
		double initialSignal;
		double currentAngle;
		ELLDevice addressedDevice;
        SerialPort serialPort;
		int numberofMeasurements = 3;
		decimal homeOffset;

		public MainForm()
        {
            InitializeComponent();
			getFeedBack = new System.Windows.Forms.Timer();
			getFeedBack.Tick += new EventHandler(FeedBack);
            getFeedBack.Interval = Convert.ToInt32(feedbackIntervalTextBox.Text)*1000;
			ellDevices = new ELLDevices();
        }

		private void FeedBack(object obj, EventArgs e)
        {			
			double theta;
			double tolerance = Convert.ToDouble(toleranceTextBox.Text) / 100.0;
			textBox2.Text = initialSignal.ToString();


            

			double change = 0;
            for (int i = 0; i < 5; i++)
            {
				var signalBeforeCorrection = ReadKrochmann();
				var siDiodeSignlaBeforeCorrection = ReadVoltageFrontPanel();
				double signalAfterCorrection = 0;
				textBox2.Text = signalBeforeCorrection.ToString();


				change = (initialSignal - signalBeforeCorrection) / initialSignal;
				theta = Math.Pow(2, i);
                if (Math.Abs(change) > tolerance)
                {
                    if (change == Math.Abs(change))
                    {
                        //theta = Math.Acos(Math.Sqrt(signalBeforeCorrection / initialSignal)) * 180.0 / Math.PI;
                        angleTextBox.Text = currentAngle.ToString();

                        addressedDevice.MoveRelative(-(decimal)(theta));
                        currentAngle -= theta;
                    }
                    else
                    {
                        //theta = Math.Acos(Math.Sqrt(initialSignal / signalBeforeCorrection)) * 180.0 / Math.PI;

                        angleTextBox.Text = currentAngle.ToString();

                        addressedDevice.MoveRelative((decimal)(theta));
                        currentAngle += theta;
                    }
                    signalAfterCorrection = ReadKrochmann();


                }


				var String = i.ToString() + "\t" + initialSignal.ToString() + "\t" + signalAfterCorrection.ToString() + "\t" + signalBeforeCorrection.ToString() + "\t" + change.ToString() +
				"\t" + siDiodeSignlaBeforeCorrection + Environment.NewLine;

				textBox1.AppendText(String);


				try
				{
					using (StreamWriter f = new StreamWriter("C:\\Users\\rasoulofa\\Documents\\GUIs\\ThorlabsEllipticStage\\Output4.txt", true))
					{
						f.Write(String);
					}
				}
				catch (Exception)
				{
					throw;
				}
			}
			 
			

            
        }

		

		private void comPortButton1_Click(object sender, EventArgs e)
		{
			var availablePorts = SerialPort.GetPortNames();

			foreach (var item in availablePorts)
			{
				comPortComboBox1.Items.Add(item);

			}
			if (availablePorts.Length != 0)
			{
				comPortComboBox1.SelectedIndex = 0;
			}
		}

		private void comPortButton2_Click(object sender, EventArgs e)
		{
			var availablePorts = SerialPort.GetPortNames();

			foreach (var item in availablePorts)
			{
				comPortComboBox2.Items.Add(item);

			}
			if (availablePorts.Length != 0)
			{
				comPortComboBox2.SelectedIndex = 0;
			}
		}

		

        private void disconnectELLStageButton_Click(object sender, EventArgs e)
        {
			if (ELLDevicePort.Disconnect())
			{
				textBox1.Text += Environment.NewLine + "device disconnected";
			}
		}


		private void rotateAndrecord(object sender, EventArgs e)
        {

			WriteToFile("Home offset is " + homeOffset.ToString() + Environment.NewLine +
				"theta0 (Initial angle from Home) is (deg) " + theta0TextBox.Text + Environment.NewLine);
			WriteToFile("angle from Home(deg)" + "\t" + "angle from theta0(deg)" + "\t" + "photocurrent" + Environment.NewLine);


			

			for (int i = 0; i < Convert.ToInt32(numberOfRepeatsTextBox.Text); i++)
            {
                decimal dtheta = Convert.ToDecimal(dthetaTextBox.Text);
                decimal theta = 0;
				decimal fromtheta0 = Convert.ToDecimal(theta0TextBox.Text);

				MessageBox.Show(fromtheta0.ToString());
				addressedDevice.Home(ELLBaseDevice.DeviceDirection.AntiClockwise);
				Thread.Sleep(5000);

				addressedDevice.MoveRelative(fromtheta0);
				Thread.Sleep(3000);

				while (theta <= Convert.ToDecimal(totalRotationTextBox.Text) + dtheta)
                {
                    angleTextBox.Text = theta.ToString();

                    var krochmann = ReadKrochmann();
                    string s = theta.ToString() + "\t" + fromtheta0.ToString() + "\t" + krochmann + Environment.NewLine;

					addressedDevice.MoveRelative(dtheta);
					Thread.Sleep(1500);

					WriteToFile(s);
                    Thread.Sleep(500);

					theta += dtheta;
					fromtheta0 += dtheta;

				}

				
            }


        }

		private void WriteToFile(string s)
        {
			try
			{
				using (StreamWriter f = new StreamWriter(filePath, true))
				{
					f.Write(s);
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

        

        private void lockButton_Click(object sender, EventArgs e)
        {
			
			lockRatio = Convert.ToDouble(lockRatioTextBox.Text);
			double theta = Math.Acos(Math.Sqrt(lockRatio / 100)) * 180.0 / Math.PI;
			currentAngle = theta;
			angleTextBox.Text = currentAngle.ToString();
			angleTextBox.Text = theta.ToString();
			addressedDevice.MoveRelative((decimal)theta);
            initialSignal = ReadKrochmann();
            textBox1.Text = "";
			DCVoltageFrontInput();
			getFeedBack.Start();
		}

        


		public double ReadVoltageFrontPanel()
		{
			double output = 0;

			try
			{
                for (int i = 0; i < numberofMeasurements; i++)
                {
                    dmm.Write("MEAS:VOLT?");
					output += Convert.ToDouble(Regex.Replace(dmm.ReadString().Substring(0, 15), @"\t|\n|\r", ""));
				}
				return output / numberofMeasurements;
			}
			catch (Exception)
			{
				return 1.0;
				throw;
			}

		}

		public int DCVoltageFrontInput()
		{
			try
			{
				dmm.Write("*RST");
				dmm.Write("*CLS");
				dmm.Write("CONF:VOLT:DC");
				//DMM.Write(string.Format(":CONF:VOLT:NPLC {0}", nplc));
				dmm.Write("INIT:CONT ON");
				return 0;
			}
			catch (Exception)
			{
				return 1;
				throw;
			}
		}


		/////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////
		private void openFileButton_Click(object sender, EventArgs e)
        {
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog1.FilterIndex = 2;
			saveFileDialog1.RestoreDirectory = true;

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				filePath = saveFileDialog1.FileName + ".txt";
				saveDataLabel.Text = filePath;
			}

		}

		private void connectToELLStageButton_Click(object sender, EventArgs e)
		{
			var args = new string[] { comPortComboBox1.SelectedItem.ToString(), "0" };


			// get the communication portELLStage
			portELLStage = (args.Length > 0) ? args[0] : comPortComboBox1.SelectedItem.ToString();
			// get the range of addresses used max range is '0' to 'F'
			char _minSearchLimit = (args.Length > 1 && ELLBaseDevice.IsValidAddress(char.ToUpper(args[1][0]))) ? char.ToUpper(args[1][0]) : '0';
			char _maxSearchLimit = (args.Length > 2 && ELLBaseDevice.IsValidAddress(char.ToUpper(args[2][0]))) ? char.ToUpper(args[2][0]) : '1';
			if (ELLDevicePort.Connect(portELLStage))
			{
				textBox1.Text = "Discover devices";
				// scan the portELLStage for connected devices using the given range of addresses
				List<string> devices = ellDevices.ScanAddresses(_minSearchLimit, _maxSearchLimit);

				foreach (string device in devices)
				{
					// configure each device found
					if (ellDevices.Configure(device))
					{
						// test each device found
						textBox1.Text = "Identify device " + device[0];
						textBox1.Text = "+++++++++++++++++++++++++";
						addressedDevice = ellDevices.AddressedDevice(device[0]) as ELLDevice;

						if (addressedDevice != null)
						{
							DeviceID deviceInfo = addressedDevice.DeviceInfo;
							string sttr = "";
							foreach (string str in deviceInfo.Description())
							{
								sttr += str + Environment.NewLine;

							}
							textBox1.Text = sttr;

							switch (deviceInfo.DeviceType)
							{
								case DeviceID.DeviceTypes.OpticsRotator:
									//addressedDevice.SetHomeOffset((decimal)0.0);
									addressedDevice.Home(ELLBaseDevice.DeviceDirection.AntiClockwise);
									Thread.Sleep(250);
									homeOffset = addressedDevice.HomeOffset;
									break;
								default:
									break;
							}
						}
					}
				}
			}
		}

		private void connectToDMMButton_Click(object sender, EventArgs e)
		{
			try
			{
				dmm = new Device(0, (byte)Convert.ToInt32(gpibAddressTextBox.Text));
				dmm.Write("*RST");
				dmm.Write("*CLS");
				dmm.Write("CONF:VOLT:DC");
				dmm.Write(":CONF:VOLT:NPLC 10");
				dmm.Write("INIT:CONT ON");
				dmm.Write("ID?");
				textBox1.AppendText(dmm.ReadString());
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private bool ConnectKrochmann()
        {
            if (serialPort==null)
            {
                serialPort = new SerialPort(comPortComboBox2.Text, 9600, Parity.None, 8, StopBits.One);
                serialPort.Handshake = Handshake.XOnXOff;
                serialPort.RtsEnable = true;
                serialPort.DtrEnable = true; 
            }

			if (!serialPort.IsOpen)
			{
				try
				{
					serialPort.Open();
					return true;
				}
				catch (Exception exc)
				{
					MessageBox.Show("Error connecting to the DMM" + Environment.NewLine + exc.Message);
					return false;
				}
			}
            else
            {
				return true;
            }
		}

		private double ReadKrochmann()
		{
			double output = 0;

			for (int i = 0; i < numberofMeasurements; i++)
			{
				serialPort.WriteLine("MEA");
				output += Convert.ToDouble(serialPort.ReadLine().Substring(0, 11));
			}

			return output / numberofMeasurements;
		}

        private void connectKrochmannButton_Click(object sender, EventArgs e)
        {
			ConnectKrochmann();
        }
    }
}
