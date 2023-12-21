using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FluentValidation.Results;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Smart_Hint_Client_Base
{
    public partial class AddClient : Form
    {
        BindingList<string> errors = new BindingList<string>();

        public AddClient()
        {
            InitializeComponent();
            input_registerDate.Text = DateTime.Now.Date.ToString();
            mainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
        }

        private void input_personType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (input_personType.SelectedIndex) //I prefer to use index here but can also use strings
            {
                case 0: //Fisica
                    label_cpf.Text = "Insira o CPF do Cliente:";
                    label_gender.Visible = true;
                    input_gender.Visible = true;
                    label_birthDate.Visible = true;
                    input_birthDate.Visible = true;
                    input_isentoInscEstadual.Visible = true;
                    input_cpfOrCnpj.Mask = "###-###-###-##";
                    personTypeRefresh = "Fisica";
                    break;
                case 1: //Juridica
                    label_cpf.Text = "Insira o CNPJ do Cliente:";
                    label_gender.Visible = false;
                    input_gender.Visible = false;
                    label_birthDate.Visible = false;
                    input_birthDate.Visible = false;
                    input_isentoInscEstadual.Checked = false;
                    input_isentoInscEstadual.Visible = false;
                    input_inscricaoEstadual.Enabled = true;
                    input_cpfOrCnpj.Mask = "##.###.###/####-##";
                    personTypeRefresh = "Juridica";
                    break;
            }
        }

        public string personTypeRefresh;

        private void input_isentoInscEstadual_CheckedChanged(object sender, EventArgs e)
        {
            switch (input_isentoInscEstadual.Checked)
            {
                case true:
                    input_inscricaoEstadual.Enabled = false;
                    break;
                case false:
                    input_inscricaoEstadual.Enabled = true;
                    break;
            }
        }

        private void button_returnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        string email;
        string cpf;
        string cnpj;
        string inscEstadual;

        private void button_submitRegister_Click(object sender, EventArgs e)
        {
            errors.Clear(); //should not be necessary on first use


            AddClient client = new AddClient();

            //Same order as the UI
            string name = input_name.Text;
            email = input_email.Text;
            string tel = input_phone.Text;
            DateTime registerDate = input_registerDate.Value;
            string personType = personTypeRefresh;
            cpf = input_cpfOrCnpj.Text;
            cnpj = input_cpfOrCnpj.Text;
            bool isentoInscEstadual = input_isentoInscEstadual.Checked;
            inscEstadual = input_inscricaoEstadual.Text;
            string gender = genderRefresh;
            DateTime birthDate = input_birthDate.Value;
            bool blockedClient = input_blockedClient.Checked; //checked = true;
            string password = input_password.Text;
            string passwordCheck = input_passwordCheck.Text;

            Debug.WriteLine(cpf);
            Debug.WriteLine(tel);

            ClientValidator validator = new ClientValidator(personType, isentoInscEstadual);

            //Validate apenas os valores que sao necessarios de acordo com o requisito do cliente (4 tipos)
            ValidationResult results = validator.Validate(AddClient.New(name, email, tel, registerDate, personType, cpf, cnpj, isentoInscEstadual, inscEstadual, gender, birthDate, blockedClient, password, passwordCheck));

            if (results.IsValid == false) //Erro no cadastro
            {
                foreach (ValidationFailure error in results.Errors) //Showing every error just in case, I would show just the first error as a preference
                    MessageBox.Show($"{error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else //Validado
            {
                columns = mainMenu.activeTable;
                rows = columns.Select();
                if (!IsEmailUsed())
                {
                    if (input_blockedClient.Checked)
                    {
                        blockedClientToTable = "Sim";
                    }
                    else
                    {
                        blockedClientToTable = "Nao";
                    }
                    switch (personTypeRefresh)
                    {
                        case "Fisica":
                            if (IsCpfUsed())
                            {
                                return;
                            }
                            else
                            {
                                if (input_isentoInscEstadual.Checked) //nao adicionar insc Estadual
                                {

                                    clientTableTableAdapter.Insert(name, email, tel, registerDate, blockedClientToTable, personType, null, cpf, null, gender, birthDate, password);
                                }
                                else
                                {
                                    if (IsInscEstUsed())
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        clientTableTableAdapter.Insert(name, email, tel, registerDate, blockedClientToTable, personType, null, cpf, inscEstadual, gender, birthDate, password);
                                    }
                                }
                            }
                            break;
                        case "Juridica":
                            if (IsCnpjUsed() || IsInscEstUsed())
                            {
                                return;
                            }
                            else
                            {
                                clientTableTableAdapter.Insert(name, email, tel, registerDate, blockedClientToTable, personType, cnpj, null, inscEstadual, null, registerDate, password);
                            }
                            break;
                    }
                    //clientTableTableAdapter.Insert(name, email, tel, registerDate, 0, personType, cnpj, cpf, inscEstadual, gender, birthDate, password);

                    mainMenu.RefreshTable();
                    //Add client id++ here
                    MessageBox.Show("Cliente Registrado com Sucesso!", "Cliente Validado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }
            }
        }

        MainMenu mainMenu;

        bool x;

        DataTable columns;
        DataRow[] rows;
        private bool IsEmailUsed()
        {
            //Check email, cpf, cnpj and insc estadual (as needed)

            for (int i = 0; i < rows.Length; i++)
            {
                string v = rows[i]["email"].ToString();

                if (email == v)
                {
                    x = true;
                    MessageBox.Show($"Email ja cadastrado para outro Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    x = false;
                }
            }
            
            return x;
        }

        private bool IsCnpjUsed()
        {
            for (int i = 0; i < rows.Length; i++)
            {
                string v = rows[i]["cnpj"].ToString();

                if (cnpj == v)
                {
                    x = true;
                    MessageBox.Show($"CNPJ ja cadastrado para outro Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    x = false;
                }
            }

            return x;
        }

        private bool IsCpfUsed()
        {
            for (int i = 0; i < rows.Length; i++)
            {
                string v = rows[i]["cpf"].ToString();

                if (cpf == v)
                {
                    x = true;
                    MessageBox.Show($"CPF ja cadastrado para outro Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    x = false;
                }
            }

            return x;
        }

        private bool IsInscEstUsed()
        {
            for (int i = 0; i < rows.Length; i++)
            {
                string v = rows[i]["inscricaoEstadual"].ToString();

                if (inscEstadual == v)
                {
                    x = true;
                    MessageBox.Show($"Esta Inscrição Estadual já esta cadastrada para outro Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    x = false;
                }
            }

            return x;
        }

        public string blockedClientToTable;

        public string ClientName, Email, Tel, PersonType, Password, PasswordCheck;

        private void input_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (input_gender.SelectedIndex) //I prefer to use index here but can also use strings
            {
                case 0:
                    genderRefresh = "Feminino";
                    break;
                case 1:
                    genderRefresh = "Masculino";
                    break;
                case 2:
                    genderRefresh = "Outro";
                    break;
            }
        }

        public string genderRefresh;

        public string Cpf, Cnpj, InscEstadual, Gender;

        public bool? IsentoInsEstadual, BlockedClient;

        public DateTime RegisterDate, BirthDate;

        public static AddClient New(string name, string email, string tel, DateTime registerDate, string personType, string cpf, string cnpj, bool isentoInscEstadual, string inscEstadual, string gender, DateTime birthDate, bool blockedClient, string password, string passwordCheck)
        {
            return new AddClient
            {
                ClientName = name,
                Email = email,
                Tel = tel,
                RegisterDate = registerDate,
                PersonType = personType,
                Cpf = cpf,
                Cnpj = cnpj,
                IsentoInsEstadual = isentoInscEstadual,
                InscEstadual = inscEstadual,
                Gender = gender,
                BirthDate = birthDate,
                BlockedClient = blockedClient,
                Password = password,
                PasswordCheck = passwordCheck
            };
        }
    }
}
