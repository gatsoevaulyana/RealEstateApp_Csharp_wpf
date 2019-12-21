using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class RealEstate : Form
    {

        private List<RealEstateInterface> realEstates = new List<RealEstateInterface>();
        private List<ClientInterface> clients = new List<ClientInterface>();
        public DataTable table1 = new DataTable();
        public DataTable table2 = new DataTable();


        public RealEstate()
        {
            InitializeComponent();

            table1.Columns.Add("Region", typeof(string));
            table1.Columns.Add("Address", typeof(string));
            table1.Columns.Add("Area", typeof(string));
            table1.Columns.Add("Construction Date", typeof(string));
            table1.Columns.Add("Type", typeof(string));
            table1.Columns.Add("Price", typeof(string));

            table2.Columns.Add("Client Name");
            table2.Columns.Add("Last name");
            table2.Columns.Add("Phone Number");

            table2.Columns.Add("Bank Account");
            table2.Columns.Add("Status");
            table2.Columns.Add("Price");
            table2.Columns.Add("Propositions");
        }

       
        private void openNewEntryForm_Click(object sender, EventArgs e)
        {
            

            AddNewRealEstate realEstateFrom = new AddNewRealEstate(this);
            realEstateFrom.Show(this);
        }

        
        public void handledRealForm(AddNewRealEstate realEstateFrom)
        {
            if (realEstateFrom.isHandled)
            {
                RealEstateInterface buffer = new RealEstateModel(realEstateFrom.realEstateComponents);
                this.addInternalRealStorage(buffer);
                this.addToDataGridReal(buffer);
            }
        }

        public void handledClientForm(AddNewClient addNewClient)
        {
            if (addNewClient.isHandled)
            {
                ClientModel buffer = new ClientModel(addNewClient.realClientsComponents);
                this.addInternalClientStorage(buffer);
                this.addToDataGridClient(buffer);
            }
        }


        
        private void addInternalRealStorage(RealEstateInterface realEstate)
        {
            this.realEstates.Add(realEstate);
        }

       
        private void addToDataGridReal(RealEstateInterface realEstate)
        {
            this.table1.Rows.Add(BL.RealEstate.GetEstate().ToArray());
           
        }


        private void addInternalClientStorage(ClientInterface cli)
        {
            this.clients.Add(cli);
        }

      
        private void addToDataGridClient(ClientInterface cli)
        {
            table2.Clear();
            for (int i = 0; i < BL.Client.GetCountClient(); i++)
            {
                this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
            }

            createPropos();

        }
  
        private void RealEstate_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Clients");
            comboBox1.Items.Add("RealEstates");
            comboBox1.SelectedItem = "RealEstates";

            comboBox2.Items.Add("Name");
            comboBox2.Items.Add("Last Name");
            comboBox2.Items.Add("Bank Account");
            comboBox1.SelectedItem = "Name";

            comboBox3.Items.Add("Price");
            comboBox3.Items.Add("Type");
            comboBox1.SelectedItem = "Price";


        }
      


        public  void createPropos()
        {
            
            List<String> e = new List<String>();
            foreach (DataRow rowSampleOne in table2.Rows)
            {
                rowSampleOne["Propositions"] = "";
                List<List<string>> stss = BL.Client.createPropose(Convert.ToInt32(rowSampleOne["Price"].ToString()));
                e.Clear();
                foreach (List<string> s in stss)
                {
                   
                    e.Add((string.Join(", ", s)));
                    rowSampleOne["Propositions"] += (string.Join(", ", s));
                    rowSampleOne["Propositions"] += "\n";
                }

               
            }
            ClientOrRealState c = new ClientOrRealState(this, e);
           
            c.Show(this);
            
        }

       
    
        private void saveEntries_Click(object sender, EventArgs e)
        {
            AddNewClient addNewClient = new AddNewClient(this);
            addNewClient.Show(this);
        }

        
        private void loadEntries_Click(object sender, EventArgs e)
        {
            
            BL.Client.deserialClients();
            table2.Clear();
            for (int i = 0; i < BL.Client.GetCountClient(); i++)
            {
                this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
            }

         
        }
    

        private void realEstatesDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priceConstraint_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {


                realEstatesDataView.DataSource = table2;

            }
            if (comboBox1.SelectedIndex == 1)
            {


                realEstatesDataView.DataSource = table1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            BL.Client.serialClients();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove remove = new Remove(this);
            remove.Show(this);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BL.Client.sortName();
            table2.Clear();
            for (int i = 0; i < BL.Client.GetCountClient(); i++)
            {
                this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BL.RealEstate.deserialEstates();
            table1.Clear();
            for (int i = 0; i < BL.RealEstate.GetCountEstate(); i++)
            {
                this.table1.Rows.Add(BL.RealEstate.refreshEstates(i).ToArray());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BL.RealEstate.serialEstates();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            BL.Client.sortLastName();
            table2.Clear();
            for (int i = 0; i < BL.Client.GetCountClient(); i++)
            {
                this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BL.Client.sortBackAcc();
            table2.Clear();
            for (int i = 0; i < BL.Client.GetCountClient(); i++)
            {
                this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BL.RealEstate.sortPrice();
            table1.Clear();
            for (int i = 0; i < BL.RealEstate.GetCountEstate(); i++)
            {
                this.table1.Rows.Add(BL.RealEstate.refreshEstates(i).ToArray());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(this);
            edit.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                SearchClient cli = new SearchClient(this);
                cli.Show(this);

            }

            if (comboBox1.SelectedIndex == 1)
            {
                SearchEstate estate = new SearchEstate(this);
                estate.Show(this);
               
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                List<List<string>> s = new List<List<string>>();
                List<string> s1 = new List<string>();
                BL.Client.sortName();
                foreach (DataRow rowSampleOne in table2.Rows)
                {
                    s1.Add(rowSampleOne["Propositions"].ToString());

                }
                table2.Rows.Clear();
                for (int i = 0; i < BL.Client.GetCountClient(); i++)
                {
                    this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
                    table2.Rows[i]["Propositions"] = s1[i];
                }

            }
            if (comboBox2.SelectedIndex == 1)
            {


                BL.Client.sortLastName();
                table2.Clear();
                for (int i = 0; i < BL.Client.GetCountClient(); i++)
                {
                    this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
                }
            }

            if (comboBox2.SelectedIndex == 2)
            {


                BL.Client.sortBackAcc();
                table2.Clear();
                for (int i = 0; i < BL.Client.GetCountClient(); i++)
                {
                    this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
                }
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {


                BL.RealEstate.sortPrice();
                table1.Clear();
                for (int i = 0; i < BL.RealEstate.GetCountEstate(); i++)
                {
                    this.table1.Rows.Add(BL.RealEstate.refreshEstates(i).ToArray());
                }
            }
           
        }
    }
    }
    






