using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesP_Gr_11.Classes;
namespace DesP_Gr_11
{
    public partial class Em_Clie : Form
    {
        public Em_Clie()
        {
            InitializeComponent();
        }

        private void pncusto_MouseClick(object sender, MouseEventArgs e)
        {
            Transact t = new Transact();
            t.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Clsclient1 cl = new Clsclient1();
                cl.Nom = txtnom.Text;
                cl.Prenom = txtprenom.Text;
                cl.Telephone = txtphone.Text;
                cl.Adresse = txtadresse.Text;
                cl.Dateinsciption = txtins.Text;
                cl.DateNaissance = txtdate.Text;
                cl.Email = txtmail.Text;
                Clsprincipal.GetInstance().AjouterClient(cl);
                MessageBox.Show("Client Ajouter!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Clsclient1 cl = new Clsclient1();
                cl.Id = Convert.ToInt32(txtid.Text);
                cl.Nom = txtnom.Text;
                cl.Prenom = txtprenom.Text;
                cl.Telephone = txtphone.Text;
                cl.Adresse = txtadresse.Text;
                cl.Dateinsciption = txtins.Text;
                cl.DateNaissance = txtdate.Text;
                cl.Email = txtmail.Text;
                MessageBox.Show("Client Modifier!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Em_Clie_Load(object sender, EventArgs e)
        {

        }
    }
}
