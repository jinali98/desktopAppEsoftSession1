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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

      
        private void button_login_Click(object sender, EventArgs e)
        {
            // read form values
           String username = text_username.Text;
           String password = text_password.Text;
            label_error.Text = "";
           // set the label error message to empty text

            if (username == "" || password == "")
            {
                // MessageBox.Show("Invalid user inputs");
                label_error.Text = "Invalid user inputs";
                // remove the messagebox and a text to the label
            }

            if(username != "" && password != "")
            {
                this.Hide();

                home h = new home();
                
                h.Show();
            // MessageBox.Show("welcome" + username);
                // remove the messagebox and a text to the label
            }



        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
