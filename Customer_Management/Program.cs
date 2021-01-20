using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Management
{
    class Program
    {
        static void Main(string[] args)
        {
                Customer Customer1 = new Customer();
                Customer1.CustomerId = 232;
                Customer1.CustomerName = "Jaseo";
                Customer1.CustomerSurname = "Mersone";
                Customer1.CustomerGID = "M-151222";
                Customer1.CustomerSex = "Male";
                Customer1.CustomerMS = "Maried";
                Customer1.CustomerEDU = "Uni";

                Customer Customer2 = new Customer();
                Customer2.CustomerId = 454;
                Customer2.CustomerName = "Marta";
                Customer2.CustomerSurname = "Kayteriu";
                Customer2.CustomerGID = "F-23236366";
                Customer2.CustomerSex = "Female";
                Customer2.CustomerMS = "Single";
                Customer2.CustomerEDU = "Dr";

                Customer Customer3 = new Customer();
                Customer3.CustomerId = 252;
                Customer3.CustomerName = "Sonia";
                Customer3.CustomerSurname = "Warif";
                Customer3.CustomerGID = "F-78785588";
                Customer3.CustomerSex = "Female";
                Customer3.CustomerMS = "Maried";
                Customer3.CustomerEDU = "Dr";


                CustomerManager islemler = new CustomerManager();
                islemler.addcustomer(Customer1);
                islemler.delete(Customer3);

                Customer[] CustomerInformation = new Customer[] { Customer1, Customer2, Customer3 };
                islemler.CustomerList(CustomerInformation);
            }
        }
    }

