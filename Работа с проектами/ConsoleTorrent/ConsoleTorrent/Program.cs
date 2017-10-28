using System;
using MonoTorrent.Client;
using MonoTorrent.Common;

namespace ConsoleTorrent
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Incorrect arguments given to input!");
            }

            var torrentFilePath = args[0];
            var downloadFolderPath = args[1];

            Download(torrentFilePath, downloadFolderPath);
            Console.ReadKey();
        }

        private static void Download(string torrentFilePath, string downloadFolderPath)
        {
            Torrent torrent = Torrent.Load(torrentFilePath);

            ClientEngine engine = new ClientEngine(new EngineSettings());
            TorrentManager manager = new TorrentManager(torrent, downloadFolderPath, new TorrentSettings());
            
            engine.Register(manager);
            manager.Start();      
        }
    }
}
