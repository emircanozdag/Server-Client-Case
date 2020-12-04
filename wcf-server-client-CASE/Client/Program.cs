using System;

using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServerServiceClient("BasicHttpBinding_IServerService", "http://localhost:8000/ServerService");
            
            client.Test("test text");
            var sessionName = GetSessionName();

            client.StoreSession(sessionName);
            Console.WriteLine(client.GetSessionName());

            client.SendByteData(new byte[100000]);
            client.SendString(sessionName);

            Console.WriteLine("Uploaded");

            Console.ReadLine();
            client.Close();
        }

        private static string GetSessionName()
        {
            Console.WriteLine("Session Name:");
            var sessionName = Console.ReadLine();
            return sessionName;
        }
    }
}
