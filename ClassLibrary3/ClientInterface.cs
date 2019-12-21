using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public interface ClientInterface
    {
        string[] GetInfoAsArray();
        string getInfoAsString();
        string getName();
        string getLastName();
        string getBankAcc();
        int getPhone();
        int getPrice();
        string getStatus();
    }
}
