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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string createUserText = txtSignIn.Text.ToString();
            frmMain.currentSession.loadUser(createUserText);
            frmMain.userIsSignedIn = true;
            this.Close();
        }
    }
}
