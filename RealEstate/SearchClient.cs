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
    public partial class SearchClient : Form
    {
        private readonly RealEstate _realEstate;
        public SearchClient()
        {
            InitializeComponent();
        }
        public SearchClient(RealEstate realEstate)
        {
            _realEstate = realEstate;
            InitializeComponent();
        }
        private void search_Click(object sender, EventArgs e)
        {

                List<string> st = new List<string>();
                if (nameConstraint.Text != "")
                {
                    st.Add(nameConstraint.Text);
                }
                if (lastNameConstraint.Text != "")
                {
                    st.Add(lastNameConstraint.Text);
                }
                if (priceConstraint2.Text != "0,00")
                {
                    st.Add(priceConstraint2.Text);
                }
                if (phoneConstraint.Text != "")
                {
                    st.Add(phoneConstraint.Text);
                }
                if (statusConstraint.Text != "")
                {
                    st.Add(statusConstraint.Text);
                }
                if (bankAccConstraint.Text != "")
                {
                    st.Add(bankAccConstraint.Text);
                }

                searchResults.Items.Clear();
                List<List<string>> stss = BL.Client.ReternListSearchClient(st);
                foreach (List<string> s in stss)
                {
                    searchResults.Items.Add(s[0] + " " + s[1] + s[2] + " " + s[3] + " " + s[4] + " " + s[5]);
                }

            
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {

        }
    }
}
