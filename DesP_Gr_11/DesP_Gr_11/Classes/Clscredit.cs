using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesP_Gr_11.Classes
{
    class Clscredit
    {
        int id;
        int clientId;
        int employeId;
        decimal montant;
        decimal tauxInteret;
        string date;
        int dureeMois;

        public int ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }

        public int EmployeId
        {
            get
            {
                return employeId;
            }

            set
            {
                employeId = value;
            }
        }

        public decimal Montant
        {
            get
            {
                return montant;
            }

            set
            {
                montant = value;
            }
        }

        public decimal TauxInteret
        {
            get
            {
                return tauxInteret;
            }

            set
            {
                tauxInteret = value;
            }
        }

        public int DureeMois
        {
            get
            {
                return dureeMois;
            }

            set
            {
                dureeMois = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
