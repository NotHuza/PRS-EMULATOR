using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;

namespace Royale2Sharp.Core.Settings
{
    internal class Constants
    {
        internal static Random r = new Random();

        internal class ServerConfig
        {
            public const string Ip = "192.168.100.8";
            public const int Port = 9339;
            public const bool IsMaintenance = false;
            public static readonly string AppVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            public static readonly List<string> BlockedIps = new List<string>
            {
                ""
            };

            public static byte[] Decrypted = new byte[2048];
            public static byte[] Encrypted = new byte[2048];
            public static byte[] ReceivedPacket = new byte[2048];

            public static int ContentTimes = 0;

            public static int ConnectedUsers = 0;
        }

        internal class ProtocolConfig
        {
            public const bool patchClient = true;

            public const bool IsMaintenance = false;

            public static byte[] Decrypted = new byte[2048];

            public static byte[] Encrypted = new byte[2048];

            public static byte[] ReceivedPacket = new byte[2048];

            public static int ContentTimes = 0;
        }

        internal class ServerHello
        {
            public const string SessionKey = "PrOjEcTrOyAlEsErVeR-ClAsHrOyAlE12345";
        }

        internal class LoginFailed
        {
            public enum Error
            {
                Default = 0,
                OutDatedContent = 7,
                Update = 8,
                Redirect = 9,
                Maintenance = 10,
                Banned = 11,
                Locked = 13
            }

            public const string Redirect =
                "stage.scroll.supercelltest.com";

            public const string ContentUrl =
                    "http://192.168.1.2/ClashRoyale/Patchs"
                ; //https://99faf1e355c749a9a049-2a63f4436c967aa7d355061bd0d924a1.ssl.cf1.rackcdn.com 

            public const string AssetsUrl =
                "https://game-assets.clashroyaleapp.com";

            public const string UpdateUrl =
                "https://play.google.com/store/apps/details?id=com.supercell.clashroyale";

            public const int MaintenanceLeftSeconds = 0;

            public static string fingerprintVersion;

            public static string FingerPrint;
                


            public const string Message = "Welcome To Huza Modz Royale server";
        }

        internal class LoginOk
        {
            public const uint Id = 4033384339;

            public const string City = "ProjectLand | Italy";

            public const string Contenturl =
                "http://7166046b142482e67b30-2a63f4436c967aa7d355061bd0d924a1.r65.cf1.rackcdn.com";

            public const string Eventsurl = "https://image.prntscr.com/image";
        }

        internal static class OwnHomeData
        {
            public static int[] Deck = {1, 2, 3, 4, 5, 6, 64, 30};

            public const string StartingPlayerName = "Huza Modz";

            public const string StartingClanName = "Huza Modz";

            public const int StartingLevel = 13;

            public const int StartingExperience = 1000000;

            public const int StartingGems = 100000;

            public const int StartingGold = 100000;

            public static readonly int StartingTrophies = 6400; //r.Next(0, 6900);
        }

        internal class AllianceData
        {
            public const string Description = "Official royale server HuzaModz";
        }
        internal class AllianceMessage
        {
            public static long id = 0;
        }
    }
}