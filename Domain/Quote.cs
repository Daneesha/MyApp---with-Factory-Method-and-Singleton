using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Domain
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Quote : Item
    {
        public DateTime Date { set; get; }
        public string Author { set; get; }

        //public Quote GetQuote()
        //{
        //    return new Quote();
        //}
        public void SaveQuote()
        {

        }
        public override int DisplayCount()
        {
            return 0;
        }
    }
}
