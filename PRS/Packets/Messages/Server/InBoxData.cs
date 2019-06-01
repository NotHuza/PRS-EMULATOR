using System.Collections.Generic;
using Royale2Sharp.Utilities;

namespace Royale2Sharp.Packets.Messages.Server
{
    internal class InBoxData
    {
        internal static byte[] Payload()
        {
            var Data = new List<byte>();
            Data.AddInt(5); //Message count

            Data.AddString(
                "https://56f230c6d142ad8a925f-b174a1d8fb2cf6907e1c742c46071d76.ssl.cf2.rackcdn.com/inbox/ClashRoyale_logo_small.png");
            Data.AddString("<c4>PRS - Emulator Official</c>!"); //Title
            Data.AddString("Official Test of HuzaModz Emulator Best Royale Server Out There"); //Description
            Data.AddString("yutube chanal"); //Button Name
            Data.AddString("https://www.youtube.com/channel/UCfLlipbyZiqDlTbFyHdZlfg?&ab_channel=HUZAMODZ"); //Button Link
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk

            Data.AddString(
                "https://56f230c6d142ad8a925f-b174a1d8fb2cf6907e1c742c46071d76.ssl.cf2.rackcdn.com/inbox/ClashRoyale_logo_small.png");
            Data.AddString("<c4>Test</c>!"); //Title
            Data.AddString("AnotherTest!"); //Description
            Data.AddString("Test_Button!"); //Button Name
            Data.AddString(""); //Button Link
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk

            Data.AddString(
                "https://56f230c6d142ad8a925f-b174a1d8fb2cf6907e1c742c46071d76.ssl.cf2.rackcdn.com/inbox/ClashRoyale_logo_small.png");
            Data.AddString("<c4>Test</c>!"); //Title
            Data.AddString("AnotherTest!"); //Description
            Data.AddString("Test_Button!"); //Button Name
            Data.AddString(""); //Button Link
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk


            Data.AddString(
                "https://56f230c6d142ad8a925f-b174a1d8fb2cf6907e1c742c46071d76.ssl.cf2.rackcdn.com/inbox/ClashRoyale_logo_small.png");
            Data.AddString("<c4>Test</c>!"); //Title
            Data.AddString("AnotherTest!"); //Description
            Data.AddString("Test_Button!"); //Button Name
            Data.AddString(""); //Button Link
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk


            Data.AddString(
                "https://56f230c6d142ad8a925f-b174a1d8fb2cf6907e1c742c46071d76.ssl.cf2.rackcdn.com/inbox/ClashRoyale_logo_small.png");
            Data.AddString("<c4>Test</c>!"); //Title
            Data.AddString("AnotherTest!"); //Description
            Data.AddString("Test_Button!"); //Button Name
            Data.AddString(""); //Button Link
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk

            return Data.ToArray();
        }
    }
}