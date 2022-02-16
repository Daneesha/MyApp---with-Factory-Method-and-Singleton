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
    public partial class LinkView : UserControl
    {
        int ID;
        public LinkView()
        {
            InitializeComponent();
        }

        public void BindLink(Item link)
        {
            this.ID = ((Link)link).ID;
            this.txtName.Text = ((Link)link).Name;
            this.txtLine.Text = ((Link)link).Line;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string line = txtLine.Text;

            LinksTab linksTab = LinksTab.Instance();
            linksTab.FactoryMethod_UpdateItem(ID, name, line);
        }
    }
}
