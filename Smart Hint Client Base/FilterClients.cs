using Smart_Hint_Client_Base.dbClientsDataSetTableAdapters;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Hint_Client_Base
{
    public partial class FilterClients : Form
    {
        public FilterClients()
        {
            InitializeComponent();
        }

        string name, email, phone;

        MainMenu mainMenu;

        bool x;

        DataTable columns;

        private void FilterClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbClientsDataSet.ClientTable' table. You can move, or remove it, as needed.
            this.clientTableTableAdapter.Fill(this.dbClientsDataSet.ClientTable);

        }

        DataRow[] rows, allRows;

        private void button_submitFilter_Click(object sender, EventArgs e)
        {
            if (input_name.Text.Length > 1)
            {
                name = input_name.Text;
            }
            else
            {
                name = null;
            }

            if (input_email.Text.Length > 3)
            {
                email = input_email.Text;
            }

            if (input_phone.Text.Length == 11)
            {
                phone = input_phone.Text;
            }


            mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            columns = mainMenu.activeTable;
            allRows = columns.Select();

            if (name != null)
            {
                rows = columns.Select("Name = " + "'" + name + "'");
                foreach (DataRow row in allRows)
                {
                    if (rows.Contains(row))
                    {

                    }
                    else
                    {
                        row.Delete();
                    }
                }
            }

            if (email != null)
            {
                rows = columns.Select("Email = " + "'" + email + "'");
                foreach (DataRow row in allRows)
                {
                    if (rows.Contains(row))
                    {

                    }
                    else
                    {
                        row.Delete();
                    }
                }
            }

            if (phone != null)
            {
                rows = columns.Select("Phone = " + "'" + phone + "'");
            foreach (DataRow row in allRows)
            {
                if (rows.Contains(row))
                {

                }
                else
                {
                    row.Delete();
                }
            }
            }

            if (input_blockedClient.Checked) //Nao usaria esse metodo pra checar porem seguindo documentacao, esse campo deveria ser opcional
            {
                rows = columns.Select("blockedClient = " + "'" + "Sim" + "'");
                foreach (DataRow row in allRows)
                {
                    if (rows.Contains(row))
                    {

                    }
                    else
                    {
                        row.Delete();
                    }
                }
            }
            else
            {
                rows = columns.Select("blockedClient = " + "'" + "Nao" + "'");
                foreach (DataRow row in allRows)
                {
                    if (rows.Contains(row))
                    {

                    }
                    else
                    {
                        row.Delete();
                    }
                }
            }
            Debug.WriteLine(input_registerDate.Value.ToString());

            if (input_registerDate.Value != DateTime.Today)
            {
                rows = columns.Select("registerDate = " + "'" + "2023-12-20" + "'"); //hardcoded, fix later
                foreach (DataRow row in allRows)
                {
                    if (rows.Contains(row))
                    {

                    }
                    else
                    {
                        row.Delete();
                    }
                }
            }

            //dataGridView1.DataSource = newData;
            Close();
        }
    }
}
