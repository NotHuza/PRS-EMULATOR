using System.Diagnostics;
using System.Drawing;
using Colorful;
using Royale2Sharp.Core;
using Royale2Sharp.Core.Network;
using Royale2Sharp.Core.Settings;

namespace Royale2Sharp
{
    internal class Program
    {
        internal static Stopwatch elpst = new Stopwatch();

        private static void Main(string[] args)
        {
            Console.Write(@"
            
              █  █ █  █  ▀▀█  █▀█  █▀▄▀█ █▀▀█ █▀▀▄ ▀▀█   █▀▀█ █▀▀█ █  █ █▀▀█ █   █▀▀   █▀█   █▀▀█
              █▄▄█ █  █  ▄▀  █▀▀▀█ █ ▀ █ █  █ █  █ ▄▀    █▄▄▀ █  █ █▄▄█ █▄▄█ █   █▀▀    ▄▀ ▄ █▄▀█
              █  █  ▀▀▀  ▀▀  █   █ ▀   ▀ ▀▀▀▀ ▀▀▀  ▀▀▀   ▀ ▀▀ ▀▀▀▀ ▄▄▄█ ▀  ▀ ▀▀▀ ▀▀▀   █▄▄ █ █▄▄█ v." +
                                             Constants.ServerConfig.AppVersion, Color.Crimson);
            Console.WriteLine();

            elpst.Reset();

            elpst.Start();

            Logger.Log($"Starting...", Logger.DefCon.INFO);

            AsynchronousSocketListener.StartListening();

            Console.ReadKey(true);
        }
    }
}