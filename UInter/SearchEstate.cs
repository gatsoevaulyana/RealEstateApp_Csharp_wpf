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
    public partial class SearchEstate : Form
    {
        private readonly RealEstate _realEstate;
        public SearchEstate()
        {
            InitializeComponent();
        }
        public SearchEstate(RealEstate realEstate)
        {
            _realEstate = realEstate;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

                List<string> st = new List<string>();
                if (regionConstraint.Text != "")
                {
                    st.Add(regionConstraint.Text);
                }
                if (areaConstraint.Text != "0,00")
                {
                    st.Add(areaConstraint.Text);
                }
                if (priceConstraint.Text != "0,00")
                {
                    st.Add(priceConstraint.Text);
                }
                if (typeConstraint.Text != "")
                {
                    st.Add(typeConstraint.Text);
                }
                if (addressC.Text != "")
                {
                    st.Add(addressC.Text);
                }
                if (DateC.Text != "")
                {
                    st.Add(DateC.Text);
                }

                searchResults.Items.Clear();
                List<List<string>> stss = BL.RealEstate.ReternListSearchEstate(st);
                foreach (List<string> s in stss)
                {
                    searchResults.Items.Add(s[0] + " " + s[1] + " " + s[2] + " " + s[3] + " " + s[4] + " " + s[5]);
                }


            }

        private void SearchEstate_Load(object sender, EventArgs e)
        {

        }
    }
    }

