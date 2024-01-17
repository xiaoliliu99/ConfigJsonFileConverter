using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConfigJson
    {
        public  string MongoURL = Config.MongoURL;
        public  string DataBaseName = Config.DataBaseName;
        public  string PortName=Config.PortName;
        public  string senderID=Config.senderID;
        public  Int32 BaudRate=Config.BaudRate;


    }
}
