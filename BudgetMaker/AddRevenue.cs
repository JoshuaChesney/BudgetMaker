using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMaker
{
    public partial class frmAddRevenue : Form
    {
        public frmAddRevenue()
        {
            InitializeComponent();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            string label = txtName.Text.ToString();
            frmMain.currentSession.currentUser.addIncome(amount, label);
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            string label = txtName.Text.ToString();
            frmMain.currentSession.currentUser.addExpense(amount, label);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain.currentSession.currentUser.writeToFile();
            this.Close();
        }
    }
}
