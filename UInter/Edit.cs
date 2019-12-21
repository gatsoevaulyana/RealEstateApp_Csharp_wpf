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
    public partial class Edit : Form
    {

        private readonly RealEstate _realEstate;
        public Edit()
        {
            InitializeComponent();
        }
        public Edit(RealEstate realEstate)
        {
            _realEstate = realEstate;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBox1.Text) - 1;

            if (_realEstate.comboBox1.SelectedIndex == 0)
            {
                FormToEditClient cli = new FormToEditClient(_realEstate,this, index);
                cli.Show(this);

            }

            if (_realEstate.comboBox1.SelectedIndex == 1)
            {
                FormToEditEstate estate = new FormToEditEstate(_realEstate, this, index);
                estate.Show(this);
                //_realEstate.table1.Rows.Remove(_realEstate.table1.Rows[BL.BLL.remove(index)]);
            }
            
        }

        private void Edit_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
