using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ServiceModel;
using System.ServiceModel.Description;

namespace JMOElectionServer
{
    public partial class frmController : Form
    {
        List<BoothController> controllers = new List<BoothController>();
        private ServiceHost host;

        [ServiceContract]
        public interface IHelloWorldService
        {
            [OperationContract]
            bool AllowVote(int Booth);
            void VoteFeedback(int Booth, int TotalVotes, bool IsVotingOpen);
        }

        public class HelloWorldService : IHelloWorldService
        {
            public bool AllowVote(int Booth)
            {
                return false;
            }

            public void VoteFeedback(int Booth, int TotalVotes, bool IsVotingOpen)
            {

            }

        }


        public frmController()
        {
            InitializeComponent();

            Uri baseAddress = new Uri("http://localhost:8080/hello");

            // Create the ServiceHost.
            host = new ServiceHost(typeof(HelloWorldService), baseAddress);
            
            // Enable metadata publishing.
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            host.Description.Behaviors.Add(smb);

            // Open the ServiceHost to start listening for messages. Since
            // no endpoints are explicitly configured, the runtime will create
            // one endpoint per base address for each service contract implemented
            // by the service.
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
                BoothController b = new BoothController(i);

                b.Left = xpos;
                b.Top = ypos;

                this.Controls.Add(b);
                controllers.Add(b);

                xpos += width;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            controllers[0].Start();
            controllers[0].VoteCount = 43;
            controllers[1].VoteCount = 72;
            controllers[2].VoteCount = 33;
            controllers[2].Start();
            controllers[3].VoteCount = 17;


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (host != null)
                host.Close();
        }
    }
}
