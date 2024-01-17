using System.IO.Ports;


namespace ConsoleApp1
{
    public class Config

    {
        //variables should read from another config file.
        public static string MongoURL = "mongodb://admin:pwd2023!@192.168.1.108:25535";
        public static string DataBaseName = "metabim";
        public static string PortName = "COM14";
        public static string senderID = "61415560815";
        public static Int32 BaudRate = 115200;



        //public static Parity Parity = Parity.None;
        public static int DataBits = 8;
        //public static StopBits StopBits = StopBits.One;
        public static string APISpaceToken = "7fe3f32bc5db43e78f54696a6b6f0005";
    }
}