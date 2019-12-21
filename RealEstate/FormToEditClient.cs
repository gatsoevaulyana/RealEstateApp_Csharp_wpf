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

    public partial class FormToEditClient : Form
    {
        private readonly RealEstate _realEstate;
        private readonly Edit _edit;
        private int i=0;
        public FormToEditClient(RealEstate realEstate, Edit edit, int index)
        {
            _realEstate = realEstate;
            _edit = edit;
            i = index;
            InitializeComponent();
        }
        public FormToEditClient()
        {
            InitializeComponent();
        }

        private void FormToEditClient_Load(object sender, EventArgs e)
        {
            this.clientName.Text = "Name";
            this.clientSurname.Text = "LastName";
            this.phoneNumber.Text = "123456";
            this.bankAccount.Text = "123456";
            this.status.Text = "Closed";
            this.price.Text = "123456";
        }

        private void saveEntry_Click(object sender, EventArgs e)
        {


            List<string> inputData1 = new List<string> {
                clientName.Text,phoneNumber.Text,clientSurname.Text,bankAccount.Text,status.Text, price.Text
            };

            BL.Client.editClient(inputData1, i);
            _realEstate.table2.Clear();
            for (int i = 0; i < BL.Client.GetCountClient(); i++)
            {
                _realEstate.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
            }

            this.Close();
            _edit.Close();
        }
    }
}
