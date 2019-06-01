using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Royale2Sharp.Utilities
{
    internal static class WriterList
    {
        public static void AddInt(this List<byte> _Packet, int _Value)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse());
        }

        public static void AddIntEndian(this List<byte> _Packet, int _Value)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value));
        }

        public static void AddInt(this List<byte> _Packet, int _Value, int _Skip)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse().Skip(_Skip));
        }

        public static void AddLong(this List<byte> _Packet, long _Value)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse());
        }

        public static void AddLong(this List<byte> _Packet, long _Value, int _Skip)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse().Skip(_Skip));
        }

        public static void Add(this List<byte> _Packet, bool _Value)
        {
            _Packet.Add(_Value ? (byte) 1 : (byte) 0);
        }

        public static void AddString(this List<byte> _Packet, string _Value)
        {
            if (_Value == null)
            {
                _Packet.AddRange(BitConverter.GetBytes(-1).Reverse());
            }
            else
            {
                var _Buffer = Encoding.UTF8.GetBytes(_Value);

                _Packet.AddInt(_Buffer.Length);
                _Packet.AddRange(_Buffer);
            }
        }

        public static void AddUShort(this List<byte> _Packet, ushort _Value)
        {
            _Packet.AddRange(BitConverter.GetBytes(_Value).Reverse());
        }

        public static void AddScid(this List<byte> _Packet, int high, int low)
        {
            _Packet.AddVInt(high);
            _Packet.AddVInt(low);
        }

        public static void AddVInt(this List<byte> _Packet, int _Value)
        {
            if (_Value > 63)
            {
                _Packet.Add((byte) ((_Value & 0x3F) | 0x80));

                if (_Value > 8191)
                {
                    _Packet.Add((byte) ((_Value >> 6) | 0x80));

                    if (_Value > 1048575)
                    {
                        _Packet.Add((byte) ((_Value >> 13) | 0x80));

                        if (_Value > 134217727)
                        {
                            _Packet.Add((byte) ((_Value >> 20) | 0x80));
                            _Value >>= 27 & 0x7F;
                        }
                        else
                        {
                            _Value >>= 20 & 0x7F;
                        }
                    }
                    else
                    {
                        _Value >>= 13 & 0x7F;
                    }
                }
                else
                {
                    _Value >>= 6 & 0x7F;
                }
            }
            _Packet.Add((byte) _Value);
        }

        public static void AddVLong(this List<byte> _Packet, long _Value)
        {
            byte _Temporary = 0;

            _Packet.Add(0);

            _Temporary = (byte) ((_Value >> 57) & 0x40L);
            _Value = _Value ^ (_Value >> 63);
            _Temporary |= (byte) (_Value & 0x3FL);
            _Value >>= 6;

            if (_Value != 0)
            {
                _Temporary |= 0x80;
                _Packet.Add(_Temporary);

                while (true)
                {
                    _Temporary = (byte) (_Value & 0x7FL);
                    _Value >>= 7;
                    _Temporary |= (byte) ((_Value != 0 ? 1 : 0) << 7);
                    _Packet.Add(_Temporary);

                    if (_Value == 0)
                        break;
                }
            }
            else
            {
                _Packet.Add(_Temporary);
            }
        }

        public static byte[] HexaToBytes(this string _Value)
        {
            var _Tmp = _Value.Replace("-", string.Empty);
            return Enumerable.Range(0, _Tmp.Length).Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(_Tmp.Substring(x, 2), 16)).ToArray();
        }

        public static void AddHexa(this List<byte> _Packet, string _Value)
        {
            var _Tmp = _Value.Replace("-", string.Empty);
            _Packet.AddRange(Enumerable.Range(0, _Tmp.Length).Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(_Tmp.Substring(x, 2), 16)).ToArray());
        }
    }
}