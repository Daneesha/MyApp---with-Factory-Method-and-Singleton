using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech.PracticalAplications.FactoryMethod.MyApp.Domain;

namespace Tech.PracticalAplications.FactoryMethod.MyApp.Presentation
{
    public partial class LinkViewAddNew : UserControl
    {
        public LinkViewAddNew()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string line = txtLine.Text;

            LinksTab linksTab = LinksTab.Instance();
            linksTab.FactoryMethod_AddNewItem(name, line);
        }
    }
}
