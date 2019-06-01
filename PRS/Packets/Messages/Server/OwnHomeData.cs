using System;
using System.Collections.Generic;
using Royale2Sharp.Core.Settings;
using Royale2Sharp.Utilities;

namespace Royale2Sharp.Packets.Messages.Server
{
    internal class OwnHomeData
    {
        public static byte[] OwnHomeDataArray()
        {
            int[] arr1 = new int[] { 1,2,3,4,5,6,7,8, 9,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,29,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46, 49,50,53,54,56,58,59};
            var packet = new List<byte>();
            packet.AddInt(0); //id
            packet.AddInt(1); //id low
            packet.AddVInt(0);//ETC SEED
            packet.AddVInt(0);
            packet.AddVInt(0);// TICK 1
            packet.AddVInt(0);// TICK 2
            packet.AddVInt((int)DateTime.UtcNow.Second);//unknown timestamp
            packet.AddVInt(0);
            packet.Add(1);//deck count
            packet.Add(8);
            packet.AddVInt(26000001);
            packet.AddVInt(26000002);
            packet.AddVInt(26000003);
            packet.AddVInt(26000004);
            packet.AddVInt(26000005);
            packet.AddVInt(26000006);
            packet.AddVInt(26000007);
            packet.AddVInt(26000008);

            packet.Add(255);
            int cardInstanceid = 0;
            for (byte index = 0; index < 8; index++)
            {
                Console.WriteLine(arr1[cardInstanceid]);
                packet.AddVInt(arr1[cardInstanceid]);
                packet.AddVInt(10);//minions
                packet.AddVInt(24227822);
                packet.AddVInt(1143);
                packet.AddVInt(241);
                packet.AddVInt(0);
                packet.AddVInt(1);
                cardInstanceid++;
            }

            packet.AddVInt(43); //remaining card count


            for (int index = 0; index < 43; index++)
            {
                Console.WriteLine(arr1[cardInstanceid]);
                packet.AddVInt(arr1[cardInstanceid]);
                packet.AddVInt(1);//minions
                packet.AddVInt(24227822);
                packet.AddVInt(1143);
                packet.AddVInt(241);
                packet.AddVInt(0);
                packet.AddVInt(1);
                cardInstanceid++;
            }

            packet.AddHexa("00 FF 38 00 7F 00 00 00 00 06 00 7F 00 00 00 00 03 00 7F 00 00 00 00 16 00 7F 00 00 00 00 2E 00 7F 00 00 00 00 0C 00 7F 00 00 00 00 96 01 00 7F 00 00 00 00 24 00 7F 00 00 00 00 9A 11 AA 12 7F 93 E5 DD 9D 0B 01 00 0A".Replace(" ",""));

            packet.AddVInt(579);
            packet.AddString("Demo Account 2v2 Friendly");
            packet.AddVInt(5);
            packet.AddVInt(1498050600);
            packet.AddVInt(1514725800);
            packet.AddVInt(1498050600);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("Demo Account 2v2 Friendly");
            packet.AddString("{\"Target_AccountType\":\"DemoAccount\",\"HideTimer\":true,\"GameMode\":\"TeamVsTeam\"}");

            packet.AddVInt(580);
            packet.AddString("Demo Account 2v2 Draft Friendly");
            packet.AddVInt(5);
            packet.AddVInt(1498050600);
            packet.AddVInt(1514725800);
            packet.AddVInt(1498050600);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("Demo Account 2v2 Draft Friendly");
            packet.AddString(
                "{\"GameMode\":\"TeamVsTeamDraftChallenge\",\"HideTimer\":true,\"Target_AccountType\":\"DemoAccount\"}");

            packet.AddVInt(581);
            packet.AddString("Demo Account 1v1 Draft Friendly");
            packet.AddVInt(5);
            packet.AddVInt(1498050600);
            packet.AddVInt(1514725800);
            packet.AddVInt(1498050600);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("Demo Account 1v1 Draft Friendly");
            packet.AddString("{\"HideTimer\":true,\"Target_AccountType\":\"DemoAccount\",\"GameMode\":\"DraftMode\"}");

            packet.AddVInt(1109);
            packet.AddString("2v2 Button");
            packet.AddVInt(8);
            packet.AddVInt(1503298800);
            packet.AddVInt(1534834800);
            packet.AddVInt(1502694000);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("2v2 Button");
            packet.AddString(
                "{\"HideTimer\":true,\"HidePopupTimer\":true,\"ExtraGameModeChance\":0,\"GameMode\":\"TeamVsTeamLadder\",\"ExtraGameMode\":\"None\"}");

            packet.AddVInt(1199);
            packet.AddString("2v2 Double Elixir Draft Challenge Friendly");
            packet.AddVInt(5);
            packet.AddVInt(1507186800);
            packet.AddVInt(1507532400);
            packet.AddVInt(1507186800);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("2v2 Double Elixir Draft Challenge Friendly");
            packet.AddString("{\"GameMode\":\"TeamVsTeam_DraftModeInsane_Friendly\",\"DraftDeck\":\"Draft_v1\"}");

            packet.AddVInt(1200);
            packet.AddString("Event Page Header Image");
            packet.AddVInt(13);
            packet.AddVInt(1507532400);
            packet.AddVInt(1508137200);
            packet.AddVInt(1507532400);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("Event Page Header Image");
            packet.AddString(
                "{\"Title\":\"Touchdown Week\",\"Icon\":\"icon_tournament_touchdown\",\"TitleGlow\":true,\"Image\":{\"Path\":\"/o6HtD-PHSm_XjrXGFNxK-g.png\",\"Checksum\":\"0622e2aab8e14073aaa8d610ddab4772\",\"File\":\"touchdown_header_01.png\"}}");

            packet.AddVInt(1201);
            packet.AddString("2v2 Touch Down Practice");
            packet.AddVInt(2);
            packet.AddVInt(1507532400);
            packet.AddVInt(1508137200);
            packet.AddVInt(1507532400);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("2v2 Touch Down Practice");
            packet.AddString(
                "{\"Casual\":true,\"GameMode\":\"TeamVsTeam_Touchdown_Draft\",\"Title\":\"2v2 Touchdown Daily Practice\",\"FreePass\":1,\"IsChainedEvent\":false,\"IsDailyRefresh\":true,\"Casual_CrownsInsteadOfWins\":true,\"Rewards\":[{},{},{},{\"Milestone\":{\"Type\":\"Gold\",\"Amount\":300}},{},{},{\"Milestone\":{\"Chest\":\"Gold_<current_arena>\",\"Type\":\"Chest\"}},{},{},{},{\"Milestone\":{\"IsHighlighted\":true,\"Type\":\"Gems\",\"Amount\":5}}],\"IconExportName\":\"icon_tournament_touchdown\",\"WinIconExportName\":\"tournament_open_wins_badge_bronze\",\"Arena\":\"Arena_TouchdownTest\",\"Subtitle\":\"Casual Play with Rewards!\",\"Description\":\"Get a troop into your opponentâ€™s end zone to score a Crown. Win by getting three Crowns! Rewards refresh daily.\",\"Background\":{\"Path\":\"/ba6b0852871c2af2783e9d173a5da626_touchdown_challenge_01_6666_alpha_premul.png\",\"Checksum\":\"ba6b0852871c2af2783e9d173a5da626\",\"File\":\"touchdown_challenge_01_6666_alpha_premul.png\"},\"Background_Complete\":{\"Path\":\"/ba6b0852871c2af2783e9d173a5da626_touchdown_challenge_01_6666_alpha_premul.png\",\"Checksum\":\"ba6b0852871c2af2783e9d173a5da626\",\"File\":\"touchdown_challenge_01_6666_alpha_premul.png\"},\"DraftDeck\":\"Draft_Touchdown_v1\",\"UnlockedForXP\":\"Everyone\",\"EndNotification\":\"2v2 Touchdown Challenges end in two hours!\"}");

            packet.AddVInt(1202);
            packet.AddString("Friendly 2v2 Touchdown");
            packet.AddVInt(5);
            packet.AddVInt(1507532400);
            packet.AddVInt(1509519600);
            packet.AddVInt(1507532400);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("Friendly 2v2 Touchdown");
            packet.AddString(
                "{\"GameMode\":\"TeamVsTeam_Touchdown_Draft\",\"FixedArena\":\"Arena_TouchdownTest\",\"Title\":\"2v2 Touchdown Friendly\",\"Subtitle\":\"Play with your Clanmates!\",\"DraftDeck\":\"Draft_Touchdown_v1\",\"Background\":{\"Path\":\"/78cdfb212237aceaf34c9b3efa79f3f6_friend_touchdown_01_6666_alpha_premul.png\",\"Checksum\":\"78cdfb212237aceaf34c9b3efa79f3f6\",\"File\":\"friend_touchdown_01_6666_alpha_premul.png\"}}");

            packet.AddVInt(1203);
            packet.AddString("2v2 Touch Down Challenge");
            packet.AddVInt(2);
            packet.AddVInt(1507618800);
            packet.AddVInt(1507878000);
            packet.AddVInt(1507532400);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("2v2 Touch Down Challenge");
            packet.AddString(
                "{\"GameMode\":\"TeamVsTeam_Touchdown_Draft\",\"FreePass\":0,\"JoinCost\":10,\"JoinCostResource\":\"Gems\",\"MaxLosses\":3,\"Rewards\":[{\"Gold\":130,\"Cards\":2},{\"Gold\":180,\"Cards\":3},{\"Gold\":240,\"Milestone\":{\"Chest\":\"Gold_<current_arena>\",\"Type\":\"Chest\"},\"Cards\":5},{\"Gold\":310,\"Cards\":8},{\"Gold\":390,\"Milestone\":{\"Type\":\"Gold\",\"Amount\":1000},\"Cards\":12},{\"Gold\":480,\"Cards\":17},{\"Gold\":600,\"Milestone\":{\"IsHighlighted\":true,\"Chest\":\"Giant_<current_arena>\",\"Type\":\"Chest\"},\"Cards\":25}],\"Arena\":\"Arena_TouchdownTest\",\"WinIconExportName\":\"tournament_open_wins_badge_bronze\",\"IconExportName\":\"icon_tournament_touchdown\",\"Subtitle\":\"Get 6 Wins to Unlock All the Rewards!\",\"Description\":\"Get a troop into your opponentâ€™s end zone to score a Crown. Win by getting three Crowns! Collect all rewards at 6 wins.\",\"Background\":{\"Path\":\"/5b5f649ebff7f0dedce9c52c87c77049_touchdown_challenge_02_6666_alpha_premul.png\",\"Checksum\":\"5b5f649ebff7f0dedce9c52c87c77049\",\"File\":\"touchdown_challenge_02_6666_alpha_premul.png\"},\"Background_Complete\":{\"Path\":\"/5b5f649ebff7f0dedce9c52c87c77049_touchdown_challenge_02_6666_alpha_premul.png\",\"Checksum\":\"5b5f649ebff7f0dedce9c52c87c77049\",\"File\":\"touchdown_challenge_02_6666_alpha_premul.png\"},\"UnlockedForXP\":\"Experienced\",\"DraftDeck\":\"Draft_Touchdown_v1\",\"Title\":\"2v2 Touchdown Challenge\",\"StartNotification\":\"2v2 Touchdown Challenge has started! Play with your Friend or a random person!\"}");

            packet.AddVInt(1204);
            packet.AddString("2v2 Touchdown Quest");
            packet.AddVInt(7);
            packet.AddVInt(1507532400);
            packet.AddVInt(1508137200);
            packet.AddVInt(1507532400);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("2v2 Touchdown Quest");
            packet.AddString(
                "{\"QuestType\":\"Win\",\"Win\":{\"Type\":\"Crowns\",\"Events\":[1201,1203]},\"Title\":\"2v2 Touchdown Quest\",\"Info\":\"Collect  40 crowns from 2v2 Touchdown Event\",\"Count\":40,\"MinLevel\":5,\"Points\":20,\"ChronosQuestRewards\":[{\"Type\":\"Epic\",\"Count\":4}]}");

            packet.Add(1);
            packet.AddVInt(1201);
            packet.AddString("2v2 Touch Down Practice");
            packet.AddVInt(2);
            packet.AddVInt(1507532400);
            packet.AddVInt(1508137200);
            packet.AddVInt(1507532400);
            packet.AddRange(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 });
            packet.AddString("2v2 Touch Down Practice");
            packet.AddString(
                "{\"Casual\":true,\"GameMode\":\"TeamVsTeam_Touchdown_Draft\",\"Title\":\"2v2 Touchdown Daily Practice\",\"FreePass\":1,\"IsChainedEvent\":false,\"IsDailyRefresh\":true,\"Casual_CrownsInsteadOfWins\":true,\"Rewards\":[{},{},{},{\"Milestone\":{\"Type\":\"Gold\",\"Amount\":300}},{},{},{\"Milestone\":{\"Chest\":\"Gold_<current_arena>\",\"Type\":\"Chest\"}},{},{},{},{\"Milestone\":{\"IsHighlighted\":true,\"Type\":\"Gems\",\"Amount\":5}}],\"IconExportName\":\"icon_tournament_touchdown\",\"WinIconExportName\":\"tournament_open_wins_badge_bronze\",\"Arena\":\"Arena_TouchdownTest\",\"Subtitle\":\"Casual Play with Rewards!\",\"Description\":\"Get a troop into your opponentâ€™s end zone to score a Crown. Win by getting three Crowns! Rewards refresh daily.\",\"Background\":{\"Path\":\"/ba6b0852871c2af2783e9d173a5da626_touchdown_challenge_01_6666_alpha_premul.png\",\"Checksum\":\"ba6b0852871c2af2783e9d173a5da626\",\"File\":\"touchdown_challenge_01_6666_alpha_premul.png\"},\"Background_Complete\":{\"Path\":\"/ba6b0852871c2af2783e9d173a5da626_touchdown_challenge_01_6666_alpha_premul.png\",\"Checksum\":\"ba6b0852871c2af2783e9d173a5da626\",\"File\":\"touchdown_challenge_01_6666_alpha_premul.png\"},\"DraftDeck\":\"Draft_Touchdown_v1\",\"UnlockedForXP\":\"Everyone\",\"EndNotification\":\"2v2 Touchdown Challenges end in two hours!\"}");

