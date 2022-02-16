using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Domain
{
    public interface IItem
    {
        int ID { get; set; }
        string Line { get; set; }
    }
}
