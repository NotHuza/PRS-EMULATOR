using System.Collections.Generic;
using HuzaRoyale.Utilities;

namespace HuzaRoyale.Packets.Messages.Server
{
    internal class InBoxData
    {
        internal static byte[] Payload()
        {
            var Data = new List<byte>();
            Data.AddInt(5); //Message count

            Data.AddString(
                "https://56f230c6d142ad8a925f-b174a1d8fb2cf6907e1c742c46071d76.ssl.cf2.rackcdn.com/inbox/ClashRoyale_logo_small.png");
            Data.AddString("<c4>Welcome!</c>!"); //Title
            Data.AddString("PaUlModz Private Server is officialy opened in private beta!"); //Description
            Data.AddString("Test_Button!"); //Button Name
            Data.AddString(""); //Button Link
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk
            Data.AddString(""); //Unk


            return Data.ToArray();
        }
    }
}