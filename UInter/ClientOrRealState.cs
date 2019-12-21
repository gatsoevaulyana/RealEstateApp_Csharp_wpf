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
    public partial class ClientOrRealState : Form
    {
        private readonly RealEstate _realEstate;
        public bool isHandled = false;
        public List<string> clientsOrReal = new List<string>();
        public List<string> ss = new List<string>();

        public String s = "";
        public ClientOrRealState()
        {
            InitializeComponent();
        }


        public ClientOrRealState(RealEstate realEstate, List<String> s)
        {
            _realEstate = realEstate;
            InitializeComponent();
            this.ss = s;
           
            
        }

     
        
        private void ClientOrRealState_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            for (int i = 0; i < ss.Count; i++)
            {
                checkedListBox1.Items.Insert(i, ss[i]);
            }

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

              foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
              {
                  checkedListBox1.Items.Remove(item);
              }
              /*
              
              */
           

        }


        private void button1_Click_1(object sender, EventArgs e)
        {


            var texts = this.checkedListBox1.Items.Cast<object>()
                  .Select(x => this.checkedListBox1.GetItemText(x));
            int i = _realEstate.table2.Rows.Count;
            _realEstate.table2.Rows[i - 1]["Propositions"] = string.Join(",", texts);

            foreach (var item in checkedListBox1.Items.OfType<string>().ToList())
            {
                checkedListBox1.Items.Remove(item);
            }

            // MessageBox.Show(string.Join(",", texts));
            this.Close();
        }
    }
}
