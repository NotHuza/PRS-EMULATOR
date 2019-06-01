using System;
using System.IO;
using System.Text;

namespace Royale2Sharp.Utilities
{
    public class Reader : BinaryReader
    {
        public Reader(byte[] _Buffer) : base(new MemoryStream(_Buffer))
        {
        }

        public byte[] ReadAllBytes => ReadBytes((int) BaseStream.Length - (int) BaseStream.Position);

        public override int Read(byte[] _Buffer, int _Offset, int _Count)
        {
            return BaseStream.Read(_Buffer, 0, _Count);
        }

        public byte[] ReadArray()
        {
            var _Length = ReadInt32();
            if (_Length == -1 || _Length < -1 || _Length > BaseStream.Length - BaseStream.Position)
                return null;

            var _Buffer = ReadBytesWithEndian(_Length, false);
            return _Buffer;
        }

        public override bool ReadBoolean()
        {
            var state = ReadByte();
            switch (state)
            {
                case 0:
                    return false;

                case 1:
                    return true;

                default:
                    throw new Exception("Error when reading a bool in packet.");
            }
        }

        public override byte ReadByte()
        {
            return (byte) BaseStream.ReadByte();
        }

        public byte[] ReadBytes()
        {
            var length = ReadInt32();

            if (length == -1)
                return null;

            return ReadBytes(length);
        }

        public override short ReadInt16()
        {
            return (short) ReadUInt16();
        }

        public int ReadInt24()
        {
            var _Temp = ReadBytesWithEndian(3, false);
            return (_Temp[0] << 16) | (_Temp[1] << 8) | _Temp[2];
        }

        public override int ReadInt32()
        {
            return (int) ReadUInt32();
        }

        public override long ReadInt64()
        {
            return (long) ReadUInt64();
        }

        public override string ReadString()
        {
            var _Length = ReadInt32();

            if (_Length <= -1 || _Length > BaseStream.Length - BaseStream.Position)
                return null;

            var _Buffer = ReadBytesWithEndian(_Length, false);
            return Encoding.UTF8.GetString(_Buffer);
        }

        public override ushort ReadUInt16()
        {
            var _Buffer = ReadBytesWithEndian(2);
            return BitConverter.ToUInt16(_Buffer, 0);
        }

        public uint ReadUInt24()
        {
            return (uint) ReadInt24();
        }

        public override uint ReadUInt32()
        {
            var _Buffer = ReadBytesWithEndian(4);
            return BitConverter.ToUInt32(_Buffer, 0);
        }

        public override ulong ReadUInt64()
        {
            var _Buffer = ReadBytesWithEndian(8);
            return BitConverter.ToUInt64(_Buffer, 0);
        }

        public long Seek(long _Offset, SeekOrigin _Origin)
        {
            return BaseStream.Seek(_Offset, _Origin);
        }

        private byte[] ReadBytesWithEndian(int _Count, bool _Endian = true)
        {
            var _Buffer = new byte[_Count];
            BaseStream.Read(_Buffer, 0, _Count);

            if (BitConverter.IsLittleEndian && _Endian)
                Array.Reverse(_Buffer);

            return _Buffer;
        }
    }
}