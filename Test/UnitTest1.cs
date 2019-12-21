using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using ClassLibrary3;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        
        public UnitTest1()
        {
            ClientModel.clients.Clear();
            RealEstateModel.estates.Clear();
            ClientModel.clients.Add(new ClientModel("Name", "LastName", 1, "1", "Opened", 1));
            ClientModel.clients.Add(new ClientModel("Name2", "LastName2", 2, "2", "Opened", 2));
            ClientModel.clients.Add(new ClientModel("Name3", "LastName3", 3, "3", "Opened", 3));

            RealEstateModel.estates.Add(new RealEstateModel("Region", "Address", 1, "01.01.01", "Flat", 1));
            RealEstateModel.estates.Add(new RealEstateModel("Region2", "Address2", 2, "02.02.02", "Flat", 2));
        }
        [TestMethod]
        public void getClientCount()
        {
            object expect = ClientModel.clients.Count;
            object actual = BL.Client.GetCountClient();

            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void getEstateCount()
        {
            object expect = RealEstateModel.estates.Count;
            object actual = BL.RealEstate.GetCountEstate();

            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void removeCli()
        {
            int i = BL.Client.remove(0);
            object expect = 2;
            object actual = ClientModel.clients.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void removeEstate()
        {
            int i = BL.RealEstate.remove(0);
            object expect = 1;
            object actual = RealEstateModel.estates.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void sortName()
        {
            BL.Client.sortName();
            object expect = "Name";
            object actual = ClientModel.clients[0].getName();

            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void sortLastName()
        {
            BL.Client.sortName();
            object expect = "LastName";
            object actual = ClientModel.clients[0].getLastName();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void sortBankAcc()
        {
            BL.Client.sortBackAcc();
            object expect = "1";
            object actual = ClientModel.clients[0].getBankAcc();

            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void sortPrice()
        {
            BL.RealEstate.sortPrice();
            object expect = (decimal)1;
            object actual = RealEstateModel.estates[0].getPrice();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void addClient()
        {
            
            
          
            BL.Client.AddClient("Name4", "LastName4", 4, "4", "Opened", 4);
            object expect = 4;
            object actual = ClientModel.clients.Count;

            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void addEstate()
        {

     
            BL.RealEstate.AddEstate("Region3", "Address3", 3, "03.03.03", "flat", 3);
            object expect = 3;
            object actual = RealEstateModel.estates.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SearchClforLastName()
        {
           List<ClientModel> c = BL.Client.SearchClforLastName("LastName3");
            object expect = 1;
            object actual = c.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SearchClforName()
        {
            List<ClientModel> c = BL.Client.SearchClforName("Name2");
            object expect = 1;
            object actual = c.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SearchClforPrice()
        {
            List<ClientModel> c = BL.Client.SearchClforPrice("3");
            object expect = 1;
            object actual = c.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SearchEstateforPrice()
        {
            List<RealEstateModel> c = BL.RealEstate.SearchClforPrice("2");
            object expect = 1;
            object actual = c.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SearchEstateforRegion()
        {
            List<RealEstateModel> c = BL.RealEstate.SearchClforRegion("Region2");
            object expect = 1;
            object actual = c.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SearchEstateforType()
        {
            List<RealEstateModel> c = BL.RealEstate.SearchClforType("Flat");
            object expect = 2;
            object actual = c.Count;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetClientName()
        {
            
            object expect = "Name";
            object actual = ClientModel.clients[0].Name;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetClientLastName()
        {

            object expect = "LastName";
            object actual = ClientModel.clients[0].Last_name;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetClientStatus()
        {

            object expect = "Opened";
            object actual = ClientModel.clients[0].Status;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetClientPrice()
        {

            object expect = 1;
            object actual = ClientModel.clients[0].Price;

            Assert.AreEqual(expect, actual);
        }

        public void GetEstatePrice()
        {

            object expect = 1;
            object actual = RealEstateModel.estates[0].Price;

            Assert.AreEqual(expect, actual);
        }

        public void GetEstateType()
        {

            object expect = "Flat";
            object actual = RealEstateModel.estates[0].Type;

            Assert.AreEqual(expect, actual);
        }
    }
}
