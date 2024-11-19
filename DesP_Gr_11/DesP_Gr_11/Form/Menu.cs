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
using System.Data.SqlClient;

namespace DesP_Gr_11
{
    public partial class Menu : Form
    {
        Clsprincipal con;
        public Menu()
        {
            InitializeComponent();
            con = new Clsprincipal();
            ChargerLabelcredit();
            ChargerLabelpaie();
        }
        private void ChargerLabelpaie()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Clsconnexioncs.chemin))
                {
                    conn.Open();
                    string Req = "SELECT SUM(P.MontantPaiement) AS TotalPaiements FROM Paiements P";
                    SqlCommand cmd = new SqlCommand(Req, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtmontantpai.Text = $"Total paiement: {dr["TotalPaiements"]}";
                    }
                    else
                    {
                        txtmontantpai.Text = "Aucun Montant Trouve";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChargerLabelcredit()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Clsconnexioncs.chemin))
                {
                    conn.Open();
                    string Req = "SELECT C.Nom AS NomClient, C.Prenom AS PrenomClient, SUM(P.MontantPaiement) AS TotalPaiements, sum(CR.montant) - SUM(P.MontantPaiement) AS Totalcredits FROM Clients C JOIN Credits CR ON C.ID = CR.ClientID JOIN Paiements P ON CR.ID = P.CreditID GROUP BY C.ID,C.Nom,C.Prenom";
                    SqlCommand cmd = new SqlCommand(Req,conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtmontantcre.Text = $"Total Credit: {dr["Totalcredits"]}";
                    }
                    else
                    {
                        txtmontantcre.Text = "Aucun Montant Trouve";
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadlist()
        {
            tblclient.DataSource = Clsprincipal.GetInstance().Chargement("clients");
            tbemployes.DataSource = Clsprincipal.GetInstance().Chargement("employes");
            string Req = "SELECT C.Nom AS NomClient, C.Prenom AS PrenomClient, SUM(P.MontantPaiement) AS TotalPaiements, CR.montant - SUM(P.MontantPaiement) AS Totalcredits FROM Clients C JOIN Credits CR ON C.ID = CR.ClientID JOIN Paiements P ON CR.ID = P.CreditID GROUP BY C.ID,C.Nom,C.Prenom,CR.montant";
            credittb.DataSource = con.RecupererDonnees(Req);
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void pnusers_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
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

        private void tbemployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtmontantpai_Click(object sender, EventArgs e)
        {

        }

        private void pnusers_MouseClick_1(object sender, MouseEventArgs e)
        {
            Client cl = new Client();
            cl.Show();
            this.Hide();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Employes cl = new Employes();
            cl.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