           //Events epilog
            packet.AddVInt(0);
            packet.AddVInt(1);
            packet.AddVInt(1201);
            packet.AddVInt(1);
            packet.AddVInt(0);
            packet.AddVInt(1507618800);
            packet.AddVInt(0);
            packet.AddVInt(1);
            packet.AddVInt(73001201);
            packet.AddVInt(3);
            packet.AddVInt(1);
            packet.AddVInt(31);
            packet.AddVInt(0);
            packet.AddVInt(1507532400);
            packet.AddVInt(0);
            packet.AddVInt(1);
            packet.AddVInt(1110);
            packet.AddVInt(0);
            packet.AddVInt(10);
            packet.AddVInt(579);
            packet.AddVInt(0);
            packet.AddVInt(580);
            packet.AddVInt(0);
            packet.AddVInt(581);
            packet.AddVInt(0);
            packet.AddVInt(1109);
            packet.AddVInt(1);
            packet.AddVInt(1199);
            packet.AddVInt(1);
            packet.AddVInt(1200);
            packet.AddVInt(1);
            packet.AddVInt(1201);
            packet.AddVInt(1);
            packet.AddVInt(1202);
            packet.AddVInt(1);
            packet.AddVInt(1203);
            packet.AddVInt(1);
            packet.AddVInt(1204);
            packet.AddVInt(1);
            packet.AddVInt(7);
            packet.AddVInt(1109);
            packet.AddVInt(2);
            packet.AddVInt(0);
            packet.AddVInt(1199);
            packet.AddVInt(3);
            packet.AddVInt(0);
            packet.AddVInt(1200);
            packet.AddVInt(2);
            packet.AddVInt(0);
            packet.AddVInt(1201);
            packet.AddVInt(2);
            packet.AddVInt(0);
            packet.AddVInt(1202);
            packet.AddVInt(2);
            packet.AddVInt(0);
            packet.AddVInt(1203);
            packet.AddVInt(1);
            packet.AddVInt(0);
            packet.AddVInt(1204);
            packet.AddVInt(2);
            packet.AddVInt(0);
            packet.AddVInt(16);
            packet.AddString(
                "{\"ID\":\"CLAN_CHEST\",\"Params\":{\"StartTime\":\"20170317T070000.000Z\",\"ActiveDuration\":\"P3dT0h\",\"InactiveDuration\":\"P4dT0h\",\"ChestType\":[\"ClanCrowns\"]}}");

