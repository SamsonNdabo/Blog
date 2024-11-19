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
    public partial class Employes : Form
    {
        public Employes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void Employes_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clsprincipal.GetInstance().Supprimer("employes", "id", txtid.Text);
            MessageBox.Show("Employee Supprimer!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEmployee em = new ClsEmployee();
                em.Id = Convert.ToInt32(txtid.Text);
                em.Nom = txtnom.Text;
                em.Phone = txtphone.Text;
                em.Poste = txtadresse.Text;
                em.Prenom = txtprenom.Text;
                em.Pwd = txtpwd.Text;
                em.Date = txtdate.Text;
                em.Email = txtmail.Text;
                Clsprincipal.GetInstance().ModifierEmployes(em);
                MessageBox.Show("Employee Modifier!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try{
                ClsEmployee em = new ClsEmployee();
                em.Nom = txtnom.Text;
                em.Phone = txtphone.Text;
                em.Poste = txtadresse.Text;
                em.Prenom = txtprenom.Text;
                em.Pwd = txtpwd.Text;
                em.Date = txtdate.Text;
                em.Email = txtmail.Text;
                Clsprincipal.GetInstance().AjouterEmployes(em);
                MessageBox.Show("Employee Ajouter!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pncusto_MouseClick(object sender, MouseEventArgs e)
        {
            Menu cl = new Menu();
            cl.Show();
            this.Hide();
        }
    }
}
