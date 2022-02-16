using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Domain
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class Page
    {
        public abstract Item FactoryMethod();

        public abstract List<Item> FactoryMethod_FindAllItems();

        public abstract void FactoryMethod_AddNewItem(string name, string line);

        public abstract void FactoryMethod_UpdateItem(int ID, string name, string line);
    }
}
