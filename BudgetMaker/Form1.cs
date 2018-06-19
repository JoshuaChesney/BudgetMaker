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

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Session currentSession = new Session();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User Josh = new User();
            Josh.addIncome(10.0, "Bitcoin Sales");
            Josh.addIncome(300.0, "Paycheck");
            Josh.addExpense(80.0, "Bills");
            Josh.writeToFile("JoshData.xml");
        }
    }
}
