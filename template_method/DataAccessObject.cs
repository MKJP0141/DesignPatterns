using System.Data;

namespace template_method
{
    public abstract class DataAccessObject
    {
        protected string _connectionString;
        protected DataSet _dataSet;

        public virtual void Connect()
        {
            _connectionString = string.Empty;
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            _connectionString = string.Empty;
        }

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}