            packet.AddHexa(
                "00 04 00 00 00 7F 00 00 7F 01 13 2A 01 A6 56 00 7F 00 00 00 00 00 00 00 00 00 00 00 00 03 00 00 00 7F A4 C7 41 B4 D3 CB 01 B5 98 E2 9D 0B 00 00 00 7F 03 00 00 00 00 00 00 00 02 0B 36 07 02 9A 04 02 AC C4 0C AC C4 0C 9F C5 DF 9D 0B 00 00 00 7F 00 00 7F 00 00 7F 0C 07 A3 48 92 08 AC 09 03 B9 05 07 00 01 1A 10 01 0A 00 8F 03 00 00 FA 07 2F 00 7F 01 00 00 00 06 09 AE BF 8D 17 B7 11 B1 03 00 01 03 09 97 F6 8C 17 89 14 0B 00 00 16 07 B9 CC 97 17 B2 03 07 00 00 02 0A 00 9C 05 B6 01 00 00 0C 07 B9 F9 8C 17 29 16 00 00 96 01 09 98 93 9E 17 81 10 00 00 00 8E 01 06 00 04 07 00 00 01 1A 39 07 1A 2E 1C 10 1A 30 1A 31 1A 36 1A 37 1A 39 04 1A 31 1A 36 1A 37 1A 39 01 04 59 E8 F1 03 00 0A 00 03 8E D2 F8 3E 8D D2 F8 3E 8C D2 F8 3E 06 8E D2 F8 3E 8D D2 F8 3E 8C D2 F8 3E 8F D2 F8 3E 8B D2 F8 3E 89 D2 F8 3E 07 02 91 D2 F8 3E A0 D2 F8 3E 01 90 81 A1 FE 0B 00 99 01 01 01 8A E6 BF 33 02 00 BA CC 26 80 19 59 D7 2C 39 59 DB 20 B9 BE 9E D2 08 00 00 00 00 00 00 00 00 00 01 03 04"
                    .Replace(" ", ""));

