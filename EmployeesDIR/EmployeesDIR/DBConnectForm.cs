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
            General.logger.DebugFormat("Login form loaded. Args: {0}",e.ToString());
            General.trans.Init(this);
        }

        private void pathChooseButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            
        }
    }
}