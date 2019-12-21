using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Interfaces;

namespace RealEstate.Models
{
    class ClientModel : ClientInterface
    {
        private string name;
        private string last_name;
        private int phone;
        private string bank_account;
        private string status;
        private int price;
        private String estates;
        public ClientModel(string name, string last_name, int phone, string bank_account, string status, int price)
        {
            this.name = name;
            this.last_name = last_name;
            this.phone = phone;
            this.bank_account = bank_account;
            this.status = status;
            this.price = price;
        }


        public ClientModel(List<string> list)
        {
            this.Handle(list);
        }
        public string[] GetInfoAsArray()
        {
            return new string[] { this.name, this.last_name, this.phone.ToString(), this.bank_account, this.status, this.price.ToString(), this.estates };
        }

        public string getInfoAsString()
        {
            return this.name + "\t" + this.last_name + "\t" + this.phone.ToString() + "\t" + this.bank_account + "\t" + this.status + "\t" + this.price.ToString() + "\t" +this.estates;
        }

        public string getName()
        {
            return this.name;
        }
        public string getLastName()
        {
            return this.last_name;
        }

        public string getBankAcc()
        {
            return this.bank_account;
        }

        public int getPhone()
        {
            return this.phone;
        }

        public string getStatus()
        {
            return this.status;
        }

        public int getPrice()
        {
            return this.price;
        }
        private void Handle(List<string> list)
        {
            try
            {
                this.name = list[0];
                this.last_name = list[1];
                int.TryParse(list[2], out this.phone);
                this.bank_account = list[3];
                this.status = list[4];
                int.TryParse(list[5], out this.price);
                this.estates = list[6];

            }
            catch (Exception)
            {
                // TODO do something if the parsing fails - not sure what exactly
            }

        }

    }
}
