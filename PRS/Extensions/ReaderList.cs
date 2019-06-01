using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Royale2Sharp.Utilities
{
    internal static class ReaderList
    {
        public static int ReadInt32WithEndian(this BinaryReader _Reader)
        {
            var _Buffer = _Reader.ReadBytes(4);
            Array.Reverse(_Buffer);
            return BitConverter.ToInt32(_Buffer, 0);
        }

        public static long ReadInt64WithEndian(this BinaryReader _Reader)
        {
            var _Buffer = _Reader.ReadBytes(8);
            Array.Reverse(_Buffer);
            return BitConverter.ToInt64(_Buffer, 0);
        }

        public static string ReadString(this BinaryReader _Reader)
        {
            var _Length = _Reader.ReadInt32WithEndian();
            if (_Length > -1)
            {
                if (_Length > 0)
                {
                    var _Buffer = _Reader.ReadBytes(_Length);
                    return Encoding.UTF8.GetString(_Buffer);
                }

                return string.Empty;
            }

            return null;
        }

        public static ushort ReadUInt16WithEndian(this BinaryReader _Reader)
        {
            var _Buffer = _Reader.ReadBytes(2);
            Array.Reverse(_Buffer);
            return BitConverter.ToUInt16(_Buffer, 0);
        }

        public static uint ReadUInt32WithEndian(this BinaryReader _Reader)
        {
            var _Buffer = _Reader.ReadBytes(4);
            Array.Reverse(_Buffer);
            return BitConverter.ToUInt32(_Buffer, 0);
        }

        public static int ReadVInt(this BinaryReader br)
        {
            int v5;
            var b = br.ReadByte();
            v5 = b & 0x80;
            var _LR = b & 0x3F;

            if ((b & 0x40) != 0)
            {
                if (v5 != 0)
                {
                    b = br.ReadByte();
                    v5 = ((b << 6) & 0x1FC0) | _LR;
                    if ((b & 0x80) != 0)
                    {
                        b = br.ReadByte();
                        v5 = v5 | ((b << 13) & 0xFE000);
                        if ((b & 0x80) != 0)
                        {
                            b = br.ReadByte();
                            v5 = v5 | ((b << 20) & 0x7F00000);
                            if ((b & 0x80) != 0)
                            {
                                b = br.ReadByte();
                                _LR = (int) (v5 | (b << 27) | 0x80000000);
                            }
                            else
                            {
                                _LR = (int) (v5 | 0xF8000000);
                            }
                        }
                        else
                        {
                            _LR = (int) (v5 | 0xFFF00000);
                        }
                    }
                    else
                    {
                        _LR = (int) (v5 | 0xFFFFE000);
                    }
                }
            }
            else
            {
                if (v5 != 0)
                {
                    b = br.ReadByte();
                    _LR |= (b << 6) & 0x1FC0;
                    if ((b & 0x80) != 0)
                    {
                        b = br.ReadByte();
                        _LR |= (b << 13) & 0xFE000;
                        if ((b & 0x80) != 0)
                        {
                            b = br.ReadByte();
                            _LR |= (b << 20) & 0x7F00000;
                            if ((b & 0x80) != 0)
                            {
                                b = br.ReadByte();
                                _LR |= b << 27;
                            }
                        }
                    }
                }
            }

            return _LR;
        }

        public static int ReadVInt(byte[] ba)
        {
            int v5;
            int _LR;
            using (var br = new Reader(ba))
            {
                var b = br.ReadByte();
                v5 = b & 0x80;
                _LR = b & 0x3F;

                if ((b & 0x40) != 0)
                {
                    if (v5 != 0)
                    {
                        b = br.ReadByte();
                        v5 = ((b << 6) & 0x1FC0) | _LR;
                        if ((b & 0x80) != 0)
                        {
                            b = br.ReadByte();
                            v5 = v5 | ((b << 13) & 0xFE000);
                            if ((b & 0x80) != 0)
                            {
                                b = br.ReadByte();
                                v5 = v5 | ((b << 20) & 0x7F00000);
                                if ((b & 0x80) != 0)
                                {
                                    b = br.ReadByte();
                                    _LR = (int) (v5 | (b << 27) | 0x80000000);
                                }
                                else
                                {
                                    _LR = (int) (v5 | 0xF8000000);
                                }
                            }
                            else
                            {
                                _LR = (int) (v5 | 0xFFF00000);
                            }
                        }
                        else
                        {
                            _LR = (int) (v5 | 0xFFFFE000);
                        }
                    }
                }
                else
                {
                    if (v5 != 0)
                    {
                        b = br.ReadByte();
                        _LR |= (b << 6) & 0x1FC0;
                        if ((b & 0x80) != 0)
                        {
                            b = br.ReadByte();
                            _LR |= (b << 13) & 0xFE000;
                            if ((b & 0x80) != 0)
                            {
                                b = br.ReadByte();
                                _LR |= (b << 20) & 0x7F00000;
                                if ((b & 0x80) != 0)
                                {
                                    b = br.ReadByte();
                                    _LR |= b << 27;
                                }
                            }
                        }
                    }
                }
            }

            return _LR;
        }

        public static long ReadVInt64(this BinaryReader br)
        {
            var temp = br.ReadByte();
            long i = 0;
            var Sign = (temp >> 6) & 1;
            i = temp & 0x3FL;

            while (true)
            {
                if ((temp & 0x80) == 0)
                    break;

                temp = br.ReadByte();
                i |= (temp & 0x7FL) << 6;

                if ((temp & 0x80) == 0)
                    break;

                temp = br.ReadByte();
                i |= (temp & 0x7FL) << (6 + 7);

                if ((temp & 0x80) == 0)
                    break;

                temp = br.ReadByte();
                i |= (temp & 0x7FL) << (6 + 7 + 7);

                if ((temp & 0x80) == 0)
                    break;

                temp = br.ReadByte();
                i |= (temp & 0x7FL) << (6 + 7 + 7 + 7);

                if ((temp & 0x80) == 0)
                    break;

                temp = br.ReadByte();
                i |= (temp & 0x7FL) << (6 + 7 + 7 + 7 + 7);

                if ((temp & 0x80) == 0)
                    break;

                temp = br.ReadByte();
                i |= (temp & 0x7FL) << (6 + 7 + 7 + 7 + 7 + 7);

                if ((temp & 0x80) == 0)
                    break;

                temp = br.ReadByte();
                i |= (temp & 0x7FL) << (6 + 7 + 7 + 7 + 7 + 7 + 7);

                if ((temp & 0x80) == 0)
                    break;

                temp = br.ReadByte();
                i |= (temp & 0x7FL) << (6 + 7 + 7 + 7 + 7 + 7 + 7 + 7);
            }
            i ^= -Sign;
            return i;
        }

        public static uint ReadVarInt(this Reader _Packet)
        {
            return Varint.ToUInt32(_Packet.ReadBytes(2));
        }

        public static string ToHexa(byte[] _Packet)
        {
            return BitConverter.ToString(_Packet).Replace("-", string.Empty).ToUpper();
        }

        public static string ToHexa(this List<byte> _Packet)
        {
            return BitConverter.ToString(_Packet.ToArray()).Replace("-", string.Empty).ToUpper();
        }

        public static string ToHexa(this string _Packet)
        {
            return BitConverter.ToString(Encoding.UTF8.GetBytes(_Packet)).Replace("-", string.Empty).ToUpper();
        }
    }
}