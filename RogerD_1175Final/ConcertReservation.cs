using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogerD_1175Final2
{
    class ConcertReservation
    {

        //1. auto-properties
        public string CustomerName
        {
            get;set;
        }

        public int NumberOfAdultTickets
        {
            get;set;
        }

        public int NumberOfChildTickets
        {
            get; set;
        }


        //2. computed read-only property
        //Compute the Total Cost for each customer based on number of adult tickes and child tickets purchased
        public double TotalCost
        {
            get
            {
                const double ADULT_TICKET_PRICE = 49.99;
                const double CHILD_TICKET_PRICE = 17.99;
                return NumberOfAdultTickets * ADULT_TICKET_PRICE + NumberOfChildTickets * CHILD_TICKET_PRICE;
            }
        }

        //3. constructors

        //Paramterless constructor
        public ConcertReservation()
        {
            CustomerName = "";
            NumberOfAdultTickets = 0;
            NumberOfChildTickets = 0;
        }
        //Constructor with 3 parameters
        public ConcertReservation(string customerName, int numberOfAdultTickets, int numberOfChildTickets)
        {
            CustomerName = customerName;
            NumberOfAdultTickets = numberOfAdultTickets;
            NumberOfChildTickets = numberOfChildTickets;
        }

        //4. To string override method
        public override string ToString()
        {
            //Using formatted string in string.format() to format each customer item information
            string objectStr1 = String.Format(
                "{0, -22} {1, -22} {2, -22} {3, -22}",
                CustomerName, NumberOfAdultTickets.ToString("F0"), NumberOfChildTickets.ToString("F0"), TotalCost.ToString("F2"));

            return objectStr1;

        }
    }
}
