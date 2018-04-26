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

namespace JMOElectionServer
{
  

    public partial class frmController : Form
    {
        
        private ServiceHost host;


        public frmController()
        {
            InitializeComponent();

            string uri = ConfigurationManager.AppSettings["SERVICE_URL"];

            Uri baseAddress = new Uri(uri);


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

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (host != null)
                host.Close();
        }

        private void frmController_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Width);
            Console.WriteLine(this.Height);
        }
    }
}
