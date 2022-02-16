using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech.PracticalAplications.FactoryMethod.MyApp.DataAccess;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Domain
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class LinksTab : Page
    {
        static LinksTab instance;

        protected LinksTab()
        {
        }

        public static LinksTab Instance()
        {
            if (instance == null)
            {
                instance = new LinksTab();
            }
            return instance;
        }
        public override Item FactoryMethod()
        {
            //return new Link();

            Link link = new Link();
            return link;
        }

        public override List<Item> FactoryMethod_FindAllItems()
        {
            List<Item> items = new List<Item>();
            DataSet dataSet = LinkGateway.FindAllLinks();

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    Link link = new Link();
                    link.ID = (int)row[0];
                    link.Name = (string)row[1];
                    link.Line = (string)row[2];

                    items.Add(link);
                }
            }
            return items;
        }

        public override void FactoryMethod_AddNewItem(string name, string line)
        {
            int ID = LinkGateway.FindAllLinks().Tables[0].Rows.Count + 1;
            LinkGateway.InsertLink(ID, name, line);
        }

        public override void FactoryMethod_UpdateItem(int ID, string name, string line)
        {
            LinkGateway.UpdateLink(ID, name, line);
        }
    }
}
