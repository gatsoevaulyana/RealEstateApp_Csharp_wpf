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
    public partial class Remove : Form
    {
        private readonly RealEstate _realEstate;
        public Remove()
        {
            InitializeComponent();
        }

        private void Remove_Load(object sender, EventArgs e)
        {

        }
        public Remove(RealEstate realEstate)
        {
            _realEstate = realEstate;
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> st = new List<string>();
            int index = Convert.ToInt32(textBox1.Text) - 1;
            if (_realEstate.comboBox1.SelectedIndex == 0)
            {
                _realEstate.table2.Rows.Remove(_realEstate.table2.Rows[BL.Client.remove(index)]);
               
            }

            if (_realEstate.comboBox1.SelectedIndex == 1)
            {
                _realEstate.table1.Rows.Remove(_realEstate.table1.Rows[BL.RealEstate.remove(index)]);
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
