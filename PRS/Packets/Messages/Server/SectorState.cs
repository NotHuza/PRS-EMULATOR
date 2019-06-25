using System.Collections.Generic;
using System.Linq;
using Ionic.Zlib;
using Royale2Sharp.Core.Settings;
using Royale2Sharp.Utilities;

namespace Royale2Sharp.Packets.Messages.Server
{
    internal class SectorState
    {
        internal static byte[] Array()
        {
            var part1 = Sodium.Utilities.HexToBinary("01 71 05 00 00".Replace(" ", ""));
            var decryptedpart2 = new List<byte>();
            decryptedpart2.AddHexa(
                "2A 02 7F 7F 7F 7F 00 00 00 00 00 00 01 80 32 00 00 00 00 00 00 00 00 00 00 00 00 00 08 00 00 00 00 00 00 00 00 0A 00 00 00 00 00 00 00 00 00 00 00 01 02 00 9F BD 19 00 9F BD 19 00 9F BD 19"
                    .Replace(" ", ""));
            decryptedpart2.AddString(Constants.OwnHomeData.StartingPlayerName);
            decryptedpart2.AddHexa(
                "08 B5 31 86 06 95 2A 00 00 00 00 00 24 00 00 00 00 00 08 0E 05 01 BF AC 01 05 02 9D 0E 05 03 01 05 04 00 05 0C 8C 14 05 0D 00 05 0E 01 05 0F 98 11 05 16 B2 11 05 19 B4 D3 9F CA 0A 05 1A 0D 05 1C 00 05 1D 86 88 D5 44 05 25 00 00 00 00 05 05 06 95 35 05 07 80 0E 05 0B 24 05 14 0B 05 1B 0A 8D 01 1A 00 00 1A 01 00 1A 02 01 1A 03 00 1A 04 00 1A 05 01 1A 06 00 1A 07 00 1A 08 00 1A 09 00 1A 0A 00 1A 0B 00 1A 0C 00 1A 0D 00 1A 0E 00 1A 0F 00 1A 10 00 1A 11 00 1A 12 00 1A 13 00 1A 14 00 1A 15 00 1A 16 00 1A 17 00 1A 18 00 1A 19 00 1A 1A 00 1A 1B 00 1A 1C 00 1A 1D 00 1A 1E 00 1A 1F 00 1A 20 00 1A 21 00 1A 22 00 1A 23 00 1A 24 00 1A 25 37 1A 26 00 1A 27 00 1A 28 00 1A 29 00 1A 2A 00 1A 2B 00 1A 2D 00 1A 2E 01 1A 30 15 1A 31 00 1A 36 00 1A 37 10 1B 00 00 1B 01 00 1B 02 00 1B 03 00 1B 04 00 1B 05 00 1B 06 00 1B 07 00 1B 08 00 1B 09 00 1B 0A 00 1C 00 01 1C 01 00 1C 02 00 1C 03 00 1C 04 00 1C 05 00 1C 06 00 1C 07 00 1C 08 01 1C 09 00 1C 0A 00 1C 0B 00 1C 0C 00 1C 0D 00 1C 10 00 1A 39 00 00 00 0B 02 11 A1 B7 2E"
                    .Replace(" ", ""));
            decryptedpart2.AddString(Constants.OwnHomeData.StartingClanName);
            decryptedpart2.AddHexa(
                "18 AD 48 92 08 00 B3 20 AD 1F 01 9F 03 17 00 00 00 00 2B 00 21 7F 0B 00 8D DE 59 6C 87 BB BE B7 03 02 02 26 01 7F 7F 00 00 9F BD 19 00 00 00 00 00 00 00 00 00 06"

                    .Replace(" ", ""));
            decryptedpart2.Add(true);
            decryptedpart2.AddHexa("00 00 09 00 00 00 01 00 00 00 8E 02 F2 7D 00 00 06 7A 06 23 01 23 01 23 01 23 01 23 00 23 00 01 00 01 00 00 01 05 00 05 01 05 02 05 03 05 04 05 05 0A 0D A4 E2 01 9C 8E 03 00 00 7F 00 C0 7C 00 00 02 00 00 00 00 00 09 0D AC 36 A4 65 00 00 7F 00 80 04 00 00 01 00 00 00 00 00 0A 0D AC 36 9C 8E 03 00 00 7F 00 C0 7C 00 00 01 00 00 00 00 00 09 0D A4 E2 01 A4 65 00 00 7F 00 80 04 00 00 02 00 00 00 00 00 09 0D A8 8C 01 B8 2E 00 00 7F 00 80 04 00 00 00 00 00 00 00 00 0D 04 04 02 01 79 04 05 01 03 02 00 7F 7F 00 00 00 00 05 00 00 00 00 00 7F 7F 7F 7F 7F 7F 7F 7F 00 00 00 00".Replace(" ", ""));
            decryptedpart2.Add(12); //Crown tower level
            decryptedpart2.AddHexa(
                "0D A8 8C 01 88 C5 03 00 00 7F 00 C0 7C 00 00 00 00 00 00 00 00 0D 04 04 7F 7D 07 04 05 01 06 02 00 7F 7F 00 03 04"
                    .Replace(" ", ""));
            decryptedpart2.AddString("Cast_Quest_HighCost");
            decryptedpart2.AddString("TID_CAST_QUEST_MIN_ELIXIR");
            decryptedpart2.AddString("TID_CAST_QUEST_MIN_ELIXIR_INFO");
            decryptedpart2.AddString("sc/ui.sc");
            decryptedpart2.AddString("quest_item_pvp");
            decryptedpart2.AddHexa(
                "14 1E 00 00 00 00 00 00 00 00 01 0E 00 2E 00 00 00 06 00 01 01 00 02".Replace(" ", ""));
            decryptedpart2.AddString("Play_Quest_Win_2v2Ladder_PvP");
            decryptedpart2.AddString("TID_LADDER_QUEST_2V2_WIN");
            decryptedpart2.AddString("TID_LADDER_QUEST_WIN_2V2_INFO");
            decryptedpart2.AddString("sc/ui.sc");
            decryptedpart2.AddString("quest_item_pvp");
            decryptedpart2.AddHexa(
                "14 05 02 00 00 00 00 00 00 00 01 05 00 0A 01 00 01 02 00 02 00 00 00 00".Replace(" ", ""));
            decryptedpart2.AddString("");
            decryptedpart2.AddString("");
            decryptedpart2.AddString("sc/ui.sc");
            decryptedpart2.AddString("quest_item_special_pvp");
            decryptedpart2.AddHexa("14 28 B4 12 0A 0A 01".Replace(" ", ""));
            decryptedpart2.AddString("icon_quest_type_specialevent"); //ELIXIR ..
            decryptedpart2.AddHexa("01 0E 02 04 02 00 00 00 02 B1 12 B3 12 00 00".Replace(" ", ""));
            decryptedpart2.Add(8); //elixir NOT MORE THAT 63
            decryptedpart2.AddHexa(
                "00 00 00 00 00 7F 7F 7F 7F 7F 7F 7F 7F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 AC 2F 00 A2 2B 00 AC 2F 00 A2 2B 00 A8 44 00 98 4B 00 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 00 A4 01 A4 01 00 FF 01 11 04 01 09 05 04 03 09 1B 01 13 07 8F 01 09 1C 04 00 FE 03"

                    .Replace(" ", ""));
           // decryptedpart2.AddHexa("2F 00 38 04 03 09 16 07 02 0A 0C 07 96 01 09 8E 01 06 00 00 05 06 02 02 04 02 01".Replace(" ",""));

            foreach (var cardid in Constants.OwnHomeData.Deck)
            {
                decryptedpart2.AddVInt(cardid);
                decryptedpart2.AddVInt(4);
            }
            decryptedpart2.AddHexa("00 00 05 06 02 02 04 02 01".Replace(" ", ""));

            decryptedpart2.Add(3); //2 for weird things (on troops), 3 for normal
            decryptedpart2.AddHexa("00 00 00 00 00 00 00 00 0C 00 00 00 90 EE FC F9 0F 00".Replace(" ", ""));
            return part1.Concat(ZlibStream.CompressBuffer(decryptedpart2.ToArray())).ToArray();
        }
    }
}