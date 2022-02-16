using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech.PracticalAplications.FactoryMethod.MyApp.DataAccess;
using Tech.PracticalAplications.FactoryMethod.MyApp.Domain;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DrawLinks(List<LinkView> linksList)
        {
            DrawAddNew();

            for (int i = 0; i < linksList.Count; i++)
            {
                linksList[i].Location = new System.Drawing.Point(5, 150 + (i * 170));
                this.Controls.Add(linksList[i]);
            }
        }

        private void DrawAddNew()
        {
            LinkViewAddNew addNew = new LinkViewAddNew();
            addNew.Location = new System.Drawing.Point(5, 5);
            this.Controls.Add(addNew);
        }
    }
}
