using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesP_Gr_11.Classes
{
    class Clspaiement
    {
        int id;
        int creditId;
        decimal montantPaiement;
        string datepaiement;

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

        public int CreditId
        {
            get
            {
                return creditId;
            }

            set
            {
                creditId = value;
            }
        }

        public decimal MontantPaiement
        {
            get
            {
                return montantPaiement;
            }

            set
            {
                montantPaiement = value;
            }
        }

        public string Datepaiement
        {
            get
            {
                return datepaiement;
            }

            set
            {
                datepaiement = value;
            }
        }
    }
}
