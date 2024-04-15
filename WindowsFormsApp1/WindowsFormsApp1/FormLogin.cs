using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User u = User.login(textBoxUsername.Text, textBoxPassword.Text);
                FormUtama form = (FormUtama)this.Owner;
                form.currentUser = u;
                form.labelUser.Text = "User: " + u.Username;
                form.labelRole.Text = "Role: " + u.Role;
                this.Owner.Visible = true;
                this.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
