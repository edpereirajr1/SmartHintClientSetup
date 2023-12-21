using Smart_Hint_Client_Base.dbClientsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Smart_Hint_Client_Base
{
    public partial class MainMenu : Form
    {
        public DataSet dbDataSet;

        public DataTable activeTable;
        public MainMenu()
        {
            InitializeComponent();
            dbDataSet = dbClientsDataSet;
            activeTable = dbClientsDataSet.ClientTable;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.clientTableTableAdapter.Fill(this.dbClientsDataSet.ClientTable);
        }

        private void button_AddClient_Click(object sender, EventArgs e)
        {
            //Ideally should check if other ones are open and close it
            Form addClient = new AddClient(); //Makes sure it is empty on new use
            addClient.Show();
            RefreshTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshTable();
            activeTable = dbClientsDataSet.ClientTable;
        }

        public void RefreshTable()
        {
            this.clientTableTableAdapter.Fill(this.dbClientsDataSet.ClientTable);

        }

        private void button_FilterClients_Click(object sender, EventArgs e)
        {
            Form filterClients = new FilterClients(); //Makes sure it is empty on new use
            filterClients.Show();
        }

        private void clientTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
