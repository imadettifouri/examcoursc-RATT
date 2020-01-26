using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace examcours
{
    class transaction
    {
        private DateTime date;
        private double montant;
        private int type;

        public transaction(DateTime date ,int type,double montant)
        {
            this.date = date;
            this.montant = montant;
            
        }

        public override string ToString()
        {
            return "Date :" + this.date  +"Type :"+this.type + "montant :" + this.montant;
        }

    }
}
