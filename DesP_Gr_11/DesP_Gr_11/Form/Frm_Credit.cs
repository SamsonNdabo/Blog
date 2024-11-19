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
    public partial class Frm_Credit : Form
    {
        public Frm_Credit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Clscredit cr = new Clscredit();
                cr.ClientId = Convert.ToInt32(txtidcli.Text);
                cr.EmployeId = Convert.ToInt32(txtidem.Text);
                cr.Date = txtdate.Text;
                cr.DureeMois = Convert.ToInt32(txtmois.Text);
                cr.Montant = Convert.ToInt32(txtmont.Text);
                cr.TauxInteret = Convert.ToInt32(txtint.Text);
                Clsprincipal.GetInstance().AjouterCredit(cr);
                MessageBox.Show("Credit Effectuer!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pncusto_MouseClick(object sender, MouseEventArgs e)
        {
            Transact m = new Transact();
            m.Show();
            this.DestroyHandle();
        }

        private void Frm_Credit_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Clscredit cr = new Clscredit();
                cr.Id = Convert.ToInt32(txtid.Text);
                cr.ClientId = Convert.ToInt32(txtidcli.Text);
                cr.Date = txtdate.Text;
                cr.DureeMois = Convert.ToInt32(txtmois.Text);
                cr.Montant = Convert.ToInt32(txtmont.Text);
                cr.TauxInteret = Convert.ToInt32(txtint.Text);
                cr.EmployeId = Convert.ToInt32(txtidem.Text);
                Clsprincipal.GetInstance().ModifierCredit(cr);
                MessageBox.Show("Credit Modifier!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnusers_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
