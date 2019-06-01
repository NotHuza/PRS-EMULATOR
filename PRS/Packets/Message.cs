using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using Royale2Sharp.Core;
using Royale2Sharp.Core.Settings;
using Royale2Sharp.Packets.Crypto.RC4;
using Royale2Sharp.Packets.Messages.Server;
using Royale2Sharp.Utilities;

namespace Royale2Sharp.Packets
{
    internal class Message
    {
        internal static RC4_Core RC4;
        internal Reader Reader;
        internal static ushort Identifier;
        internal static int Lenght;
        internal static int Version;
        internal static List<byte> Buffer = new List<byte>();
        internal static List<byte> Decr = new List<byte>();
        internal static byte[] Payload = new byte[4096];
        internal static byte[] EncryptedPayload = new byte[4096];
        internal Socket _handler;

        internal Message(Socket handler, byte[] packet)
        {
            Buffer.Clear();
            _handler = handler;
            Buffer.AddRange(packet);
            //We are reading packet header
            Reader = new Reader(Buffer.ToArray());
            Identifier = Reader.ReadUInt16();
            Lenght = Reader.ReadInt24();
            Version = Reader.ReadUInt16();
            byte[] payload = Buffer.Skip(7).ToArray();
            Logger.Log($"We Received Packet {Identifier} with lenght {Lenght} and version {Version}",
                Logger.DefCon.DEBUGCLIENT);
            Payload = payload;
            Array.Resize(ref Payload, payload.Length);
            switch (Identifier)
            {
                default:
                    Decode();
                    Process();
                    break;
                case 10100:
                    Logger.Log("Pepper client attempted to connect to the server! Patching Client...", Logger.DefCon.WARN);
                    Decode();
                    Process();
                    break;
            }
        }

        internal virtual void Decrypt()
        {
            Decr.AddRange(Payload);
            if (Identifier != 10100)
            {
                EncryptedPayload = Decr.ToArray();
                RC4.Decrypt(ref EncryptedPayload);
            }
        }

        internal void Encrypt()
        {
        }

        internal void Decode()
        {
        }

        internal void Encode()
        {
        }

        internal void Process()
        {
            switch (Identifier)
            {
                case 10100:
                    _handler.Send(PacketBuilder2(20103, 4, LoginFailed.Payload(Constants.LoginFailed.Error.OutDatedContent)));
                    Constants.ServerConfig.ContentTimes = 1;
                    break;
                case 10101:
                    if (Constants.ServerConfig.ContentTimes == 0 && Constants.ProtocolConfig.patchClient == true)
                    {
                        _handler.Send(PacketBuilder(20103, 4, LoginFailed.Payload(Constants.LoginFailed.Error.OutDatedContent)));
                        Constants.ServerConfig.ContentTimes = 1;
                    }
                    else
                    {
                        Constants.ServerConfig.ContentTimes = 0;
                        var ToProcess = LoginOk.Array();
                        _handler.Send(PacketBuilder(20104, 1, ToProcess));
                        //var ToProcess55 = OwnHomeData.OwnHomeDataArray();
                        //_handler.Send(PacketBuilder(24101, 1, ToProcess55));
                        // Logger.Log($"We Sent OwnHomeData", Logger.DefCon.DEBUGSERVER);
                        //var ToProcess111 = Sodium.Utilities.HexToBinary("0100");
                        //_handler.Send(PacketBuilder(20207, 1, ToProcess111));
                        //var ToProcess100 = AllianceStream.Array();
                        //_handler.Send(PacketBuilder(24311, 1, ToProcess100));
                        //var ToProcess2 = OwnHomeData.OwnHomeDataArray();
                        //_handler.Send(PacketBuilder(24101, 1, ToProcess2));
                        var ToProcess2 = SectorState.Array();
                        _handler.Send(PacketBuilder(21903, 1, ToProcess2));
                        Logger.Log($"We Sent SectorState", Logger.DefCon.DEBUGSERVER);
                    }
                    
                    break;
                case 10108:
                    var ToProcess3 = KeepAliveOk.Array();
                    _handler.Send(PacketBuilder(20108, 1, ToProcess3));
                    Logger.Log($"We Sent KeepAliveOk", Logger.DefCon.DEBUGSERVER);
                    break;
                case 14104:
                    var ToProcess4 = SectorState.Array();
                    _handler.Send(PacketBuilder(21903, 1, ToProcess4));
                    Logger.Log($"We Sent SectorState", Logger.DefCon.DEBUGSERVER);
                    break;
                case 14101:
                    var ToProcess5 = OwnHomeData.OwnHomeDataArray();
                    _handler.Send(PacketBuilder(24101, 1, ToProcess5));
                    Logger.Log($"We Sent OwnHomeData", Logger.DefCon.DEBUGSERVER);
                    var ToProcess11 = Sodium.Utilities.HexToBinary("0100");
                    _handler.Send(PacketBuilder(20207, 1, ToProcess11));
                    var ToProcess10 = AllianceStream.Array();
                    _handler.Send(PacketBuilder(24311, 1, ToProcess10));
                    var ToProcess1000 = AllianceMessage.Array("Type -s for avaiable commands!", "ProjectRoyaleBot", 13, 2);
                    _handler.Send(PacketBuilder(24312, 1, ToProcess1000));
                    break;
                case 14102:
                    //var EndClientTurnMessage = Payload;

                    //int Tick;
                    //int Checksum;
                    //int Count;

                    //byte[] Commands;

                    //// Begin Reading the ECT payload.
                    //using (var Reader = new Reader(Payload))
                    //{
                    //    Tick = Reader.ReadVInt();
                    //    Checksum = Reader.ReadVInt();
                    //    Count = Reader.ReadVInt();

                    //    Commands = Reader.ReadBytes((int)(Reader.BaseStream.Length - Reader.BaseStream.Position));
                    //}

                    //Console.WriteLine("Tick: " + Tick);
                    //Console.WriteLine("Checksum: " + Checksum);
                    //Console.WriteLine("Count: " + Count);

                    //if (Count > -1 && Count <= 50)
                    //    using (var Reader = new Reader(Commands))
                    //    {
                    //        for (var i = 0; i < Count; i++)
                    //        {
                    //            var CommandID = Reader.ReadVInt();

                    //            Console.WriteLine("Waiting to handle " + CommandID);
                    //        }
                    //    }
                    break;
                case 10905:
                    var ToProcess6 = InBoxData.Payload();
                    _handler.Send(PacketBuilder(24445, 1, ToProcess6));
                    break;
                case 14302:
                    var ToProcess8 = AllianceData.Payload();
                    _handler.Send(PacketBuilder(24301, 1, ToProcess8));
                    break;
                case 14315:
                    Console.WriteLine("Message => " + BitConverter.ToString(EncryptedPayload).Replace("-",""));
                
                        var ToProcess10001 = AllianceMessage.Array("Unknown command", "HuzaModz", 13, 1);
                        _handler.Send(PacketBuilder(24312, 1, ToProcess10001));
                    

                    break;
                default:
                    Logger.Log($"Packet {Identifier} has not been handled!", Logger.DefCon.WARN);
                    break;
            }
        }

        internal byte[] PacketBuilder(ushort Identifier, ushort Version, byte[] Payload)
        {
            if (Identifier != 20100)
            {
                RC4.Encrypt(ref Payload);
                var Packet = new List<byte>();
                Packet.AddUShort(Identifier);
                Packet.Add(0);
                Packet.AddUShort((ushort) Payload.Length);
                Packet.AddUShort(Version);
                Packet.AddRange(Payload);
                return Packet.ToArray();
            }
            else
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