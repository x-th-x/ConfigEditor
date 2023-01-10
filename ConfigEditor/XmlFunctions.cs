using System.ComponentModel;
using System.Xml;

namespace ConfigEditor
{
    public static class XmlFunctions
    {
        private static String Path = $"{Directory.GetCurrentDirectory()}//config.xml";

        public static BindingList<Machine> OpenConfigData(string path)
        {
            //if (path != null && !File.Exists(path))
            //{
            //    WriteXml(true);
            //}


            var machines = new BindingList<Machine>();

            var servers = ReadServers(path);
            foreach (var server in servers)
            {
                machines.Add(server);
            }

            var clients = ReadClients(path);
            foreach (var client in clients)
            {
                machines.Add(client);
            }

            return machines;
        }

        private static List<Server> ReadServers(string path)
        {
            var serverList = new List<Server>();
            XmlDocument document = new XmlDocument();
            document.PreserveWhitespace = false;
            document.Load(path);
            

            var nodes = document.SelectNodes("Config/Servers/Server");

            foreach (XmlElement node in nodes)
            {
        
                var server = new Server(node.GetAttribute("path"), 
                    node.ChildNodes.OfType<XmlElement>()
                    .Where(e => e.Name == "ConnectionString")?
                    .FirstOrDefault()?.InnerText ?? "");
                              

                serverList.Add(server);
            }

            return serverList;
        }




        private static List<Client> ReadClients(string path)
        {
            var clientList = new List<Client>();
            XmlDocument document = new XmlDocument();
            document.PreserveWhitespace = false;
            document.Load(path);


            var nodes = document.SelectNodes("Config/Clients/Client");

            foreach (XmlElement node in nodes)
            {
                var isTsClient = node.ChildNodes.OfType<XmlElement>()
                    .Where(e => e.Name == "TSClient")?
                    .FirstOrDefault()?.InnerText ?? "´false";

                var client = new Client(node.GetAttribute("path"), Boolean.Parse(isTsClient));

                clientList.Add(client);
            }

            return clientList;
        }



        public static void WriteXml(bool empty)
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