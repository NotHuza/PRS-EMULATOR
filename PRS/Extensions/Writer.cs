using System;
using System.IO;

namespace Royale2Sharp.Utilities
{
    public class Writer : BinaryWriter
    {
        public Writer() : base(new MemoryStream(new byte[2048]))
        {
        }

        public void Write(int _Value, bool _Inverted = false)
        {
            if (_Inverted)
            {
                var _Bytes = BitConverter.GetBytes(_Value);
                Array.Reverse(_Bytes);
                Write(_Bytes);
            }
            else
            {
                Write(_Value);
            }
        }

        public void Write(long _Value, bool _Inverted = false)
        {
            if (_Inverted)
            {
                var _Bytes = BitConverter.GetBytes(_Value);
                Array.Reverse(_Bytes);
                Write(_Bytes);
            }
            else
            {
                Write(_Value);
            }
        }

        public void Write(short _Value, bool _Inverted = false)
        {
            if (_Inverted)
            {
                var _Bytes = BitConverter.GetBytes(_Value);
                Array.Reverse(_Bytes);
                Write(_Bytes);
            }
            else
            {
                Write(_Value);
            }
        }

        public void Write(bool _Value, bool _Inverted = false)
        {
            if (_Inverted)
            {
                var _Bytes = BitConverter.GetBytes(_Value);
                Array.Reverse(_Bytes);
                Write(_Bytes);
            }
            else
            {
                Write(_Value);
            }
        }
    }
}