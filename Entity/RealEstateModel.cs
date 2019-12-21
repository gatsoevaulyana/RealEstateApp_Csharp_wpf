using RealEstate.Interfaces;
using System;
using System.Collections.Generic;

namespace RealEstate.Models
{
    class RealEstateModel : RealEstateInterface
    {
        private string region;
        private string address;
        private double area;
        private string type;
        private string constructionDate;
        private decimal price;

        /**
         * Initial constructor for RealEstate class
         * 
         * @return void
         */
        public RealEstateModel(string _region, string _address, double _area,  string _constructionDate, string _type, decimal _price)
        {
            this.region = _region;
            this.address = _address;
            this.area = _area;
            this.type = _type;
            this.constructionDate = _constructionDate;
            this.price = _price;
        }
        /**
         * Method Overloading of the Contstructor
         */
        public RealEstateModel(List<string> list)
        {
            this.Handle(list);
        }

        // DISCLAMER: I do not like the default getters and setters so I do them like that;

        /**
         * Region Getter
         */
        public string getRegion()
        {
            return region;
        }
        /**
         * Area Getter
         */
        public double getArea()
        {
            return area;
        }

        /**
         * Price Getter
         */
        public decimal getPrice()
        {
            return price;
        }

        /**
         * Retrieves all private information as Array
         */
        public string[] GetInfoAsArray()
        {
            return new string[] { this.region, this.address, this.area.ToString(), this.constructionDate, this.type, this.price.ToString()}; 
        }

        /**
         * Retrieves all private information as string
         */
        public string getInfoAsString()
        {
            return  this.region +"\t"+ this.address + "\t" + this.area.ToString() + "\t" + this.constructionDate + "\t" + this.type + "\t" + this.price.ToString() ;
        }

        /**
         * Creates instance of RealEstate with given structure of data
         */
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
                // TODO do something if the parsing fails - not sure what exactly
            }
            
        }
    }
}
