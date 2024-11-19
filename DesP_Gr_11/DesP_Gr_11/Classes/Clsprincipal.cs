using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesP_Gr_11.Classes
{
class Clsprincipal
    {
        public SqlConnection con = null; // Etablir la connexion a la base de donnees 
        SqlCommand cmd = null; // Executer une commande dans une base de donnees
        SqlDataAdapter dt = null; // Lire les donnees 
        SqlDataReader dr = null; // LIre les donnees liste apres ligne
        DataSet ds = null; // convertir les donnees sous forme d'un tableau
        DataTable sd = null;

        public void innitialiseConnection()
        {
            con = new SqlConnection(Clsconnexioncs.chemin);
        }

        public static Clsprincipal _instance = null;

        public static Clsprincipal GetInstance()
        {
            if (_instance == null)
                _instance = new Clsprincipal();
            return _instance;
        }
        public void AjouterClient(Clsclient1 cl)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("INSERT INTO Clients (Nom, Prenom, Adresse, Telephone, Email, DateNaissance, DateInscription) VALUES (@Nom, @Prenom, @Adresse, @Telephone, @Email, @DateNaissance, @Dateins)", con);
            cmd.Parameters.AddWithValue("@Nom", cl.Nom);
            cmd.Parameters.AddWithValue("@Prenom", cl.Prenom);
            cmd.Parameters.AddWithValue("@Adresse", cl.Adresse);
            cmd.Parameters.AddWithValue("@Telephone", cl.Telephone);
            cmd.Parameters.AddWithValue("@Email", cl.Email);
            cmd.Parameters.AddWithValue("@DateNaissance", cl.DateNaissance);
            cmd.Parameters.AddWithValue("@Dateins", cl.Dateinsciption);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Ajouterpaiement(Clspaiement pai)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("INSERT INTO Paiements (CreditID, MontantPaiement, DatePaiement) " +
                       "VALUES (@CreditID, @MontantPaiement, @date)", con);
            cmd.Parameters.AddWithValue("@CreditID", pai.CreditId);
            cmd.Parameters.AddWithValue("@MontantPaiement", pai.MontantPaiement);
            cmd.Parameters.AddWithValue("@date", pai.Datepaiement);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AjouterEmployes(ClsEmployee em)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("INSERT INTO Employes (Nom, Prenom, Poste, Telephone, Email, DateEmbauche, password) " +
                       "VALUES (@Nom, @Prenom, @Poste, @Telephone, @Email, @date, @password)", con);
            cmd.Parameters.AddWithValue("@Nom", em.Nom);
            cmd.Parameters.AddWithValue("@Prenom", em.Prenom);
            cmd.Parameters.AddWithValue("@Poste", em.Poste);
            cmd.Parameters.AddWithValue("@Telephone", em.Phone);
            cmd.Parameters.AddWithValue("@Email", em.Email);
            cmd.Parameters.AddWithValue("@date", em.Date);
            cmd.Parameters.AddWithValue("@password", em.Pwd);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ModifierEmployes(ClsEmployee em)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("Update Employes set  Nom=@Nom, Prenom=@Prenom, Poste=@Poste, Telephone=@Telephone, Email=@Email, DateEmbauche=@date, password=@password where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", em.Id);
            cmd.Parameters.AddWithValue("@Nom", em.Nom);
            cmd.Parameters.AddWithValue("@Prenom", em.Prenom);
            cmd.Parameters.AddWithValue("@Poste", em.Poste);
            cmd.Parameters.AddWithValue("@Telephone", em.Phone);
            cmd.Parameters.AddWithValue("@Email", em.Email);
            cmd.Parameters.AddWithValue("@date", em.Date);
            cmd.Parameters.AddWithValue("@password", em.Pwd);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Modifierpaiement(Clspaiement pai)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("update Paiements set CreditID=@CreditID, MontantPaiement=@MontantPaiement, DatePaiement=@date where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", pai.Id);
            cmd.Parameters.AddWithValue("@CreditID", pai.CreditId);
            cmd.Parameters.AddWithValue("@MontantPaiement", pai.MontantPaiement);
            cmd.Parameters.AddWithValue("@date", pai.Datepaiement);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ModifierClient(Clsclient1 cl)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("UPDATE Clients SET Nom = @Nom, Prenom = @Prenom, Adresse = @Adresse,Telephone = @Telephone, Email = @Email, DateNaissance = @DateNaissance WHERE ID = @ClientID", con);
            cmd.Parameters.AddWithValue("@ClientID", cl.Id);
            cmd.Parameters.AddWithValue("@Nom", cl.Nom);
            cmd.Parameters.AddWithValue("@Prenom", cl.Prenom);
            cmd.Parameters.AddWithValue("@Adresse", cl.Adresse);
            cmd.Parameters.AddWithValue("@Telephone", cl.Telephone);
            cmd.Parameters.AddWithValue("@Email", cl.Email);
            cmd.Parameters.AddWithValue("@DateNaissance", cl.DateNaissance);
            cmd.Parameters.AddWithValue("@Dateins", cl.Dateinsciption);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AjouterCredit(Clscredit cr)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("INSERT INTO Credits (ClientID, EmployeID, Montant, TauxInteret, DateOctroi, DureeMois) " +
                               "VALUES (@ClientID, @EmployeID, @Montant, @TauxInteret,@date, @DureeMois )", con);
            cmd.Parameters.AddWithValue("@ClientID", cr.ClientId);
            cmd.Parameters.AddWithValue("@EmployeID", cr.EmployeId);
            cmd.Parameters.AddWithValue("@Montant", cr.Montant);
            cmd.Parameters.AddWithValue("@TauxInteret", cr.TauxInteret);
            cmd.Parameters.AddWithValue("@date", cr.Date);
            cmd.Parameters.AddWithValue("@DureeMois", cr.DureeMois);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ModifierCredit(Clscredit cr)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("update Credits set ClientID=@ClientID, EmployeID=@EmployeID, Montant=@Montant, TauxInteret=@TauxInteret, DateOctroi=@date, DureeMois=@DureeMois where id=@id", con);
            cmd.Parameters.AddWithValue("@id", cr.Id);
            cmd.Parameters.AddWithValue("@ClientID", cr.ClientId);
            cmd.Parameters.AddWithValue("@EmployeID", cr.EmployeId);
            cmd.Parameters.AddWithValue("@Montant", cr.Montant);
            cmd.Parameters.AddWithValue("@TauxInteret", cr.TauxInteret);
            cmd.Parameters.AddWithValue("@date", cr.Date);
            cmd.Parameters.AddWithValue("@DureeMois", cr.DureeMois);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Chargement(string nomTable)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM " + nomTable + "", con);
            dt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
        public void Supprimer(string nomTable, string chamId, string valeur)
        {
            innitialiseConnection();
            con.Open();
            cmd = new SqlCommand("DELETE FROM " + nomTable + " WHERE " + chamId + "=@id", con);
            cmd.Parameters.AddWithValue("@id", valeur);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Clscredit> Getcredits()
        {
            innitialiseConnection();
            con.Open();
            List<Clscredit> list = new List<Clscredit>();
            string Req = "SELECT *from credits";
            cmd = new SqlCommand(Req, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clscredit aff = new Clscredit();
                aff.Id = Convert.ToInt32(dr["id"].ToString());
                aff.ClientId = Convert.ToInt32(dr["ClientId"]);
                aff.EmployeId = Convert.ToInt32(dr["EmployeId"]);
                aff.Montant = Convert.ToInt32(dr["Montant"]);
                aff.TauxInteret = Convert.ToInt32(dr["TauxInteret"]);
                aff.Date = dr["Dateoctroi"].ToString();
                aff.DureeMois = Convert.ToInt32(dr["DureeMois"]);
                list.Add(aff);
            }

            return list;
            dr.Close();
            cmd.Dispose();
            con.Close();
        }

        public DataTable RecupererDonnees(string Req)
        {
            sd = new DataTable();
            dt = new SqlDataAdapter(Req, Clsconnexioncs.chemin);
            dt.Fill(sd);
            return sd;
        }

    }
}
