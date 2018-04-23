using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMOElectionServer
{
    public partial class BoothController : UserControl
    {
        public int Booth { get; private set; }

        public void Start()
        {
            this.BackColor = Color.LightGreen;
            lblStatus.Text = "Voting in progress...";
            cmdControl.Text = "Stop";
            
        }

        public int VoteCount
        {
            set
            {
                lblVoteCount.Text = value.ToString();
            }
        }

        public BoothController(int BoothNumber)
        {
            Booth = BoothNumber;            
            InitializeComponent();
            this.BackColor = Color.LightGray;
            lblBooth.Text = "Booth " + Booth.ToString();
            lblVoteCount.Text = "0";
            lblStatus.Text = "Standby";
            cmdControl.Text = "Start";


        }
    }
}