            packet.AddString("Cast_Quest_HighCost");
            packet.AddString("TID_CAST_QUEST_MIN_ELIXIR");
            packet.AddString("TID_CAST_QUEST_MIN_ELIXIR_INFO");
            packet.AddString("sc/ui.sc");
            packet.AddString("quest_item_pvp");
            packet.AddHexa("14 1E 00 00 00 00 00 00 00 00 01 0E 00 2E 00 00 00 06 00 01 01 00 01".Replace(" ", ""));
            packet.AddString("Quest_Daily_5");
            packet.AddString("TID_DAILY_QUEST");
            packet.AddString("TID_DAILY_QUEST_INFO");
            packet.AddString("sc/ui.sc");
            packet.AddString("quest_item_gift_daily");
            packet.AddHexa(
                "05 05 01 00 00 00 00 00 00 00 05 05 01 AE 01 05 00 05 0E 01 05 0E 00 0B 0E 01 05 05 01 00 00 00 00 00 00 9A 04 02"
                    .Replace(" ", ""));
            packet.AddString("Play_Quest_Win_2v2Ladder_PvP");
            packet.AddString("TID_LADDER_QUEST_2V2_WIN");
            packet.AddString("TID_LADDER_QUEST_WIN_2V2_INFO");
            packet.AddString("sc/ui.sc");
            packet.AddString("quest_item_pvp");
            packet.AddHexa(
                "14 05 02 00 00 00 00 00 00 00 01 05 00 0A 01 00 01 02 00 01 02 00 00 00 00".Replace(" ", ""));

