using DesP_Gr_11.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesP_Gr_11
{
    public partial class Connexion : Form
    {
        Clsprincipal con;
        public static string username;
        public static int userid;
        public Connexion()
        {
            InitializeComponent();
            con = new Clsprincipal();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Equals("") || txtpassword.Text.Equals(""))
            {
                MessageBox.Show("Complete the form!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtusername.Text == "Admin" && txtpassword.Text == "Admin")
                {
                    Menu H = new Menu();
                    H.Show();
                    this.Hide();
                }

                else
                {
                    string Req = "select * from Employes where Email='{0}' and password='{1}'";
                    Req = String.Format(Req, txtusername.Text, txtpassword.Text);
                    DataTable dt = con.RecupererDonnees(Req);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("User Not Found!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        username = dt.Rows[0][2].ToString();
                        Transact fac = new Transact();
                        fac.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel6_MouseClick_1(object sender, MouseEventArgs e)
        {
            DialogResult rd = MessageBox.Show("Do you want to leave", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rd == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void chkshowp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowp.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtclear_MouseClick(object sender, MouseEventArgs e)
        {
            txtpassword.Text = "";
            txtusername.Text = "";
        }
    }
}
