using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examcours
{
    class client
    {
        private int cin;
        private string nom;
        private string prenom;
        private string email;
        private string adresse; 
        private string lieu_naiss ;
        private List<Compte> comptes;

        // Constructeur sans param et avec params
        public client()
        {

        }

        public client(int cin ,string nom,string prenom,string email,string adresse,string lieu_naiss)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.adresse = adresse;
            this.lieu_naiss = lieu_naiss;     
        }

        public string getNom() { return this.nom; }
        public void setNom(string nom)
        {
            this.nom = nom; 
        }

        public string getPrenom() { return this.prenom; }
        public void setPrnom(string prenom)
        {
            this.prenom = prenom;
        }
        public string getAdresse() { return this.adresse; }
        public void setAdresse(string adresse)
        {
            this.adresse = adresse;
        }
        public string getEmail() { return this.email; }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public int getCin() { return this.cin; }
        public void setCin(int cin)
        {
            this.cin = cin;
        }
        public string getLieunaiss() { return this.lieu_naiss; }
        public void setLiaunaiss(string lieunaiss)
        {
            this.lieu_naiss = lieunaiss;
        }
        
        public List<Compte> getComptes() { return comptes; }
       
        public void setComptes(List<Compte> comptes)
        {
            this.comptes = comptes;
        }

        public void addCompteEpargne(int numCompte, double SoldeInitial, double soldeepargne)
        {
            Compte compte = new compteepargne(numCompte, SoldeInitial, soldeepargne);
            comptes.Add(compte); 
        }

        public void addCompteCourant(int numCompte, double SoldeInitial, double decouvert)
        {
            Compte compte = new comptecourant(numCompte, SoldeInitial, decouvert);
            comptes.Add(compte);
        }


    }
}
