using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExamples.Structural.Proxy
{
    public interface IOrderSystem
    {
        bool MakeOrder();
        bool MakePayment();
    }

    public class OrderSystem : IOrderSystem
    {
        public bool MakeOrder()
        {
            Console.WriteLine("Process Order");
            return true;
        }

        public bool MakePayment()
        {
            Console.WriteLine("Process payment");
            return true;
        }
    }

    public class OrderSystemProxy : IOrderSystem
    {
        public string CurrentUser = string.Empty;
        private OrderSystem OrderSystem = null;

        public OrderSystemProxy(string user)
        {
            CurrentUser = user;
            OrderSystem = new OrderSystem();
        }

        public bool MakeOrder()
        {
            return OrderSystem.MakeOrder();
        }

        public bool MakePayment()
        {
            if (CurrentUser == "Intern")
            {
                Console.WriteLine("Intern is not allow to make payment");
                return false;
            }
            else
            {
                return OrderSystem.MakePayment();
            }
        }
    }
}
