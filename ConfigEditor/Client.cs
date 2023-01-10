namespace ConfigEditor
{
    class Client : Machine
    {
        private string path;
        private bool isTsClient;

        public Client(string path, bool isTsClient)
        {
            this.path = path;
            this.isTsClient = isTsClient;
        }

        public override string Path
        {
            get { return path; }
        }

        public bool IsTsClient
        {
            get { return isTsClient; }
        }

    }
}