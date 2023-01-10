using System.ComponentModel;

namespace ConfigEditor
{
    class Server : Machine
    {
        private string path, connectionString;

        public Server(string path, string connectionString)
        {
            this.path = path;
            this.connectionString = connectionString;
        }

        public override string Path
        {
            get
            { return this.path; }
        }

        public string ConnectionString
        {
            get
            { return this.connectionString; }
        }
    }
}