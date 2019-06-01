using System.Drawing;
using Colorful;

namespace Royale2Sharp.Core
{
    internal class Logger
    {
        internal static void Log(string text, DefCon DefCon)
        {
            switch (DefCon)
            {
                case DefCon.DEFAULT:
                    Console.WriteLine($"[Default] " + text, Color.Cyan);
                    break;

                case DefCon.DEBUG:
                    Console.WriteLine($"[Debug] " + text, Color.Blue);
                    break;

                case DefCon.DEBUGCLIENT:
                    Console.WriteLine($"[Client] " + text, Color.DeepSkyBlue);
                    break;
                case DefCon.DEBUGSERVER:
                    Console.WriteLine($"[Server] " + text, Color.DodgerBlue);
                    break;
                case DefCon.INFO:
                    Console.WriteLine($"[Info] " + text, Color.Cyan);
                    break;

                case DefCon.WARN:
                    Console.WriteLine($"[Warning] " + text, Color.Red);
                    break;


                case DefCon.ERROR:
                    Console.WriteLine($"[Error] " + text, Color.DarkRed);
                    break;
            }
        }

        internal enum DefCon
        {
            DEFAULT = 0,
            DEBUG = 1,
            INFO = 2,
            WARN = 3,
            ERROR = 4,
            DEBUGCLIENT = 5,
            DEBUGSERVER = 6
        }
    }
}