using NUnit.Framework;
using CabInvoiceGenerator;
using System;


namespace CaInvoiceGeneratorTest
{
    public class Tests
    {
        // InvoiceGenerator refrence
        InvoiceGenerator invoiceGenerator = null;



        //UC1 given distance and time should return toal fare
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //creating instance of invoicegenerator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            //calculating fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            //Asserting Values
            Assert.AreEqual(expected, fare);
        }


        //UC2 for multiple rides
        [Test]
        public void GiveMultipleRidesShouldReturnInvoiceSummary()
        {
            //Creating Instance of InvoiceGenerator For Normal Rides
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            //Generating Summary for Rides
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            //Asserting valuers.
            Assert.AreEqual(expectedSummary, summary);

        }
    }
}












