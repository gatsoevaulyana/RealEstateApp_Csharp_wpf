using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace BL
{
    public class Client
    {
        public static int GetCountClient()
        {
            return ClientModel.clients.Count;
        }

        public static List<ClientModel> SearchClforName(string st)
        {
            List<ClientModel> clms = new List<ClientModel>();
            foreach (ClientModel cm in ClientModel.clients)
            {
                if (cm.Name == st)
                    clms.Add(cm);
            }
            return clms;
        }
        public static List<ClientModel> SearchClforLastName(string st)
        {
            List<ClientModel> clms = new List<ClientModel>();
            foreach (ClientModel cm in ClientModel.clients)
            {
                if (cm.Last_name == st)
                    clms.Add(cm);
            }
            return clms;
        }
        public static List<ClientModel> SearchClforPhone(string st)
        {
            List<ClientModel> clms = new List<ClientModel>();
            foreach (ClientModel cm in ClientModel.clients)
            {
                if (Convert.ToString(cm.Phone) == st)
                    clms.Add(cm);
            }
            return clms;
        }

        public static List<ClientModel> SearchClforStatus(string st)
        {
            List<ClientModel> clms = new List<ClientModel>();
            foreach (ClientModel cm in ClientModel.clients)
            {
                if (cm.Status == st)
                    clms.Add(cm);
            }
            return clms;
        }

        public static List<List<string>> createPropose(int price)
        {
            List<List<string>> stss = new List<List<string>>();
            
            List<RealEstateModel> cm = new List<RealEstateModel>();
            
            foreach (RealEstateModel em in RealEstateModel.estates)
            {
                if (em.Price <= price)
               {
                  cm.Add(em);
               }
            }
            foreach (RealEstateModel cm1 in cm)
            {
                List<string> strings = new List<string>();
                strings.Add(cm1.Region);
                strings.Add(cm1.Address);
                strings.Add(Convert.ToString(cm1.Area));
                strings.Add(cm1.Type);
                strings.Add(cm1.ConstructionDate);
                strings.Add(Convert.ToString(cm1.Price));
                stss.Add(strings);
            }
            return stss;
           
        }

        public static List<ClientModel> SearchClforPrice(string st)
        {
            List<ClientModel> clms = new List<ClientModel>();
            foreach (ClientModel cm in ClientModel.clients)
            {
                if (Convert.ToString(cm.Price) == st)
                    clms.Add(cm);
            }
            return clms;
        }

        public static List<ClientModel> SearchClforBank_account(string st)
        {
            List<ClientModel> clms = new List<ClientModel>();
            foreach (ClientModel cm in ClientModel.clients)
            {
                if (cm.Bank_account == st)
                    clms.Add(cm);
            }
            return clms;
        }
        public static List<List<string>> ReternListSearchClient(List<string> sts)
        {
            List<List<string>> stss = new List<List<string>>();
            List<ClientModel> cm = new List<ClientModel>();
            for (int j = 0; j < ClientModel.clients.Count; j++)
            {
                int count = 0;
                for (int i = 0; i < sts.Count; i++)
                {
                    if (ClientModel.clients[j].getInfoAsString().Contains(sts[i]))
                    {
                        count++;
                    }
                }
                if (count == sts.Count)
                {
                    cm.Add(ClientModel.clients[j]);
                }
            }
            foreach (ClientModel cm1 in cm)
            {
                List<string> strings = new List<string>();
                strings.Add(cm1.Name);
                strings.Add(cm1.Last_name);
                strings.Add(Convert.ToString(cm1.Phone));
                strings.Add(cm1.Bank_account);
                strings.Add(cm1.Status);
                strings.Add(Convert.ToString(cm1.Price));
                stss.Add(strings);
            }
            return stss;
        }
        public static void AddClient(List<string> st)
        {
            ClientModel.clients.Add(new ClientModel(st));
        }

        public static void AddClient(string name, string last_name, int phone, string bank_account, string status, int price)
        {
            ClientModel.clients.Add(new ClientModel(name, last_name, phone, bank_account, status, price));
        }
        public static List<string> refreshCLients(int j)
        {
            List<string> st = new List<string>();
            for (int i = 0; i < ClientModel.clients[j].GetInfoAsArray().Length; i++)
            {
                st.Add(ClientModel.clients[j].GetInfoAsArray()[i]);
            }
            return st;
        }
        public static int remove(int index)
        {
            List<string> st = new List<string>();
            ClientModel.clients.Remove(ClientModel.clients[index]);

            return index;
        }
        public static void editClient(List<string> st, int index)
        {

            ClientModel.clients[index].Name = st[0];
            ClientModel.clients[index].Phone = Convert.ToInt32(st[1]);
            ClientModel.clients[index].Last_name = st[2];
            ClientModel.clients[index].Bank_account = st[3];
            ClientModel.clients[index].Status = st[4];
            ClientModel.clients[index].Price = Convert.ToInt32(st[5]);



        }

        public static bool searchClient(int index, decimal maxPrice, string name, string lastName)
        {
            List<ClientModel> st = new List<ClientModel>();

            if (!ClientModel.clients[index].getName().Contains(name))
            {
                return false;
            }

            if (ClientModel.clients[index].getPrice() > maxPrice)
            {
                return false;
            }


            if (!ClientModel.clients[index].getLastName().Contains(lastName))
            {

                return false;
            }
            return true;
        }

        public static void sortName()
        {
            ClientModel.clients.Sort((a, b) => a.getName().CompareTo(b.getName()));
        }
        public static void sortLastName()
        {
            ClientModel.clients.Sort((a, b) => a.getLastName().CompareTo(b.getLastName()));
        }
        public static void sortBackAcc()
        {
            ClientModel.clients.Sort((a, b) => a.getBankAcc().CompareTo(b.getBankAcc()));
        }

        public static void serialClients()
        {
            SerialClients.serial();
        }
        public static void deserialClients()
        {
            SerialClients.deserial();
        }

    }
}
