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
    public partial class Transact : Form
    {
        Clsprincipal con;
        public Transact()
        {
            InitializeComponent();
            con = new Clsprincipal();
            
        }
        
        
        public void Loadlist()
        {
            txtuser.Text = "Bienvenue " + Connexion.username;
            tbpai.DataSource = Clsprincipal.GetInstance().Chargement("Paiements");
            tbclient.DataSource = Clsprincipal.GetInstance().Chargement("Clients");
            string Req = "SELECT C.Nom AS NomClient, C.Prenom AS PrenomClient,cr.Montant,cr.TauxInteret,cr.DateOctroi,cr.DureeMois,cr.EmployeID, SUM(P.MontantPaiement) AS TotalPaiements, CR.montant - SUM(P.MontantPaiement) AS Totalcredits FROM Credits CR JOIN Clients C ON C.ID = CR.ClientID JOIN Paiements P ON CR.ID = P.CreditID GROUP BY C.ID,C.Nom,C.Prenom,CR.montant,cr.TauxInteret,cr.DateOctroi,cr.DureeMois,cr.EmployeID";
            tbcredits.DataSource= con.RecupererDonnees(Req);
        }

        private void Transact_Load(object sender, EventArgs e)
        {
            Loadlist();
            string Req = "SELECT C.Nom AS NomClient, C.Prenom AS PrenomClient, SUM(P.MontantPaiement) AS TotalPaiements, CR.montant - SUM(P.MontantPaiement) AS Totalcredits FROM Clients C JOIN Credits CR ON C.ID = CR.ClientID JOIN Paiements P ON CR.ID = P.CreditID GROUP BY C.ID,C.Nom,C.Prenom,CR.montant";
            credittb.DataSource = con.RecupererDonnees(Req);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void tbcredits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbpai_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult rd = MessageBox.Show("Do you want to leave", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rd == DialogResult.Yes)
            {
                Connexion c = new Connexion();
                c.Show();
                this.DestroyHandle();
            }
            else
            {

            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            FrmPaiement p = new FrmPaiement();
            p.Show();
            this.Hide();
        }

        private void pnusers_MouseClick_1(object sender, MouseEventArgs e)
        {
            Frm_Credit c = new Frm_Credit();
            c.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Em_Clie c = new Em_Clie();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Req = "SELECT C.Nom AS NomClient, C.Prenom AS PrenomClient, SUM(P.MontantPaiement) AS TotalPaiements, CR.montant - SUM(P.MontantPaiement) AS Totalcredits FROM Clients C JOIN Credits CR ON C.ID = CR.ClientID JOIN Paiements P ON CR.ID = P.CreditID where ID like '% " + txtsearch.Text + "%' GROUP BY C.ID,C.Nom,C.Prenom,CR.montant";
                credittb.DataSource = con.RecupererDonnees(Req);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Req = "SELECT *from clients where Nom like '%" + textBox1.Text + "%'";
                tbclient.DataSource = con.RecupererDonnees(Req);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
