using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech.PracticalAplications.FactoryMethod.MyApp.Domain;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Presentation
{
    /// <summary>
    /// Program startup class for Structural 
    /// Factory Method Design Pattern.
    /// </summary>
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Form1 form1 = new Form1();

            // An array of creators
            Page[] pages = new Page[2];
            pages[0] = QuotesTab.Instance();
            pages[1] = LinksTab.Instance();

            // Iterate over creators and create products
            //foreach (Page page in pages)
            //{
            //    //Item item = page.FactoryMethod();
            //    //Console.WriteLine("Created {0}",
            //    //  product.GetType().Name);

            //    List<Item> items = page.FactoryMethod1();
            //}

            List<Item> linkItems = pages[1].FactoryMethod_FindAllItems();
            List<LinkView> linkViews = new List<LinkView>();

            for (int i = 0; i < linkItems.Count; i++)
            {
                LinkView linkView = new LinkView();

                //linkView.Location = new System.Drawing.Point(50, 50 + (x * 100));

                //lbl.Name = "label_" + x.ToString();
                //lbl.Text = "Label " + x.ToString();

                //this.panel1.Controls.Add(lbl);

                //form1.panel1.Controls.Add(linkView);

                linkView.BindLink(linkItems[i]);

                linkViews.Add(linkView);
            }

            form1.DrawLinks(linkViews);
            //for (int x = 0; x <= 3; x++)
            //{
            //    LinkView linkView = new LinkView();

            //    linkView.Location = new System.Drawing.Point(50 , 50 + (x * 100));

            //    //lbl.Name = "label_" + x.ToString();
            //    //lbl.Text = "Label " + x.ToString();

            //    //this.panel1.Controls.Add(lbl);

            //    //form1.panel1.Controls.Add(linkView);

            //    form1.Controls.Add(linkView);
            //}

            //for (int x = 0; x <= 3; x++)
            //{
            //    Label lbl = new Label();

            //    //create new label location after each loop
            //    //by multiplying the new value of variable x by 5, so the new label 
            //    //control will not overlap each other.
            //    lbl.Location = new System.Drawing.Point(52 + (x * 30), 58 + (x * 30));
            //    //create new id and text of the label
            //    lbl.Name = "label_" + x.ToString();
            //    lbl.Text = "Label " + x.ToString();

            //    form1.Controls.Add(lbl);
            //}

            //form1.Controls.Add(new LinkView());
            //form1.Controls.Add(new LinkView());
            Application.Run(form1);
        }
    }
}
