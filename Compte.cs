using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace examcours
{
   abstract class Compte
    {
        protected int num_compte ; 
        protected double soldeCompte;
        protected List<transaction> transaction;

        protected Boolean compteActive = true; 

        // Constructeur par défaut 
        public Compte()
        {

        }

        public Compte(int numCompte , double solde)
        {
            this.num_compte = numCompte;
            this.soldeCompte = solde;
            transaction = new List<transaction>();
        }
        
        public int getnumCompte() { return this.num_compte; }
        public void setNumCompte(int num_compte)
        {
            this.num_compte = num_compte;
        }

        public double getsoldeCompte() { return this.soldeCompte; }
        public void setsoldeCompte(double soldeCompte)
        {
            this.soldeCompte = soldeCompte;
        }


        public virtual void Retirer(double mt)
        {
            transaction tt = new transaction(new DateTime(),1, mt);
            this.soldeCompte = this.soldeCompte - mt;
            addTransaction(tt);
        }

        public virtual void deposer(double mt)
        {
            transaction tt = new transaction(new DateTime(),0,mt); 
            this.soldeCompte = this.soldeCompte + mt;
            addTransaction(tt);
        }

        //abstract public String toString();
        public void addTransaction(transaction tt)
        {
            transaction.Add(tt); 
        }
    }
}
