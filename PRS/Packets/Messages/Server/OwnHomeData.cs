using System.Collections.Generic;
using HuzaRoyale.Core.Settings;
using HuzaRoyale.Utilities;

namespace HuzaRoyale.Packets.Messages.Server
{
    internal class OwnHomeData
    {
        public static byte[] OwnHomeDataArray()
        {
            var packet = new List<byte>();
            packet.AddInt(0); //id
            packet.AddInt(208735); //id
            /*
                            packet.AddVInt(20);
                            packet.AddVInt(0);

                            packet.AddVInt(572420);
                            packet.AddVInt(596220);

                            packet.AddVInt(1508079373);

                        packet.AddVInt(0);
                        packet.AddVInt(0);
                        packet.Add(255);

                        int cardid = 1;
                        for (int z = 0; z < 8; z++)
                        {
                            packet.AddVInt(cardid);
                            packet.AddVInt(4);
                            packet.AddVInt(0);
                            packet.AddVInt(800);
                            packet.AddVInt(0);
                            packet.AddVInt(15);
                            packet.AddVInt(0);
                            cardid++;
                        }
                        packet.AddVInt(70);//cards after deck count

                        for (int z = 0; z < 70; z++)
                        {
                            Lol:
                            if (cardid == 45 | cardid == 48 | cardid == 51 | cardid == 52 | cardid == 53 | cardid == 54 |
                                cardid == 70 | cardid == 71 | cardid == 72 | cardid == 87 | cardid == 88)
                            {
                                Console.WriteLine("Skipped " + cardid);
                                cardid++;
                                Console.WriteLine("Doing " + cardid);
                                goto Lol;
                            }
                            packet.AddVInt(cardid);
                            packet.AddVInt(4);
                            packet.AddVInt(0);
                            packet.AddVInt(800);
                            packet.AddVInt(0);
                            packet.AddVInt(15);
                            packet.AddVInt(0);
                            cardid++;
                        }
                        packet.AddVInt(0);
                        packet.AddVInt(0);
                        packet.AddVInt(127);
                        packet.AddVInt(-64);
                        packet.AddVInt(-64);


                        packet.AddVInt(1508049882);

                        packet.AddVInt(1);
                        packet.AddVInt(0);
                        */
            packet.AddHexa(
                "A8 56 94 1F A4 C7 41 B4 D3 CB 01 B5 98 E2 9D 0B 17 05 08 AE EA E5 18 85 EA E5 18 82 EA E5 18 95 EA E5 18 81 EA E5 18 8B EA E5 18 88 FC D9 1A 80 FC D9 1A 08 95 EA E5 18 80 EA E5 18 8C FC D9 1A 9E EA E5 18 80 FC D9 1A B1 EA E5 18 88 FC D9 1A 9F EA E5 18 08 81 EA E5 18 80 FC D9 1A 85 EA E5 18 A3 EA E5 18 AD EA E5 18 81 FC D9 1A 88 FC D9 1A AB EA E5 18 08 82 EA E5 18 9E EA E5 18 91 EA E5 18 9F EA E5 18 8B FC D9 1A 88 FC D9 1A 95 EA E5 18 A3 EA E5 18 08 8B FC D9 1A A3 EA E5 18 8A FC D9 1A 9A EA E5 18 9D EA E5 18 97 EA E5 18 AA EA E5 18 A0 EA E5 18 FF 2F 00 7F 01 00 00 00 06 09 AE BF 8D 17 B7 11 B1 03 00 01 03 09 97 F6 8C 17 89 14 0B 00 00 16 07 B9 CC 97 17 B2 03 07 00 00 02 0A 00 9C 05 B6 01 00 00 0C 07 B9 F9 8C 17 29 16 00 00 96 01 09 98 93 9E 17 81 10 00 00 00 8E 01 06 00 04 07 00 00 82 01 2A 08 BF A8 D4 17 9A 1C 97 1A 00 01 8A 01 06 B5 BE 9F 17 AC 01 A3 01 00 00 08 04 91 AA 97 17 0A 00 00 00 95 01 03 96 84 8D 17 15 08 00 01 27 06 AE 91 BC 17 8C 03 06 00 00 92 01 03 91 BE 8D 17 01 00 00 00 32 06 82 FB EA 17 AB 12 A6 10 00 01 23 03 7F 05 00 00 00 05 03 7F 15 03 00 00 82 01 08 A1 D3 A4 17 8E 1F 9D 09 00 00 07 04 7F 04 01 00 00 83 01 06 91 87 97 17 91 03 9E 01 00 01 28 06 9F D0 B7 17 AC 02 35 00 00 8F 01 09 00 81 14 98 01 00 00 94 01 02 7F 0A 02 00 01 12 06 87 B9 9B 17 A2 01 0D 00 00 14 09 AB F9 8C 17 92 11 80 03 00 01 0E 09 00 BF 14 86 02 00 00 2B 00 7F 01 00 00 00 1F 09 A5 85 B5 17 A2 13 20 00 00 0A 03 7F 00 00 00 00 1D 06 81 81 AB 17 92 01 37 00 00 91 01 06 B8 AC 96 17 8F 02 9B 01 00 00 17 09 91 87 97 17 BB 12 9E 0A 00 01 0B 08 BC C7 8D 17 A7 1E 0B 00 00 13 06 B0 A5 8D 17 B4 02 1F 00 00 29 05 9B A2 CD 17 90 03 99 01 00 00 2C 09 7F 88 0C 95 04 00 00 97 01 03 7F 08 01 00 00 1B 00 7F 01 00 00 00 18 00 83 C9 BF 17 01 00 00 00 87 01 06 AC B3 A4 17 B1 02 82 01 00 00 11 03 88 F6 8C 17 06 01 00 00 90 01 03 7F 07 01 00 00 09 09 9E 9F 96 17 82 0F B2 09 00 00 1A 02 7F 0A 02 00 01 86 01 08 80 FC 96 17 A7 20 9C 09 00 00 80 01 08 8B E1 95 17 8B 23 81 11 00 00 88 01 02 B2 95 97 17 1B 0B 00 00 24 00 7F 02 00 00 00 1C 03 B4 CE A7 17 15 09 00 01 93 01 03 7F 07 03 00 00 85 01 05 8C D3 95 17 B9 04 8F 01 00 00 04 08 00 83 01 27 00 00 1E 01 88 C0 B4 17 00 00 00 00 99 01 01 7F 00 00 00 00 21 01 98 F3 C5 17 00 00 00 00 10 03 B9 C7 9A 17 02 0D 00 00 01 09 00 94 18 8A 01 00 00 84 01 05 AE BF 8D 17 89 04 B2 01 00 00 25 05 7F 82 03 9E 01 00 00 22 00 9E A9 B9 17 01 00 00 00 0D 03 AB 9B 99 17 00 00 00 00 0F 06 BF F5 8C 17 88 02 23 00 00 9B 01 02 7F 09 05 00 00 2E 03 9D C7 CF 17 09 02 00 00 9A 01 03 B7 81 C5 17 18 02 00 00 98 01 00 AE F0 C5 17 01 00 00 00 15 02 86 A1 99 17 21 03 00 00 9E 01 04 90 80 DF 17 BF 02 84 02 00 00 20 09 8A 88 9F 17 B7 14 BC 03 00 00 81 01 06 AB F9 8C 17 97 02 13 00 00 89 01 06 99 E3 8D 17 B2 01 3B 00 00 37 00 96 BC F3 17 04 00 00 01 19 09 BC A1 AB 17 A6 13 21 00 00 3A 00 97 92 FB 17 01 00 00 00 00 FF 38 00 7F 00 00 00 00 06 00 7F 00 00 00 00 03 00 7F 00 00 00 00 16 00 7F 00 00 00 00 2E 00 7F 00 00 00 00 0C 00 7F 00 00 00 00 96 01 00 7F 00 00 00 00 24 00 7F 00 00 00 00 9A 11 AA 12 7F 93 E5 DD 9D 0B 01 00 0A"
                    .Replace(" ", ""));
            packet.AddHexa("83 09".Replace(" ", ""));
            packet.AddString("Demo Account 2v2 Friendly");
            packet.AddHexa("05 A8 C0 D3 94 0B A8 86 C7 A4 0B A8 C0 D3 94 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("Demo Account 2v2 Friendly");
            packet.AddString("{\"Target_AccountType\":\"DemoAccount\",\"HideTimer\":true,\"GameMode\":\"TeamVsTeam\"}");
            packet.AddHexa("84 09".Replace(" ", ""));
            packet.AddString("Demo Account 2v2 Draft Friendly");
            packet.AddHexa("05 A8 C0 D3 94 0B A8 86 C7 A4 0B A8 C0 D3 94 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("Demo Account 2v2 Draft Friendly");
            packet.AddString(
                "{\"GameMode\":\"TeamVsTeamDraftChallenge\",\"HideTimer\":true,\"Target_AccountType\":\"DemoAccount\"}");

            //example
            // packet.AddHexa("".Replace(" ", ""));
            //packet.AddString("");
            //packet.AddHexa("".Replace(" ", ""));
            //packet.AddString("");
            //packet.AddString("");

            packet.AddHexa("85 09".Replace(" ", ""));
            packet.AddString("Demo Account 1v1 Draft Friendly");
            packet.AddHexa("05 A8 C0 D3 94 0B A8 86 C7 A4 0B A8 C0 D3 94 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("Demo Account 1v1 Draft Friendly");
            packet.AddString("{\"HideTimer\":true,\"Target_AccountType\":\"DemoAccount\",\"GameMode\":\"DraftMode\"}");

            packet.AddHexa("95 11".Replace(" ", ""));
            packet.AddString("2v2 Button");
            packet.AddHexa("08 B0 93 D4 99 0B B0 E1 DD B7 0B B0 A9 8A 99 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("2v2 Button");
            packet.AddString(
                "{\"HideTimer\":true,\"HidePopupTimer\":true,\"ExtraGameModeChance\":0,\"GameMode\":\"TeamVsTeamLadder\",\"ExtraGameMode\":\"None\"}");

            packet.AddHexa("AF 12".Replace(" ", ""));
            packet.AddString("2v2 Double Elixir Draft Challenge Friendly");
            packet.AddHexa("05 B0 E1 AE 9D 0B B0 F9 D8 9D 0B B0 E1 AE 9D 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("2v2 Double Elixir Draft Challenge Friendly");
            packet.AddString("{\"GameMode\":\"TeamVsTeam_DraftModeInsane_Friendly\",\"DraftDeck\":\"Draft_v1\"}");

            packet.AddHexa("B0 12".Replace(" ", ""));
            packet.AddString("Event Page Header Image");
            packet.AddHexa("0D B0 F9 D8 9D 0B B0 E3 A2 9E 0B B0 F9 D8 9D 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("Event Page Header Image");
            packet.AddString(
                "{\"Title\":\"Touchdown Week\",\"Icon\":\"icon_tournament_touchdown\",\"TitleGlow\":true,\"Image\":{\"Path\":\"/o6HtD-PHSm_XjrXGFNxK-g.png\",\"Checksum\":\"0622e2aab8e14073aaa8d610ddab4772\",\"File\":\"touchdown_header_01.png\"}}");

            packet.AddVInt(1201);
            packet.AddString("2v2 Touch Down Practice");
            packet.AddHexa("02 B0 F9 D8 9D 0B B0 E3 A2 9E 0B B0 F9 D8 9D 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("2v2 Touch Down Practice");
            packet.AddString(
                "{\"Casual\":true,\"GameMode\":\"TeamVsTeam_Touchdown_Draft\",\"Title\":\"2v2 Touchdown Daily Practice\",\"FreePass\":1,\"IsChainedEvent\":false,\"IsDailyRefresh\":true,\"Casual_CrownsInsteadOfWins\":true,\"Rewards\":[{},{},{},{\"Milestone\":{\"Type\":\"Gold\",\"Amount\":300}},{},{},{\"Milestone\":{\"Chest\":\"Gold_<current_arena>\",\"Type\":\"Chest\"}},{},{},{},{\"Milestone\":{\"IsHighlighted\":true,\"Type\":\"Gems\",\"Amount\":5}}],\"IconExportName\":\"icon_tournament_touchdown\",\"WinIconExportName\":\"tournament_open_wins_badge_bronze\",\"Arena\":\"Arena_TouchdownTest\",\"Subtitle\":\"Casual Play with Rewards!\",\"Description\":\"Get a troop into your opponentâ€™s end zone to score a Crown. Win by getting three Crowns! Rewards refresh daily.\",\"Background\":{\"Path\":\"/ba6b0852871c2af2783e9d173a5da626_touchdown_challenge_01_6666_alpha_premul.png\",\"Checksum\":\"ba6b0852871c2af2783e9d173a5da626\",\"File\":\"touchdown_challenge_01_6666_alpha_premul.png\"},\"Background_Complete\":{\"Path\":\"/ba6b0852871c2af2783e9d173a5da626_touchdown_challenge_01_6666_alpha_premul.png\",\"Checksum\":\"ba6b0852871c2af2783e9d173a5da626\",\"File\":\"touchdown_challenge_01_6666_alpha_premul.png\"},\"DraftDeck\":\"Draft_Touchdown_v1\",\"UnlockedForXP\":\"Everyone\",\"EndNotification\":\"2v2 Touchdown Challenges end in two hours!\"}");

            packet.AddVInt(1201);
            packet.AddString("Friendly 2v2 Touchdown");
            packet.AddHexa("05 B0 F9 D8 9D 0B B0 C3 CB 9F 0B B0 F9 D8 9D 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("Friendly 2v2 Touchdown");
            packet.AddString(
                "{\"GameMode\":\"TeamVsTeam_Touchdown_Draft\",\"FixedArena\":\"Arena_TouchdownTest\",\"Title\":\"2v2 Touchdown Friendly\",\"Subtitle\":\"Play with your Clanmates!\",\"DraftDeck\":\"Draft_Touchdown_v1\",\"Background\":{\"Path\":\"/78cdfb212237aceaf34c9b3efa79f3f6_friend_touchdown_01_6666_alpha_premul.png\",\"Checksum\":\"78cdfb212237aceaf34c9b3efa79f3f6\",\"File\":\"friend_touchdown_01_6666_alpha_premul.png\"}}");

            packet.AddHexa("B3 12".Replace(" ", ""));
            packet.AddString("2v2 Touch Down Challenge");
            packet.AddHexa("02 B0 BF E3 9D 0B B0 91 83 9E 0B B0 F9 D8 9D 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("2v2 Touch Down Challenge");
            packet.AddString(
                "{\"GameMode\":\"TeamVsTeam_Touchdown_Draft\",\"FreePass\":0,\"JoinCost\":10,\"JoinCostResource\":\"Gems\",\"MaxLosses\":3,\"Rewards\":[{\"Gold\":130,\"Cards\":2},{\"Gold\":180,\"Cards\":3},{\"Gold\":240,\"Milestone\":{\"Chest\":\"Gold_<current_arena>\",\"Type\":\"Chest\"},\"Cards\":5},{\"Gold\":310,\"Cards\":8},{\"Gold\":390,\"Milestone\":{\"Type\":\"Gold\",\"Amount\":1000},\"Cards\":12},{\"Gold\":480,\"Cards\":17},{\"Gold\":600,\"Milestone\":{\"IsHighlighted\":true,\"Chest\":\"Giant_<current_arena>\",\"Type\":\"Chest\"},\"Cards\":25}],\"Arena\":\"Arena_TouchdownTest\",\"WinIconExportName\":\"tournament_open_wins_badge_bronze\",\"IconExportName\":\"icon_tournament_touchdown\",\"Subtitle\":\"Get 6 Wins to Unlock All the Rewards!\",\"Description\":\"Get a troop into your opponentâ€™s end zone to score a Crown. Win by getting three Crowns! Collect all rewards at 6 wins.\",\"Background\":{\"Path\":\"/5b5f649ebff7f0dedce9c52c87c77049_touchdown_challenge_02_6666_alpha_premul.png\",\"Checksum\":\"5b5f649ebff7f0dedce9c52c87c77049\",\"File\":\"touchdown_challenge_02_6666_alpha_premul.png\"},\"Background_Complete\":{\"Path\":\"/5b5f649ebff7f0dedce9c52c87c77049_touchdown_challenge_02_6666_alpha_premul.png\",\"Checksum\":\"5b5f649ebff7f0dedce9c52c87c77049\",\"File\":\"touchdown_challenge_02_6666_alpha_premul.png\"},\"UnlockedForXP\":\"Experienced\",\"DraftDeck\":\"Draft_Touchdown_v1\",\"Title\":\"2v2 Touchdown Challenge\",\"StartNotification\":\"2v2 Touchdown Challenge has started! Play with your Friend or a random person!\"}");

            packet.AddHexa("B4 12".Replace(" ", ""));
            packet.AddString("2v2 Touchdown Quest");
            packet.AddHexa("07 B0 F9 D8 9D 0B B0 E3 A2 9E 0B B0 F9 D8 9D 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("2v2 Touchdown Quest");
            packet.AddString(
                "{\"QuestType\":\"Win\",\"Win\":{\"Type\":\"Crowns\",\"Events\":[1201,1203]},\"Title\":\"2v2 Touchdown Quest\",\"Info\":\"Collect  40 crowns from 2v2 Touchdown Event\",\"Count\":40,\"MinLevel\":5,\"Points\":20,\"ChronosQuestRewards\":[{\"Type\":\"Epic\",\"Count\":4}]}");

            packet.AddHexa("01 B1 12".Replace(" ", ""));
            packet.AddString("2v2 Touch Down Practice");
            packet.AddHexa("02 B0 F9 D8 9D 0B B0 E3 A2 9E 0B B0 F9 D8 9D 0B 00 00 00 00 00 00 00 00".Replace(" ", ""));
            packet.AddString("2v2 Touch Down Practice");
            packet.AddString(
                "{\"Casual\":true,\"GameMode\":\"TeamVsTeam_Touchdown_Draft\",\"Title\":\"2v2 Touchdown Daily Practice\",\"FreePass\":1,\"IsChainedEvent\":false,\"IsDailyRefresh\":true,\"Casual_CrownsInsteadOfWins\":true,\"Rewards\":[{},{},{},{\"Milestone\":{\"Type\":\"Gold\",\"Amount\":300}},{},{},{\"Milestone\":{\"Chest\":\"Gold_<current_arena>\",\"Type\":\"Chest\"}},{},{},{},{\"Milestone\":{\"IsHighlighted\":true,\"Type\":\"Gems\",\"Amount\":5}}],\"IconExportName\":\"icon_tournament_touchdown\",\"WinIconExportName\":\"tournament_open_wins_badge_bronze\",\"Arena\":\"Arena_TouchdownTest\",\"Subtitle\":\"Casual Play with Rewards!\",\"Description\":\"Get a troop into your opponentâ€™s end zone to score a Crown. Win by getting three Crowns! Rewards refresh daily.\",\"Background\":{\"Path\":\"/ba6b0852871c2af2783e9d173a5da626_touchdown_challenge_01_6666_alpha_premul.png\",\"Checksum\":\"ba6b0852871c2af2783e9d173a5da626\",\"File\":\"touchdown_challenge_01_6666_alpha_premul.png\"},\"Background_Complete\":{\"Path\":\"/ba6b0852871c2af2783e9d173a5da626_touchdown_challenge_01_6666_alpha_premul.png\",\"Checksum\":\"ba6b0852871c2af2783e9d173a5da626\",\"File\":\"touchdown_challenge_01_6666_alpha_premul.png\"},\"DraftDeck\":\"Draft_Touchdown_v1\",\"UnlockedForXP\":\"Everyone\",\"EndNotification\":\"2v2 Touchdown Challenges end in two hours!\"}");

            packet.AddHexa(
                "00 01 B1 12 01 00 B0 BF E3 9D 0B 00 01 B1 A3 CF 45 03 01 1F 00 B0 F9 D8 9D 0B 00 01 96 11 00 0A 83 09 00 84 09 00 85 09 00 95 11 01 AF 12 01 B0 12 01 B1 12 01 B2 12 01 B3 12 01 B4 12 01 07 95 11 02 00 AF 12 03 00 B0 12 02 00 B1 12 02 00 B2 12 02 00 B3 12 01 00 B4 12 02 00 10"
                    .Replace(" ", ""));
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
                "01 0E 02 04 02 00 00 00 02 B1 12 B3 12 05 32 01 00 9A 04 00 03 01 00 08 06 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 0D 02 04 04 00 05 03 02 01 04 00 02 02 04 02 04 04 06 00 05 00 04 00 04 03 04 03 00 00 9F 03 06 02 00 00 9A 04 00 05 01 B4 02 03 01 00 01 9A 04 88 03 05 01 1A 01 14 00 00 01 00 02 9A 04 90 06 05 01 1A 0A 28 00 00 01 00 03 9A 04 A8 0F 05 01 1A 0F 01 02 00 01 00 04 9A 04 9C 17 05 01 1B 03 0F 01 00 01 00 05 9A 04 90 1F 05 01 1A 27 14 01 00 00 00 00 00 00 7F 95 11 00 00 9F BD 19 00 9F BD 19 00 9F BD 19"
                    .Replace(" ", ""));
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
                "18 01 A3 48 92 08 AC 09 AB 20 AD 1F 7E 9F 03 17 00 01 04 59 E8 F1 03 00 00 00 00 00 81 88 C4 2D 90 F5 DE 9D 0B AF E4 A1 03"
                    .Replace(" ", ""));
            return packet.ToArray();
        }
    }
}