            packet.AddString("2v2 Touchdown Quest");
            packet.AddString("Collect  40 crowns from 2v2 Touchdown Event");
            packet.AddString("sc/ui.sc");
            packet.AddString("quest_item_special_pvp");
            packet.AddHexa("14 28 B4 12 03 00 01".Replace(" ", ""));
            packet.AddString("icon_quest_type_specialevent");
            packet.AddHexa(
                "01 0E 02 04 02 00 00 00 02 B1 12 B3 12 05 32 01 00 9A 04 00 03 01 00 08 06 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 0D 02 04 04 00 05 03 02 01 04 00 02 02 04 02 04 04 06 00 05 00 04 00 04 03 04 03 00 00 9F 03 06 06 00"

                    .Replace(" ", ""));
            packet.Add(0);//index
            packet.AddVInt(-102);
            packet.AddVInt(4);//4 for not retrieved yet
            packet.AddVInt(0);
            packet.AddScid(5, 1);
            packet.AddScid(26, 55);
            packet.AddVInt(99999);
            packet.AddHexa("03 00 01 00".Replace(" ", ""));

            packet.Add(1);//index
            packet.AddVInt(-102);
            packet.AddVInt(4);//4 for not retrieved yet
            packet.AddVInt(0);
            packet.AddScid(5, 1);
            packet.AddScid(26, 55);
            packet.AddVInt(99999);
            packet.AddHexa("00 00 01 00".Replace(" ",""));

