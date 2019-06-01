using System;
using System.IO;
using System.Text;

namespace Royale2Sharp.Utilities
{
    /// <summary>
    ///     Wrapper of <see cref="BinaryWriter" /> that implements methods to write Clash of Clans messages.
    /// </summary>
    public class MessageWriter : BinaryWriter
    {
        private bool _disposed;

        public MessageWriter()
        {
            //Nothing xD
        }

        public MessageWriter(Stream output) : base(output)
        {
            // Space
        }

        public override void Write(decimal value)
        {
            CheckDispose();

            Write((double) value);
        }

        public override void Write(double value)
        {
            CheckDispose();

            var buffer = BitConverter.GetBytes(value);
            WriteByteArrayEndian(buffer);
        }

        public override void Write(long value)
        {
            CheckDispose();

            Write((ulong) value);
        }

        public override void Write(ulong value)
        {
            CheckDispose();

            var buffer = BitConverter.GetBytes(value);
            WriteByteArrayEndian(buffer);
        }

        public override void Write(float value)
        {
            CheckDispose();

            var buffer = BitConverter.GetBytes(value);
            WriteByteArrayEndian(buffer);
        }

        public override void Write(int value)
        {
            CheckDispose();

            Write((uint) value);
        }

        public override void Write(uint value)
        {
            CheckDispose();

            var buffer = BitConverter.GetBytes(value);
            WriteByteArrayEndian(buffer);
        }

        public override void Write(short value)
        {
            CheckDispose();

            Write((ushort) value);
        }

        public override void Write(ushort value)
        {
            CheckDispose();

            var buffer = BitConverter.GetBytes(value);
            WriteByteArrayEndian(buffer);
        }

        public override void Write(string value)
        {
            CheckDispose();

            if (value == null)
            {
                Write(-1);
            }
            else
            {
                var buffer = Encoding.UTF8.GetBytes(value);
                Write(buffer.Length);
                Write(buffer);
            }
        }

        public override void Write(bool value)
        {
            CheckDispose();

            base.Write(value);
        }

        public void Write(byte[] buffer, bool prefixed)
        {
            CheckDispose();

            Write(buffer, 0, buffer.Length, prefixed);
        }

        public void Write(byte[] buffer, int index, int count, bool prefixed)
        {
            CheckDispose();

            if (!prefixed)
            {
                Write(buffer, index, count);
            }
            else
            {
                Write(buffer.Length);
                Write(buffer, index, count);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            //if (disposing)
            //{

            //}

            _disposed = true;
            base.Dispose(true);
        }

        internal void CheckDispose()
        {
            if (_disposed)
                throw new ObjectDisposedException(null,
                    "Cannot access the MessageWriter object because it was disposed.");
        }

        private void WriteByteArrayEndian(byte[] buffer)
        {
            if (BitConverter.IsLittleEndian)
                Array.Reverse(buffer);
            Write(buffer);
        }
    }
}