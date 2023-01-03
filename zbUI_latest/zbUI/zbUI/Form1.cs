using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Media;
using System.IO;
using System.Net.Mail;
using System.Net;






namespace zbUI
{
    delegate void HandleCrossThread(string message);


    public partial class Form1 : Form
    {

        event HandleCrossThread onHandleCrossThread;
        Random Rnd = new Random();
        static SerialPort SPort;
       // int[] tempchart;
         


        public Form1()
        {
            InitializeComponent();
           description.ForeColor = System.Drawing.Color.Black; 

            onHandleCrossThread += new HandleCrossThread(Form1_onHandleCrossThread);

            TextBoxDisp.Text = "Testing";

            SPort = new SerialPort();

            //Set Properties of Serial Port

            SPort.PortName = setPortName();
            SPort.BaudRate = 19200;
            SPort.DataBits = 8;
            SPort.StopBits = StopBits.One;
            SPort.Parity = System.IO.Ports.Parity.None;

            SPort.DataReceived += new SerialDataReceivedEventHandler(SPort_DataReceived);
               SPort.Open();
            
            
        }

        void Form1_onHandleCrossThread(string message)
        {
            TextBoxDisp.AppendText(message);
            String str = message;
            str = message.Trim();
            // double num , decVal;
            int critical = 35;

        }
            //decVal = Convert.ToInt32(str, 32);
            //decVal = Convert.ToUInt32(str,16);
            //textBox2.Text = decVal.ToString();

            
        //    try
        //    {
                
        //        bool isNum = double.TryParse(decVal.ToString(), out num);

        //        if (isNum)
        //        {

        //            textBox2.Text = decVal.ToString();

        //            if (decVal > critical)
        //            {
        //                textBox2.ForeColor = System.Drawing.Color.Red;
                       
        //                TextBoxDisp.Text = " ALERT ALERT ALERT , THE TEMPERATURE IS CRITICAL!!";
        //                TextBoxDisp.ForeColor = System.Drawing.Color.Red; 
                       
        //               soundAlarm();
                        
        //            }
        //             else                    
        //            {
        //                 textBox2.ForeColor = System.Drawing.Color.Black;
        //                 TextBoxDisp.ForeColor = System.Drawing.Color.Black; 
        //             }
        //        }

        //    }          

        //    catch
        //    { }
        //}
        
       

        void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadExisting();



                if (this.InvokeRequired)
                {
                    this.Invoke(onHandleCrossThread, indata);
                }
                else
                {
                    Form1_onHandleCrossThread(indata);
                }

            }
            catch
            {
            }
        } //dont touch

        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public String setPortName()
        {

            String portName;
            //Console.WriteLine("Names you Got");
            //foreach (String s in SerialPort.GetPortNames())
            //{
                //Console.WriteLine(" {0}", s);
            //}


            //Console.WriteLine("Select Port::");
            //portName = Console.ReadLine();
            portName = "COM12";

            //return portName;
            return portName;
        } //sets the port name on your notebook.



        //public  void DataReceivedHandler(  object sender,SerialDataReceivedEventArgs e)


        public void Form1_Load(object sender, EventArgs e)
        {
        }


        public void formClosed(object sender, FormClosedEventArgs e)
        {
            if (SPort != null)
                SPort.Close();
        }


       /* Sound , Chart , Mail and Profile Log Activities*/


        //void showChart()
        //{
        //    Series series2 = new Series();


        //    int val = 0;
        //    // []arr = {10 , 13,15 ,22 ,19 ,23};
        //    Array[] Temp1 = new Array[5];

        //    //Temp1[5] = 
        //    chart1.Series.Add(series2);


        //    for (int i = 0; i < 5; i++)
        //    {
        //        //array[i] = i;
        //        // val = arr[i];
        //        //chart1.Series[i].Points.AddXY(decVal , i);
        //        //chart1.Series["Series2"].Points.AddXY(temp.Add(i), i);
        //    }

        //    chart1.Series["Series2"].ChartType = SeriesChartType.Line;
        //}
        void soundAlarm()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"\\alarm.wav");
           simpleSound.Play();
        }


        //when Save Profile Button is clicked , your stuff will be done!
        private void save_prof_Click(object sender, EventArgs e)
        {

            TextWriter Otext = new StreamWriter(@"C:\profile.txt");
            Otext.WriteLine("Zigbee Health Vigilance System 1.0 - Data Log" + '\n');
            Otext.WriteLine("Name of the Patient::"+namebox.Text);
            Otext.WriteLine("Age of the Patient::"+agebox.Text );
            Otext.WriteLine("Initial Diagnosis and Symptoms::   "+description.Text);
            Otext.WriteLine(DateTime.Now);
            Otext.WriteLine("Patient Email"+uremail.Text);

          

            Otext.Close(); 
            LoadFile();
           // sendMail();

        }

        void LoadFile()
        {

            // Read the file as one string.
            System.IO.StreamReader myFile = new System.IO.StreamReader(@"C:\profile.txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();

            // Display the file contents.
           displayUnit.Text= myString;
            
        }

        void sendMail()
        {

            MailAddress to = new MailAddress(docmail.Text); //
            MailAddress from = new MailAddress("shreyas.gune@student-partners.com"); //uremail.Text
            MailMessage message = new MailMessage(from, to);
            message.Subject = " !!||Health Vigil 1.0 ALERT||!!";
            message.Body = ("Report in the Attachment"+textBox2.Text);
            // Use the application or machine configuration to get the 
            // host, port, and credentials.
            SmtpClient client = new SmtpClient("smtp.live.com", 25);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("shreyas.gune@student-partners.com", "DOMINUS_170890");
            Console.WriteLine("Sending an e-mail message to {0} at {1} by using the SMTP host={2}.",to.User, to.Host, client.Host);
            

           
            




              Attachment data = new Attachment(@"C:\profile.txt");


            //ContentDisposition disposition = data.ContentDisposition;
            //disposition.CreationDate = System.IO.File.GetCreationTime(file);
            //disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            //disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
             //Add the file attachment to this e-mail message.
            message.Attachments.Add(data);

            //Send the message.
            client.Send(message);


        }

      

       
 
    }
}
   


        
 
