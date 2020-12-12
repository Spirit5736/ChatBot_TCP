using System;
using System.Threading;

namespace ChatServer
{
    class Program
    {
        // сервер
        static ServerObject server;
        // потока для прослушивания
        static Thread listenThread; 
        static void Main(string[] args)
        {
            try
            {
                server = new ServerObject();
                listenThread = new Thread(new ThreadStart(server.Listen));
                //старт потока
                listenThread.Start(); 
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
