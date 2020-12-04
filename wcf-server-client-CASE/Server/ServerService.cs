using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    public class ServerService : IServerService
    {
        private string sessionName = string.Empty;

        public void StoreSession(string sessionName)
        {
            this.sessionName = sessionName;
        }

        public string GetSessionName()
        {
            return sessionName;
        }

        public void SendByteData(byte[] data)
        {
            Console.WriteLine($"Received: {data.Length}");
        }

        public bool Test(string input)
        {
            Console.WriteLine($"Test: {input}");
            return true;
        }

        public void SendString(string name)
        {
            Console.WriteLine($"My session name : {name}");
        }
    }
}
