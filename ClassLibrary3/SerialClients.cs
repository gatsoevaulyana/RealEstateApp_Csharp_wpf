using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class SerialClients
    {
        public static void serial()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ClientModel.clients);
            }
        }

        public static void deserial()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            ClientModel[] gr = ClientModel.clients.ToArray();
            using (FileStream fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
            {
                List<ClientModel> deserilizePeople = (List<ClientModel>)formatter.Deserialize(fs);
                for (int i = 0; i < deserilizePeople.Count; i++)
                {
                    ClientModel.clients.Add(deserilizePeople[i]);
                }
            }
        }
    }
}

