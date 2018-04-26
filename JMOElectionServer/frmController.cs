using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Net;
using System.Net.Sockets;

namespace JMOElectionServer
{
  

    public partial class frmController : Form
    {
        
        private ServiceHost host;
        private string Service_URL;


        public frmController()
        {
            string Service_Port = ConfigurationManager.AppSettings["SERVICE_PORT"];

            InitializeComponent();


            Service_URL = "http://" + GetLocalIPAddress() + ":" + Service_Port + "/votecontroller";
            

            Uri baseAddress = new Uri(Service_URL);


            host = new ServiceHost(typeof(JMOVoteService), baseAddress);
            

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            host.Description.Behaviors.Add(smb);

            host.Open();


            int xpos = 10;
            int ypos = 10;
            int width = 160;
            int height = 150;


            for (int i = 1; i <= 8; i++)
            {
                if (i > 4 && ypos < height)
                {
                    xpos = 10;
                    ypos = ypos + height + 10;
                }

                BoothController b = Program.controllers[i];
                b.Left = xpos;
                b.Top = ypos;

                this.Controls.Add(b);
                
                xpos += width;
            }


        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = Service_URL;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (host != null)
                host.Close();
        }

    }
}
