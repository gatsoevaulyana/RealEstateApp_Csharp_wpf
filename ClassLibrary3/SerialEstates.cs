using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class SerialEstates
    {
        public static void serial()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("estates.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, RealEstateModel.estates);
            }
        }

        public static void deserial()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            RealEstateModel[] gr = RealEstateModel.estates.ToArray();
            using (FileStream fs = new FileStream("estates.dat", FileMode.OpenOrCreate))
            {
                List<RealEstateModel> deserilizePeople = (List<RealEstateModel>)formatter.Deserialize(fs);
                for (int i = 0; i < deserilizePeople.Count; i++)
                {
                    RealEstateModel.estates.Add(deserilizePeople[i]);
                }
            }
        }
    }
}

