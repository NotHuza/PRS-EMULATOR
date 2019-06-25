using System;
using System.Collections.Generic;
using HuzaRoyale.Core.Settings;
using HuzaRoyale.Utilities;

namespace HuzaRoyale.Packets.Messages.Server
{
    internal class AllianceData
    {
        internal static byte[] Payload()
        {
            var players = 1;
            var AllianceData = new List<byte>();
            AllianceData.AddInt(0);
            AllianceData.AddInt(1);
            AllianceData.AddString(Constants.OwnHomeData.StartingClanName);
            AllianceData.AddScid(16, 23); //Badge
            AllianceData.Add(3); //byte
            AllianceData.AddVInt(players); //Member Count
            AllianceData.AddVInt(1000); //Score
            AllianceData.AddVInt(666); //Required Score
            AllianceData.Add(1);
            AllianceData.Add(1);
            AllianceData.AddVInt(145);
            AllianceData.AddVInt(1);
            AllianceData.AddVInt(1000); //donation/week
            AllianceData.AddVInt(-1661);
            AllianceData.Add(1);
            AllianceData.Add(1);
            AllianceData.Add(0);
            AllianceData.AddScid(57, 120); //Italy
            AllianceData.Add(0);

            AllianceData.AddString(Constants.AllianceData.Description);
            AllianceData.AddVInt(players); //Amount of Players on clan

            var random = new Random();
            for (byte zero = 0; zero < players; zero++)
            {
                var _ID = random.Next(0, 999999);
                AllianceData.AddLong(_ID);
                AllianceData.AddString(Constants.OwnHomeData.StartingClanName + " - " + zero);
                AllianceData.AddScid(54, 11); //arena
                AllianceData.AddVInt(3); //role
                AllianceData.AddVInt(random.Next(1, 13)); //level
                AllianceData.AddVInt(random.Next(1000, 6600));
                AllianceData.AddVInt(random.Next(1, 1000));
                AllianceData.AddVInt(100);
                AllianceData.AddVInt(zero); //RANK CURRENT
                AllianceData.AddVInt(zero); //RANK PREVIOUS
                AllianceData.AddVInt(100); //CROWNS
                AllianceData.AddVInt(1);
                AllianceData.AddVInt(1);
                AllianceData.AddVInt(1);
                AllianceData.AddVInt(1);
                AllianceData.AddVInt(1); //00 7F 9C DA B0 08 24 04
                AllianceData.AddLong(_ID);
            }
            AllianceData.Add(1);
            AllianceData.Add(1);
            AllianceData.AddVInt(1);
            AllianceData.AddVInt(1);
            AllianceData.AddInt(1);
            AllianceData.AddInt(1);
            AllianceData.AddVInt(1);
            AllianceData.Add(1);
            AllianceData.Add(1);
            return AllianceData.ToArray();
        }
    }
}