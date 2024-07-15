using System;
using System.Windows.Forms;

namespace EmployeesDIR
{
    public partial class DBConnectForm : Form
    {
        public DBConnectForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            Program.logger.DebugFormat("Login form loaded. Args: {0}",e.ToString());
            Program.trans.Init(this);
        }

        private void pathChooseButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            
        }
    }
}