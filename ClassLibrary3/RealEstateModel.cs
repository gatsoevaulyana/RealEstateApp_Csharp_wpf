
using System;
using System.Collections.Generic;

namespace ClassLibrary3
{
    [Serializable]
    public  class RealEstateModel : RealEstateInterface
    {
        public static List<RealEstateModel> estates = new List<RealEstateModel>();
        private string region;
        private string address;
        private double area;
        private string type;
        private string constructionDate;
        private decimal price;

        public string Region { get => region; set => region = value; }
        public string Address { get => address; set => address = value; }
        public double Area { get => area; set => area = value; }
        public string Type { get => type; set => type = value; }
        public string ConstructionDate { get => constructionDate; set => constructionDate = value; }
        public decimal Price { get => price; set => price = value; }

       
        public RealEstateModel(string _region, string _address, double _area,  string _constructionDate, string _type, decimal _price)
        {
            this.region = _region;
            this.address = _address;
            this.area = _area;
            this.type = _type;
            this.constructionDate = _constructionDate;
            this.price = _price;
        }
      
        public RealEstateModel(List<string> list)
        {
            this.Handle(list);
        }

       
        public string getRegion()
        {
            return region;
        }
       
        public double getArea()
        {
            return area;
        }

        
        public decimal getPrice()
        {
            return price;
        }

        public string[] GetInfoAsArray()
        {
            return new string[] { this.region, this.address, this.area.ToString(), this.constructionDate, this.type, this.price.ToString()}; 
        }

       
        public string getInfoAsString()
        {
            return  this.region +"\t"+ this.address + "\t" + this.area.ToString() + "\t" + this.constructionDate + "\t" + this.type + "\t" + this.price.ToString() ;
        }

       
        private void Handle(List<string> list)
        {
            try
            {
                this.region = list[0];
                this.address = list[1];
                double.TryParse(list[2], out this.area);
                this.constructionDate = list[3];
                this.type = list[4];
                decimal.TryParse(list[5], out this.price);
            }
            catch (Exception)
            {
                
            }
            
        }
    }
}
