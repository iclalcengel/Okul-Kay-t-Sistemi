
using System.Data;

namespace okulkayit
{
    internal class SqlConnection
    {
        private string v;

        public SqlConnection(string v)
        {
            this.v = v;
        }

        public ConnectionState State { get; internal set; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal object Open()
        {
            throw new NotImplementedException();
        }
    }
}