using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.ServiceModel;
using System.ServiceModel.Description;


namespace JMOElectionServer
{

    [ServiceContract]
    public interface IJMOVoteService
    {
        [OperationContract]
        bool AllowVote(int Booth);

        [OperationContract]
        void VoteFeedback(int Booth, int TotalVotes, bool IsVotingOpen);
    }

    public class JMOVoteService : IJMOVoteService
    {
        public bool AllowVote(int Booth)
        {
            return Program.controllers[Booth].AllowVoting;
        }

        public void VoteFeedback(int Booth, int TotalVotes, bool IsVotingOpen)
        {
            Program.controllers[Booth].VoteCount = TotalVotes;

        }
    }



    static class Program
    {
        public static Dictionary<int, BoothController> controllers = new Dictionary<int, BoothController>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            for (int i = 1; i <= 8; i++)
            {
                BoothController b = new BoothController(i);
                controllers.Add(i, b);
            }

            Application.Run(new frmController());
        }
    }
}
