using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Domain
{
    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    public abstract class Item : IItem
    {
        public int ID { get; set; }
        public string Line { get; set; }
        public int Count()
        {
            return 0;
        }
        public abstract int DisplayCount();
    }
}
