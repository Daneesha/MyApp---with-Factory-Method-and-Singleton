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
    public class QuotesTab : Page
    {
        static QuotesTab instance;

        protected QuotesTab()
        {
        }

        public static QuotesTab Instance()
        {
            if (instance == null)
            {
                instance = new QuotesTab();
            }
            return instance;
        }

        public override Item FactoryMethod()
        {
            return new Quote();
        }

        public override List<Item> FactoryMethod_FindAllItems()
        {
            List<Item> items = new List<Item>();
            DataSet dataSet = QuoteGateway.FindAllQuotes();

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    Quote quote = new Quote();
                    quote.ID = (int)row[0];
                    quote.Date = (DateTime)row[1];
                    quote.Line = (string)row[2];
                    quote.Author = (string)row[3];

                    items.Add(quote);
                }
            }
            return items;
        }

        public override void FactoryMethod_AddNewItem(string line, string author)
        {
            int ID = QuoteGateway.FindAllQuotes().Tables[0].Rows.Count + 1;
            QuoteGateway.InsertQuote(ID, DateTime.Now, line, author);
        }

        public override void FactoryMethod_UpdateItem(int ID, string line, string author)
        {
            LinkGateway.UpdateLink(ID, line, author);
        }
    }
}
