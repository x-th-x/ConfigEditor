using System.ComponentModel;

namespace ConfigEditor
{
    public partial class MainForm : Form
    {
        BindingSource bindingSourceServers = new BindingSource();
        BindingSource bindingSourceClients = new BindingSource();
        BindingList<Machine> machines = new BindingList<Machine>();

        public MainForm()
        {
            InitializeComponent();

        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                machines = XmlFunctions.OpenConfigData(openFileDialog1.FileName);
                bindingSourceServers.DataSource = machines.OfType<Server>();
                bindingSourceClients.DataSource = machines.OfType<Client>();
                lbServer.DataSource = bindingSourceServers;
                lbServer.DisplayMember = "Path";
                lbClients.DataSource = bindingSourceClients;
                lbClients.DisplayMember = "Path";

                txtServer.DataBindings.Add("Text", bindingSourceServers, "Path", false, DataSourceUpdateMode.OnPropertyChanged);
                textBox1.DataBindings.Add("Text", bindingSourceServers, "ConnectionString", false, DataSourceUpdateMode.OnPropertyChanged);
                txtClient.DataBindings.Add("Text", bindingSourceClients, "Path", false, DataSourceUpdateMode.OnPropertyChanged);
               

                //bindingSourceServers.ResetBindings(false);
                //bindingSourceClients.ResetBindings(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSourceServers.Remove(lbServer.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSourceClients.Remove(lbClients.SelectedItem);
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            if (txtServer.Text != "")
            {
                bindingSourceServers.Add(new Server(txtServer.Text, textBox1.Text));
            }
        }


    }
}