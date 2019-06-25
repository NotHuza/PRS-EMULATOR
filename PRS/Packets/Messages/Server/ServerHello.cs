namespace HuzaRoyale.Packets.Messages.Server
{
    internal class ServerHello
    {
        internal static byte[] Array()
        {
            return Sodium.Utilities.HexToBinary(
                "00 00 00 18 32 D7 22 AA 37 73 7B 4C 49 21 7E D8 6B FA 58 B0 8E 97 E0 08 C4 9E BD 17".Replace(" ", ""));
        }
    }
}