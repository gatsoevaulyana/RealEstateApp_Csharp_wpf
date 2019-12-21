using RealEstate.Interfaces;
using RealEstate.Models;
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

        /**
         * Open new form view to read all information about the real Eastate;
         */
        private void openNewEntryForm_Click(object sender, EventArgs e)
        {
            /*   ClientOrRealState or = new ClientOrRealState();
               or.Show(this);
               */

            AddNewRealEstate realEstateFrom = new AddNewRealEstate(this);
            realEstateFrom.Show(this);
        }

        /**
         * Self made event Handler
         * It is called from the child component
         * giving all needed information about the real estate class
         */
        //1
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


        /**
         * Add entry to the Internal List for further computation
         */
        private void addInternalRealStorage(RealEstateInterface realEstate)
        {
            this.realEstates.Add(realEstate);
        }

        /**
         * Add entry to the DataGrid
         * Visualisation of the Real Estate Data
         */
        private void addToDataGridReal(RealEstateInterface realEstate)
        {
            this.table1.Rows.Add(BL.RealEstate.GetEstate().ToArray());
            //  this.table1.Rows.Add();
        }


        private void addInternalClientStorage(ClientInterface cli)
        {
            this.clients.Add(cli);
        }

        /**
         * Add entry to the DataGrid
         * Visualisation of the Real Estate Data
         */
        private void addToDataGridClient(ClientInterface cli)
        {
            table2.Clear();
            for (int i = 0; i < BL.Client.GetCountClient(); i++)
            {
                this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
            }

            createPropos();

        }
        /**
         * Basic Loader - Setting up the Data Grid View
         */
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
        /**
         * Clear the ListBox
         * Adds new found entries that satisfy given constraints
         */


        public  void createPropos()
        {
            //var result = realEstates.Where(this.QueryBuilder2).ToList();
            /*        List<String> e = new List<String>();
                    foreach (DataRow row2 in table2.Rows)
                    {
                        foreach (DataRow row in table1.Rows)
                        {
                            if (row["Price"].ToString().Contains(row2[5].ToString()))
                            {
                                e.Add(row[5].ToString());
                            }

                        }
                        row2[6] = string.Join(",", e);

                    }

                }
                */




            //foreach (DataRow rowSampleOne in table2.Rows)
            //{
            //    int myInt = Convert.ToInt32(rowSampleOne["Price"].ToString());
            //    //   String myReg = rowSampleOne["Region"].ToString();
            //    rowSampleOne["Propositions"] = "";

            //    foreach (DataRow rowSampleTwo in table1.Rows)
            //    {
            //        int myInt2 = Convert.ToInt32(rowSampleTwo["Price"].ToString());
            //        //   String myReg2 = rowSampleTwo["Region"].ToString();
            //        if (myInt >= myInt2 /*&& myReg2.Equals(myReg)*/)
            //        {

            //            //    e.Add(myInt2.ToString());// Do your stuff here
            //            rowSampleOne["Propositions"] += (string.Join(", ", rowSampleTwo.ItemArray));
            //            rowSampleOne["Propositions"] += "\n";
            //            //e.Add(string.Join(", ", rowSampleTwo.ItemArray));

            //        }
            //    }

            //    e.Add(string.Join(", ", table1.Rows[table1.Rows.Count - 1].ItemArray));
            //    //  rowSampleOne["Propositions"] = string.Join(",", e);
            //}
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

        /*

        List<String> e = new List<String>();
        bool flag = true;
        for (int i = 0; i < table1.Rows.Count; i++)
        {
            for (int j = 0; i < table2.Rows.Count; j++)
            {
                if (table1.Rows[i][5].ToString().Equals(table2.Rows[j][5].ToString()))
                {
                    e.Add(table1.Rows[j].ToString());
                }


                table2.Rows[i][6] = string.Join(",", e);
            }
        }
    }
    */




        /**
         * Predefined query with the given argument;
         * TODO - Make another class that will manage all possible queries by chaining statements
         */




        /**
        * Save entries to user specified txt file with right the structer
        */
        private void saveEntries_Click(object sender, EventArgs e)
        {
            AddNewClient addNewClient = new AddNewClient(this);
            addNewClient.Show(this);
        }

        /**
         * Load entries from given txt file with right structer
         */
        private void loadEntries_Click(object sender, EventArgs e)
        {
            //string line;
            //OpenFileDialog entriesFileOpen = new OpenFileDialog();

            //entriesFileOpen.DefaultExt = FILE_DEFAULT_EXTENSION;
            //entriesFileOpen.Filter = FILE_FILTER;

            //if (entriesFileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    StreamReader file = new StreamReader(entriesFileOpen.FileName);

            //    while ((line = file.ReadLine()) != null)
            //    {
            //        List<string> realEstateParameters = line.Split('\t').ToList();
            //        RealEstateInterface buffer = new RealEstateModel(realEstateParameters);
            //        this.addInternalRealStorage(buffer);
            //        this.addToDataGridReal(buffer);
            //    }
            BL.Client.deserialClients();
            table2.Clear();
            for (int i = 0; i < BL.Client.GetCountClient(); i++)
            {
                this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
            }

            // file.Close();
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
            //SaveFileDialog entriesFileLoc = new SaveFileDialog();

            //entriesFileLoc.DefaultExt = FILE_DEFAULT_EXTENSION;
            //entriesFileLoc.Filter = FILE_FILTER;

            //if (entriesFileLoc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    using (TextWriter writer = File.CreateText(entriesFileLoc.FileName))
            //    {
            //        foreach (RealEstateInterface estate in this.realEstates)
            //        {
            //            writer.WriteLine(estate.getInfoAsString());
            //        }
            //    }
            //}
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
                //_realEstate.table1.Rows.Remove(_realEstate.table1.Rows[BL.BLL.remove(index)]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {


                BL.Client.sortName();
                table2.Clear();
                for (int i = 0; i < BL.Client.GetCountClient(); i++)
                {
                    this.table2.Rows.Add(BL.Client.refreshCLients(i).ToArray());
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
    






