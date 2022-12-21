using System.Xml;

namespace ConfigEditor
{
    public class XmlFunctions
    {
        private static String Path = $"{Directory.GetCurrentDirectory()}//config.xml";

        public List<Server> OpenConfigData()
        {
            if (!File.Exists(Path))
            {
                WriteXml(true);
            }

            return ReadServer();
        }

        private List<Server> ReadServer()
        {
            var serverList = new List<Server>();
            XmlDocument document = new XmlDocument();
            document.PreserveWhitespace = true;
            document.Load(Path);
            

            var nodes = document.SelectNodes("Server");

            foreach (var node in nodes)
            {
                var server = new Server();
                //TODO SetProperties
                server.Name = ""; //...

                serverList.Add(server);
            }

            return serverList;
        }



        private List<Server> ReadClients()
        {
            var serverList = new List<Server>();
            XmlDocument document = new XmlDocument();
            document.PreserveWhitespace = true;
            document.Load(Path);


            var nodes = document.SelectNodes("Clients");

            foreach (var node in nodes)
            {
                var server = new Server();
                //TODO SetProperties
                server.Name = ""; //...

                serverList.Add(server);
            }

            return serverList;
        }



        public void WriteXml(bool empty)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            if (empty)
            {
                using (XmlWriter writer = XmlWriter.Create(Path, settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Config");
                    writer.WriteStartElement("Servers");
                    writer.WriteEndElement();
                    writer.WriteStartElement("Clients");
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                }
            }
            else
            {
                //ToDo Save
            }
        }
    }
}