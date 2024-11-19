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
    public partial class FrmPaiement : Form
    {
        public FrmPaiement()
        {
            InitializeComponent();
        }

        private void pncusto_MouseClick(object sender, MouseEventArgs e)
        {
            Transact t = new Transact();
            t.Show();
            this.DestroyHandle();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Clspaiement pai = new Clspaiement();
                pai.CreditId = Convert.ToInt32(txtidcli.Text);
                pai.MontantPaiement = Convert.ToInt32(txtmont.Text);
                pai.Datepaiement = txtdate.Text;
                Clsprincipal.GetInstance().Ajouterpaiement(pai);
                MessageBox.Show("Paiement Effectuer!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Clspaiement pai = new Clspaiement();
                pai.Id = Convert.ToInt32(txtid.Text);
                pai.CreditId = Convert.ToInt32(txtidcli.Text);
                pai.MontantPaiement = Convert.ToInt32(txtmont.Text);
                pai.Datepaiement = txtdate.Text;
                Clsprincipal.GetInstance().Modifierpaiement(pai);
                MessageBox.Show("Paiement Modifier!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPaiement_Load(object sender, EventArgs e)
        {
            
        }
    }
}
