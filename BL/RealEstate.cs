using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace BL
{
   public class RealEstate
    {
        public static int GetCountEstate()
        {
            return RealEstateModel.estates.Count;
        }

        public static List<string> refreshEstates(int j)
        {
            List<string> st = new List<string>();
            for (int i = 0; i < RealEstateModel.estates[j].GetInfoAsArray().Length; i++)
            {
                st.Add(RealEstateModel.estates[j].GetInfoAsArray()[i]);
            }
            return st;
        }

        public static void AddEstate(List<string> st)
        {
            RealEstateModel.estates.Add(new RealEstateModel(st));
        }

        public static void AddEstate(string _region, string _address, double _area, string _constructionDate, string _type, decimal _price)
        {
            RealEstateModel.estates.Add(new RealEstateModel(_region, _address, _area, _constructionDate, _type, _price));
        }

        public static List<string> GetEstate()
        {
            List<string> st = new List<string>();
            int k = RealEstateModel.estates.Count;
            for (int i = 0; i < RealEstateModel.estates[0].GetInfoAsArray().Length; i++)
            {
                st.Add(RealEstateModel.estates[k - 1].GetInfoAsArray()[i]);
            }
            return st;
        }

        public static void editEstate(List<string> st, int index)
        {
            RealEstateModel.estates[index].Region = st[0];
            RealEstateModel.estates[index].Address = st[1];
            RealEstateModel.estates[index].Area = Convert.ToInt32(st[2]);
            RealEstateModel.estates[index].ConstructionDate = st[3];
            RealEstateModel.estates[index].Type = st[4];
            RealEstateModel.estates[index].Price = Convert.ToInt32(st[5]);



        }

        public static bool searchEstate(int index, decimal maxPrice, double area, string region)
        {


            if (RealEstateModel.estates[index].getArea() > area)
            {
                return false;
            }

            if (RealEstateModel.estates[index].getPrice() > maxPrice)
            {
                return false;
            }


            if (!RealEstateModel.estates[index].getRegion().Contains(region))
            {

                return false;
            }
            return true;
        }

     
        public static void sortPrice()
        {
            RealEstateModel.estates.Sort((a, b) => a.getPrice().CompareTo(b.getPrice()));
        }


        public static void serialEstates()
        {
            SerialEstates.serial();
        }
        public static void deserialEstates()
        {
            SerialEstates.deserial();
        }

        public static List<RealEstateModel> SearchClforRegion(string st)
        {
            List<RealEstateModel> clms = new List<RealEstateModel>();
            foreach (RealEstateModel cm in RealEstateModel.estates)
            {
                if (cm.Region == st)
                    clms.Add(cm);
            }
            return clms;
        }
        public static List<RealEstateModel> SearchClforLastAddress(string st)
        {
            List<RealEstateModel> clms = new List<RealEstateModel>();
            foreach (RealEstateModel cm in RealEstateModel.estates)
            { 
                if (cm.Address == st)
                    clms.Add(cm);
            }
            return clms;
        }
        public static List<RealEstateModel> SearchClforArea(string st)
        {
            List<RealEstateModel> clms = new List<RealEstateModel>();
            foreach (RealEstateModel cm in RealEstateModel.estates)
            {
                if (Convert.ToString(cm.Area) == st)
                    clms.Add(cm);
            }
            return clms;
        }

        public static List<RealEstateModel> SearchClforConDate(string st)
        {
            List<RealEstateModel> clms = new List<RealEstateModel>();
            foreach (RealEstateModel cm in RealEstateModel.estates)
            {
                if (cm.ConstructionDate == st)
                    clms.Add(cm);
            }
            return clms;
        }

        public static List<RealEstateModel> SearchClforPrice(string st)
        {
            List<RealEstateModel> clms = new List<RealEstateModel>();
            foreach (RealEstateModel cm in RealEstateModel.estates)
            {
                if (Convert.ToString(cm.Price) == st)
                    clms.Add(cm);
            }
            return clms;
        }

        public static List<RealEstateModel> SearchClforType(string st)
        {
            List<RealEstateModel> clms = new List<RealEstateModel>();
            foreach (RealEstateModel cm in RealEstateModel.estates)
            {
                if (cm.Type == st)
                    clms.Add(cm);
            }
            return clms;
        }

        public static int remove(int index)
        {
            List<string> st = new List<string>();
            RealEstateModel.estates.Remove(RealEstateModel.estates[index]);

            return index;
        }
        public static List<List<string>> ReternListSearchEstate(List<string> sts)
        {
            List<List<string>> stss = new List<List<string>>();
            List<RealEstateModel> cm = new List<RealEstateModel>();
            for (int j = 0; j < RealEstateModel.estates.Count; j++)
            {
                int count = 0;
                for (int i = 0; i < sts.Count; i++)
                {
                    if (RealEstateModel.estates[j].getInfoAsString().Contains(sts[i]))
                    {
                        count++;
                    }
                }
                if (count == sts.Count)
                {
                    cm.Add(RealEstateModel.estates[j]);
                }
            }
            foreach (RealEstateModel cm1 in cm)
            {
                List<string> strings = new List<string>();
                strings.Add(cm1.Region);
                strings.Add(cm1.Address);
                strings.Add(Convert.ToString(cm1.Area));
                strings.Add(cm1.ConstructionDate);
                strings.Add(cm1.Type);
                strings.Add(Convert.ToString(cm1.Price));
                stss.Add(strings);
            }
            return stss;
        }
    }
}
