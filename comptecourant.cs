using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examcours
{
    class comptecourant : Compte
    {
        private double decouvert;

     
        public comptecourant(int num_compte , double soldeCompte , double decouvert):base(num_compte,soldeCompte)
        {
            this.decouvert = decouvert; 
        }

        public double getDecouvert()
        {
            return decouvert;
        }
        public void setDecouvert(double decouvert)
        {
            this.decouvert = decouvert;
        }

        public void retirer(double mt)
        {
            transaction tt = new transaction(new DateTime(), 1, mt);
            addTransaction(tt);
            if (this.soldeCompte + this.decouvert > mt)
                this.soldeCompte -= mt;
        }

        public override string ToString()
        {
            return "Num compte :" + this.getnumCompte() + "Solde :" +this.soldeCompte+ "solde epargne :" + this.decouvert;
        }

        //---------------------------
       



    }
}
