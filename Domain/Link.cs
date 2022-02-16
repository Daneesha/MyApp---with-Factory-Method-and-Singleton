using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech.PracticalAplications.FactoryMethod.MyApp.DataAccess;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Domain
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Link : Item
    {
        public string Name { set; get; }

        //public Link GetLink()
        //{
        //    return new Link();
        //}
        public void SaveLink()
        {

        }
        public override int DisplayCount()
        {
            return 0;
        }
    }
}
