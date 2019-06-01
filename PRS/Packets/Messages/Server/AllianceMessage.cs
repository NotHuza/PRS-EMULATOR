using Royale2Sharp.Core.Settings;
using Royale2Sharp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royale2Sharp.Packets.Messages.Server
{
    internal class AllianceMessage
    {
        internal static byte[] Array(string Message , string Name , int Level , int Role)
        {
            List<byte> Data = new List<byte>();
            Data.AddVInt(2);
            Data.AddVLong(Constants.AllianceMessage.id++);
            Data.AddVLong(0);
            Data.AddVLong(0);
            Data.AddString(Name);
            Data.AddVInt(13);
            Data.AddVInt(3);
            Data.AddVInt(0);
            Data.Add(0);
            Data.AddString(Message);
            return Data.ToArray();
        }
    }
}
