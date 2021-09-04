using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
   public class InvoiceSummary
    {
      

        //variables
        private int numberOfRides;
        public double totalFare;
        private double averageFare;

       public  InvoiceSummary(int numberofRides , double totalFare)
        {
            //setting data
            this.numberOfRides = numberofRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;

        }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;
            InvoiceSummary inputedObject = (InvoiceSummary)obj;
            return this.numberOfRides == inputedObject.numberOfRides && this.totalFare == inputedObject.totalFare && this.averageFare == inputedObject.averageFare;

        }

        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();

        }
       
    }
}
