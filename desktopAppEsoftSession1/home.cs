using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopAppEsoftSession1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btn_userlogin_Click(object sender, EventArgs e)
        {
            // read form values
            String username = txt_username.Text;
            String password = txt_password.Text;
            
            // set the label error message to empty text

            if (username == null || password == null)
            {
                MessageBox.Show("Invalid user inputs");
                // remove the messagebox and a text to the label
            }

            if (username != null && password != null)
            {

                MessageBox.Show("welcome" + username);
                // remove the messagebox and a text to the label
            }
        }
    }
}
