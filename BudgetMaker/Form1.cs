using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMaker
{

    public partial class frmMain : Form
    {
        public static Session currentSession = new Session();
        public static bool userIsSignedIn = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void addIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSignIn signInPopUpBox = new frmSignIn();
            signInPopUpBox.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateUser createUserPopUpBox = new frmCreateUser();
            createUserPopUpBox.ShowDialog();
        }

        private void addRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddRevenue addRevenuePopUpBox = new frmAddRevenue();
            addRevenuePopUpBox.ShowDialog();
        }

        private void tmrRefreshInformation_Tick(object sender, EventArgs e)
        {
            if (userIsSignedIn)
            {
                lblUserReport.Text = currentSession.currentUser.buildUserReport();
            }
        }
    }
}
