using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using Royale2Sharp.Core;
using Royale2Sharp.Core.Settings;
using Royale2Sharp.Packets.Crypto.RC4;
using Royale2Sharp.Packets.Messages.Server;
using Royale2Sharp.Utilities;

namespace Royale2Sharp.Packets
{
    internal class Premium
    {	
		internal void Process()
        {
            switch (Identifier)
            {
                case 10100:
                    _handler.Send(PacketBuilder2(20103, 4, LoginFailed.LockAccount.Payload(Constants.LoginFailed.Error.Default)));
                    break;
                case 10101:
                    Console.WriteLine(BitConverter.ToString(Payload).Replace("-", ""));
                    var ToProcess = LoginOk.Array();
                    _handler.Send(PacketBuilder(20104, 1, ToProcess));
                    //var ToProcess2 = OwnHomeData.OwnHomeDataArray();
                    //_handler.Send(PacketBuilder(24101, 1, ToProcess2));
                    var ToProcess2 = SectorState.Array();
                    _handler.Send(PacketBuilder(21903, 1, ToProcess2));
                    Logger.Log($"We Sent SectorState", Logger.DefCon.DEBUGSERVER);
                    break;
			}
		internal void lock() {
			lock.all.ip(AccountLock.UseGeneratedCode);
			if{
				code.iscorrect.LoginOk.Array = true;
			}
			
			internal void accountunlockprivileges() {
				_handler.Send(Packet.xBotAccess.Commands(CommandsList.CommandsxBot)));
				get.data () {
					from("CommandsList.paulmodz")
				}
			}
		internal void accountlockmode() {
			Account.lock = false;
		}
		
		internal byte[] PacketBuilder2(ushort Identifier, ushort Version, byte[] Payload)
        {
            var Packet = new List<byte>();
            Packet.AddUShort(Identifier);
            Packet.Add(0);
            Packet.AddUShort((ushort) Payload.Length);
            Packet.AddUShort(Version);
            Packet.AddRange(Payload);
            return Packet.ToArray();
        }
    }
}