            packet.Add(2);//index
            packet.AddVInt(-102);
            packet.AddVInt(4);//4 for not retrieved yet
            packet.AddVInt(0);
            packet.AddScid(5, 1);
            packet.AddScid(26, 46);
            packet.AddVInt(99999);
            packet.AddHexa("00 00 01 00".Replace(" ", ""));

            packet.Add(3);//index
            packet.AddVInt(-102);
            packet.AddVInt(4);//4 for not retrieved yet
            packet.AddVInt(0);
            packet.AddScid(5, 1);
            packet.AddScid(26, 48);
            packet.AddVInt(99999);
            packet.AddHexa("00 00 01 00".Replace(" ", ""));

            packet.Add(4);//index
            packet.AddVInt(-102);
            packet.AddVInt(4);//4 for not retrieved yet
            packet.AddVInt(0);
            packet.AddScid(5, 1);
            packet.AddScid(26, 42);
            packet.AddVInt(99999);
            packet.AddHexa("00 00 01 00".Replace(" ", ""));

            packet.Add(5);//index
            packet.AddVInt(-102);
            packet.AddVInt(4);//4 for not retrieved yet
            packet.AddVInt(0);
            packet.AddScid(5, 1);
            packet.AddScid(26, 29);
            packet.AddVInt(99999);
            //packet.AddHexa("00 00 01 00".Replace(" ", ""));
            packet.AddHexa(
                "01 00 00 00 00 00 00 7F 95 11 00"
                    .Replace(" ", ""));
            packet.AddVInt(0);
            packet.AddVInt(1);
            packet.AddVInt(0);
            packet.AddVInt(1);
            packet.AddVInt(0);
            packet.AddVInt(1);//3 times h & low id
            packet.AddString(Constants.OwnHomeData.StartingPlayerName);
            packet.AddHexa("0008");
            packet.AddVInt(Constants.OwnHomeData.StartingTrophies);
            packet.AddHexa("86 06 B0 2B 00 00 00 00 00 00 24 00 00 00 00 00 08 13 05 00 98 31".Replace(" ", ""));
            packet.AddScid(5, 1);
            packet.AddVInt(Constants.OwnHomeData.StartingGold);
            packet.AddHexa(
                "05 02 9C 0E 05 03 00 05 04 00 05 05 B7 9D 01 05 0C 8C 14 05 0D 00 05 0E 00 05 0F 98 11 05 10 92 05 05 11 9E 05 05 12 94 05 05 13 98 05 05 16 B2 11 05 19 B4 D3 9F CA 0A 05 1A 0D 05 1C 00 05 1D B3 88 D5 44 00 1B 3C 00 2C 3C 01 83 EA 03 3C 02 83 EA 03 3C 03 83 EA 03 3C 04 0A 3C 05 0A 3C 06 0A 3C 07 8A 01 3C 08 8A 01 3C 09 8A 01 3C 0A 01 3C 0B 8F 03 3C 0C 8F 03 3C 0D 8F 03 3C 11 3E 3C 12 0B 3C 13 0B 3C 14 0B 3C 15 99 01 3C 16 99 01 3C 17 99 01 3C 18 1F 3C 19 1F 3C 1A 1F 3C 1B 83 EA 03 3C 1C 83 EA 03 3C 1D 83 EA 03 17 3C 00 01 3C 01 01 3C 02 01 3C 03 01 3C 04 01 3C 05 01 3C 06 01 3C 07 01 3C 08 01 3C 09 01 3C 0A 01 3C 11 01 3C 12 01 3C 13 01 3C 15 01 3C 16 01 3C 17 01 3C 18 01 3C 19 01 3C 1A 01 3C 1B 01 3C 1C 01 3C 1D 01 09 05 06 95 35 05 07 BE 0D 05 08 8A 01 05 09 8B EA E5 18 05 0A 83 EA 03 05 0B 24 05 14 0B 05 15 B6 49 05 1B 0A 8C 01 1A 00 00 1A 01 00 1A 02 00 1A 03 00 1A 04 00 1A 05 00 1A 06 00 1A 07 00 1A 08 00 1A 09 00 1A 0A 00 1A 0B 00 1A 0C 00 1A 0D 00 1A 0E 00 1A 0F 00 1A 10 00 1A 11 00 1A 12 00 1A 13 00 1A 14 00 1A 15 00 1A 16 00 1A 17 00 1A 18 00 1A 19 00 1A 1A 00 1A 1B 00 1A 1C 00 1A 1D 00 1A 1E 00 1A 1F 00 1A 20 00 1A 21 00 1A 22 00 1A 23 00 1A 24 00 1A 25 37 1A 26 00 1A 27 00 1A 28 00 1A 29 00 1A 2A 00 1A 2B 00 1A 2D 00 1A 2E 00 1A 30 15 1A 31 00 1A 36 00 1A 37 10 1B 00 00 1B 01 00 1B 02 00 1B 03 00 1B 04 00 1B 05 00 1B 06 00 1B 07 00 1B 08 00 1B 09 00 1B 0A 00 1C 00 00 1C 01 00 1C 02 00 1C 03 00 1C 04 00 1C 05 00 1C 06 00 1C 07 00 1C 08 00 1C 09 00 1C 0A 00 1C 0B 00 1C 0C 00 1C 0D 00 1C 10 00 00 00"
                    .Replace(" ", ""));
            packet.AddVInt(Constants.OwnHomeData.StartingGems);
            packet.AddVInt(Constants.OwnHomeData.StartingGems);
            packet.AddVInt(Constants.OwnHomeData.StartingExperience);
            packet.AddVInt(Constants.OwnHomeData.StartingLevel);
            packet.AddHexa("B8A10109");
            packet.AddVInt(0); //A1B72E
            packet.AddVInt(1);
            packet.AddString(Constants.OwnHomeData.StartingClanName);
            packet.AddHexa(
                "18 01 A3 48 92 08 AC 09 AB 20 AD 1F 7E 9F 03 17 00 01 04 59 E8 F1"
                    .Replace(" ", ""));
            packet.AddVInt(100);//wins in  challenge
            packet.AddHexa(
                "00 00 00 00 00 81 88 C4 2D 90 F5 DE 9D 0B AF E4 A1 03"
                    .Replace(" ", ""));
            return packet.ToArray();
        }
    }
}