using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
{

    public partial class FormToEditEstate : Form
    {
        private readonly Edit _edit;
        private readonly RealEstate _realEstate;
        private int i = 0;
        public FormToEditEstate(RealEstate realEstate, Edit edit, int index)
        {
            _realEstate = realEstate;
            _edit = edit;
            i = index;
            InitializeComponent();
        }
        public FormToEditEstate()
        {
            InitializeComponent();
        }

        private void FormToEditEstate_Load(object sender, EventArgs e)
        {
            this.regionName.Text = "Region";
            this.addressName.Text = "Adress";
            this.area.Text = "123456";
            this.type.Text = "Type";
            this.constructionDate.Text = "123456";
            this.price.Text = "123456";
        }

        private void saveEntry_Click(object sender, EventArgs e)
        {
            List<String> inputData1 = new List<String> {
                regionName.Text,addressName.Text,area.Text,constructionDate.Text,type.Text,price.Text
            };
            BL.RealEstate.editEstate(inputData1, i);
            _realEstate.table1.Clear();
            for (int i = 0; i < BL.RealEstate.GetCountEstate(); i++)
            {
                _realEstate.table1.Rows.Add(BL.RealEstate.refreshEstates(i).ToArray());
            }
            this.Close();
            _edit.Close();
        }
    }
}
