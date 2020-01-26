using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//retirer d'argent 
//déposer d'argent
namespace examcours
{
    class compteepargne : Compte
    {
        private double soldeepargne;


        public compteepargne(int num_compte, double soldeCompte, double soldeepargne) : base(num_compte, soldeCompte)
        {
            this.soldeepargne = soldeCompte;
        }

        public void cloture_compte()
        {
            if (this.soldeepargne < 100)
            {
                this.compteActive = false;
                Console.WriteLine("Le compte est férmer !");
            }
        }
        //revaloriser l'epargne
        public override void deposer(double mt)
        {
            transaction tt = new transaction(new DateTime(), 0, mt);
            addTransaction(tt);
            this.soldeCompte += mt + mt * this.soldeepargne;
        }


        public override string ToString()
        {
            return "Num compte :" + this.getnumCompte() + "Solde :" + this.soldeCompte + "solde epargne :" + this.soldeepargne;
        }

        //------------------

    }
}
