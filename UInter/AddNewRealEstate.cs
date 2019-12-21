using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class AddNewRealEstate : Form
    {
        private readonly RealEstate _realEstate;
        public List<string> realEstateComponents = new List<string>();
        const string REQUIRED_FIELDS = "All Fields are required!";
        public bool isHandled = false;

        public AddNewRealEstate()
        {
            InitializeComponent();
        }
        public AddNewRealEstate(RealEstate realEstate)
        {
            _realEstate = realEstate;
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void saveEntry_Click(object sender, EventArgs e)
        {
            _realEstate.comboBox1.SelectedIndex = 1;

            List<TextBox> inputData = new List<TextBox> {
                regionName,addressName,area,constructionDate,type,price
            };
            List<String> inputData1 = new List<String> {
                regionName.Text,addressName.Text,area.Text,constructionDate.Text,type.Text,price.Text
            };
            try
            {
                this.ValidateInput(inputData);
                this.HandleData(inputData);
                this.isHandled = true;


                BL.RealEstate.AddEstate(inputData1);

                RealEstate parent = (RealEstate)this.Owner;
                parent.handledRealForm(this);
               //_realEstate. table2.Clear();
               // for (int i = 0; i < BL.Client.GetCountClient(); i++)
               // {
               //     _realEstate.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
               // }

              //  _realEstate.createPropos();

                this.Close();
                
            }
            catch (Exception ex)
            {
                string msg = ex.Message;

                MessageBox.Show(msg);
            }
        }
        //1
        private void HandleData(List<TextBox> inputData)
        {
            foreach (TextBox textBox in inputData)
            {
                this.realEstateComponents.Add(textBox.Text);
            }
        }

        private bool IsEmpty(TextBox tx)
        {
            return tx.TextLength == 0;
        }

        private void ValidateInput(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (this.IsEmpty(textBox))
                {
                    throw new Exception(REQUIRED_FIELDS);
                }
            }
        }

        private void AddNewRealEstate_Load(object sender, EventArgs e)
        {
            this.regionName.Text = "Region";
            this.addressName.Text = "Adress";
            this.area.Text = "123456";
            this.type.Text = "Type";
            this.constructionDate.Text = "123456";
            this.price.Text = "123456";
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void regionName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
