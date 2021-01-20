using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Management
{
    class CustomerManager
    {
        public void addcustomer(Customer customerinf)
        {
            Console.WriteLine("Hi ! Your ");
            Console.WriteLine("New Customer is  :" + customerinf.CustomerGID + " " +customerinf.CustomerName + " " + customerinf.CustomerSurname);
        }
        public void CustomerList(Customer[] listingCustomer)
        {
            Console.WriteLine("Customer Information");

            foreach (Customer customerinf in listingCustomer)
            {
                Console.WriteLine("CustomerID : " + customerinf.CustomerId);
                Console.WriteLine("Customer Name : " + customerinf.CustomerName);
                Console.WriteLine("Customer SurName: " + customerinf.CustomerSurname);
                Console.WriteLine("Customer GovermentID : " + customerinf.CustomerGID);
                Console.WriteLine("Cuotomer Sex : " + customerinf.CustomerSex);
                Console.WriteLine("Customer Marial Status : " + customerinf.CustomerMS);
                Console.WriteLine("Cuotomer Education : " + customerinf.CustomerEDU);
                Console.WriteLine("Your Customer is " + " " + customerinf.CustomerName + " " + customerinf.CustomerSurname );
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");


            }

        }

        public void delete(Customer customerinf)
        {
            Console.WriteLine("Delete Customer is  :" + customerinf.CustomerGID + " " + customerinf.CustomerName + " " + customerinf.CustomerSurname);
        }
    }
}
