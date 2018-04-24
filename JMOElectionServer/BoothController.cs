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

        public bool AllowVoting { get; set; }

        public void Start()
        {
            
            
        }

        public int VoteCount
        {
            set
            {
                lblVoteCount.Text = value.ToString();
            }
        }

        private void RefreshUI()
        {
            if (!AllowVoting)
            {
                this.BackColor = Color.LightGray;
                
                lblVoteCount.Text = "0";
                lblStatus.Text = "Standby";
                cmdControl.Text = "Start";
            }
            else
            {
                this.BackColor = Color.LightGreen;
                lblStatus.Text = "Voting in progress...";
                cmdControl.Text = "Stop";
            }
        }

        public BoothController(int BoothNumber)
        {
            Booth = BoothNumber;            
            InitializeComponent();
            lblBooth.Text = "Booth " + Booth.ToString();
            AllowVoting = false;
            RefreshUI();

        }

        private void cmdControl_Click(object sender, EventArgs e)
        {
            AllowVoting = !AllowVoting;
            RefreshUI();
        }
    }
}
