namespace Smart_Hint_Client_Base
{
    partial class AddClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_returnMainMenu = new System.Windows.Forms.Button();
            this.button_submitRegister = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_personType = new System.Windows.Forms.Label();
            this.label_cpf = new System.Windows.Forms.Label();
            this.label_ie = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_registerDate = new System.Windows.Forms.Label();
            this.label_birthDate = new System.Windows.Forms.Label();
            this.input_registerDate = new System.Windows.Forms.DateTimePicker();
            this.input_birthDate = new System.Windows.Forms.DateTimePicker();
            this.input_personType = new System.Windows.Forms.ComboBox();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_inscricaoEstadual = new System.Windows.Forms.TextBox();
            this.input_gender = new System.Windows.Forms.ComboBox();
            this.input_blockedClient = new System.Windows.Forms.CheckBox();
            this.input_isentoInscEstadual = new System.Windows.Forms.CheckBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.input_passwordCheck = new System.Windows.Forms.TextBox();
            this.label_passwordCheck = new System.Windows.Forms.Label();
            this.clientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbClientsDataSet = new Smart_Hint_Client_Base.dbClientsDataSet();
            this.clientTableTableAdapter = new Smart_Hint_Client_Base.dbClientsDataSetTableAdapters.ClientTableTableAdapter();
            this.input_phone = new System.Windows.Forms.MaskedTextBox();
            this.input_cpfOrCnpj = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbClientsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_returnMainMenu
            // 
            this.button_returnMainMenu.Location = new System.Drawing.Point(16, 412);
            this.button_returnMainMenu.Name = "button_returnMainMenu";
            this.button_returnMainMenu.Size = new System.Drawing.Size(200, 50);
            this.button_returnMainMenu.TabIndex = 15;
            this.button_returnMainMenu.Text = "Voltar";
            this.button_returnMainMenu.UseVisualStyleBackColor = true;
            this.button_returnMainMenu.Click += new System.EventHandler(this.button_returnMainMenu_Click);
            // 
            // button_submitRegister
            // 
            this.button_submitRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_submitRegister.Location = new System.Drawing.Point(787, 412);
            this.button_submitRegister.Name = "button_submitRegister";
            this.button_submitRegister.Size = new System.Drawing.Size(200, 50);
            this.button_submitRegister.TabIndex = 14;
            this.button_submitRegister.Text = "Finalizar Cadastro";
            this.button_submitRegister.UseVisualStyleBackColor = true;
            this.button_submitRegister.Click += new System.EventHandler(this.button_submitRegister_Click);
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_name.Location = new System.Drawing.Point(16, 21);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(260, 25);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Nome do Cliente/Razão Social:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_email
            // 
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_email.Location = new System.Drawing.Point(16, 61);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(260, 25);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "E-mail do Cliente:";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_phone
            // 
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_phone.Location = new System.Drawing.Point(16, 101);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(260, 25);
            this.label_phone.TabIndex = 4;
            this.label_phone.Text = "Telefone do Cliente:";
            this.label_phone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_personType
            // 
            this.label_personType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_personType.Location = new System.Drawing.Point(16, 141);
            this.label_personType.Name = "label_personType";
            this.label_personType.Size = new System.Drawing.Size(260, 25);
            this.label_personType.TabIndex = 5;
            this.label_personType.Text = "Selecione o tipo de Pessoa:";
            this.label_personType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_cpf
            // 
            this.label_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_cpf.Location = new System.Drawing.Point(16, 181);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(260, 25);
            this.label_cpf.TabIndex = 6;
            this.label_cpf.Text = "Insira o CPF ou o CNPJ do Cliente:";
            this.label_cpf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_ie
            // 
            this.label_ie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_ie.Location = new System.Drawing.Point(16, 221);
            this.label_ie.Name = "label_ie";
            this.label_ie.Size = new System.Drawing.Size(260, 25);
            this.label_ie.TabIndex = 7;
            this.label_ie.Text = "Inscrição Estadual do Cliente:";
            this.label_ie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_gender
            // 
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_gender.Location = new System.Drawing.Point(16, 261);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(260, 25);
            this.label_gender.TabIndex = 8;
            this.label_gender.Text = "Selecione o gênero do Cliente:";
            this.label_gender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_registerDate
            // 
            this.label_registerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_registerDate.Location = new System.Drawing.Point(722, 320);
            this.label_registerDate.Name = "label_registerDate";
            this.label_registerDate.Size = new System.Drawing.Size(260, 25);
            this.label_registerDate.TabIndex = 9;
            this.label_registerDate.Text = "Data de Cadastro:";
            // 
            // label_birthDate
            // 
            this.label_birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_birthDate.Location = new System.Drawing.Point(16, 301);
            this.label_birthDate.Name = "label_birthDate";
            this.label_birthDate.Size = new System.Drawing.Size(260, 25);
            this.label_birthDate.TabIndex = 10;
            this.label_birthDate.Text = "Data de nascimento do Cliente:";
            this.label_birthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // input_registerDate
            // 
            this.input_registerDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientTableBindingSource, "registerDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.input_registerDate.Enabled = false;
            this.input_registerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_registerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_registerDate.Location = new System.Drawing.Point(866, 320);
            this.input_registerDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.input_registerDate.Name = "input_registerDate";
            this.input_registerDate.Size = new System.Drawing.Size(121, 23);
            this.input_registerDate.TabIndex = 12;
            // 
            // input_birthDate
            // 
            this.input_birthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientTableBindingSource, "birthDate", true));
            this.input_birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_birthDate.Location = new System.Drawing.Point(282, 299);
            this.input_birthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.input_birthDate.Name = "input_birthDate";
            this.input_birthDate.Size = new System.Drawing.Size(121, 23);
            this.input_birthDate.TabIndex = 9;
            // 
            // input_personType
            // 
            this.input_personType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientTableBindingSource, "clientType", true));
            this.input_personType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_personType.FormattingEnabled = true;
            this.input_personType.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.input_personType.Location = new System.Drawing.Point(282, 141);
            this.input_personType.Name = "input_personType";
            this.input_personType.Size = new System.Drawing.Size(121, 24);
            this.input_personType.TabIndex = 4;
            this.input_personType.SelectedIndexChanged += new System.EventHandler(this.input_personType_SelectedIndexChanged);
            // 
            // input_name
            // 
            this.input_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientTableBindingSource, "name", true));
            this.input_name.Location = new System.Drawing.Point(283, 21);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(600, 20);
            this.input_name.TabIndex = 1;
            // 
            // input_email
            // 
            this.input_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientTableBindingSource, "email", true));
            this.input_email.Location = new System.Drawing.Point(283, 61);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(600, 20);
            this.input_email.TabIndex = 2;
            // 
            // input_inscricaoEstadual
            // 
            this.input_inscricaoEstadual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientTableBindingSource, "inscricaoEstadual", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.input_inscricaoEstadual.Location = new System.Drawing.Point(283, 221);
            this.input_inscricaoEstadual.Name = "input_inscricaoEstadual";
            this.input_inscricaoEstadual.Size = new System.Drawing.Size(200, 20);
            this.input_inscricaoEstadual.TabIndex = 6;
            // 
            // input_gender
            // 
            this.input_gender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientTableBindingSource, "gender", true));
            this.input_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_gender.FormattingEnabled = true;
            this.input_gender.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outro"});
            this.input_gender.Location = new System.Drawing.Point(282, 261);
            this.input_gender.Name = "input_gender";
            this.input_gender.Size = new System.Drawing.Size(121, 24);
            this.input_gender.TabIndex = 8;
            this.input_gender.SelectedIndexChanged += new System.EventHandler(this.input_gender_SelectedIndexChanged);
            // 
            // input_blockedClient
            // 
            this.input_blockedClient.AutoSize = true;
            this.input_blockedClient.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.input_blockedClient.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientTableBindingSource, "blockedClient", true));
            this.input_blockedClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_blockedClient.Location = new System.Drawing.Point(712, 360);
            this.input_blockedClient.Name = "input_blockedClient";
            this.input_blockedClient.Size = new System.Drawing.Size(275, 24);
            this.input_blockedClient.TabIndex = 13;
            this.input_blockedClient.Text = "Bloquear Acesso do Cliente a Loja:";
            this.input_blockedClient.UseVisualStyleBackColor = true;
            // 
            // input_isentoInscEstadual
            // 
            this.input_isentoInscEstadual.AutoSize = true;
            this.input_isentoInscEstadual.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.input_isentoInscEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_isentoInscEstadual.Location = new System.Drawing.Point(500, 220);
            this.input_isentoInscEstadual.Name = "input_isentoInscEstadual";
            this.input_isentoInscEstadual.Size = new System.Drawing.Size(234, 24);
            this.input_isentoInscEstadual.TabIndex = 7;
            this.input_isentoInscEstadual.Text = "Isento de Inscricao Estadual:";
            this.input_isentoInscEstadual.UseVisualStyleBackColor = true;
            this.input_isentoInscEstadual.CheckedChanged += new System.EventHandler(this.input_isentoInscEstadual_CheckedChanged);
            // 
            // input_password
            // 
            this.input_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientTableBindingSource, "clientPassword", true));
            this.input_password.Location = new System.Drawing.Point(282, 340);
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '*';
            this.input_password.Size = new System.Drawing.Size(200, 20);
            this.input_password.TabIndex = 10;
            // 
            // label_password
            // 
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_password.Location = new System.Drawing.Point(16, 340);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(260, 25);
            this.label_password.TabIndex = 23;
            this.label_password.Text = "Senha do Cliente:";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // input_passwordCheck
            // 
            this.input_passwordCheck.Location = new System.Drawing.Point(283, 380);
            this.input_passwordCheck.Name = "input_passwordCheck";
            this.input_passwordCheck.PasswordChar = '*';
            this.input_passwordCheck.Size = new System.Drawing.Size(200, 20);
            this.input_passwordCheck.TabIndex = 11;
            // 
            // label_passwordCheck
            // 
            this.label_passwordCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_passwordCheck.Location = new System.Drawing.Point(16, 380);
            this.label_passwordCheck.Name = "label_passwordCheck";
            this.label_passwordCheck.Size = new System.Drawing.Size(260, 25);
            this.label_passwordCheck.TabIndex = 25;
            this.label_passwordCheck.Text = "Confirme a Senha do Cliente:";
            this.label_passwordCheck.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // clientTableBindingSource
            // 
            this.clientTableBindingSource.DataMember = "ClientTable";
            this.clientTableBindingSource.DataSource = this.dbClientsDataSet;
            // 
            // dbClientsDataSet
            // 
            this.dbClientsDataSet.DataSetName = "dbClientsDataSet";
            this.dbClientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableTableAdapter
            // 
            this.clientTableTableAdapter.ClearBeforeFill = true;
            // 
            // input_phone
            // 
            this.input_phone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.input_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientTableBindingSource, "phone", true));
            this.input_phone.Location = new System.Drawing.Point(282, 101);
            this.input_phone.Mask = "(00)00000-0000";
            this.input_phone.Name = "input_phone";
            this.input_phone.Size = new System.Drawing.Size(200, 20);
            this.input_phone.TabIndex = 3;
            this.input_phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // input_cpfOrCnpj
            // 
            this.input_cpfOrCnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.input_cpfOrCnpj.Location = new System.Drawing.Point(282, 180);
            this.input_cpfOrCnpj.Mask = "000.000.000-00";
            this.input_cpfOrCnpj.Name = "input_cpfOrCnpj";
            this.input_cpfOrCnpj.Size = new System.Drawing.Size(200, 20);
            this.input_cpfOrCnpj.TabIndex = 5;
            this.input_cpfOrCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.input_cpfOrCnpj);
            this.Controls.Add(this.input_phone);
            this.Controls.Add(this.input_passwordCheck);
            this.Controls.Add(this.label_passwordCheck);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.input_isentoInscEstadual);
            this.Controls.Add(this.input_blockedClient);
            this.Controls.Add(this.input_gender);
            this.Controls.Add(this.input_inscricaoEstadual);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.input_personType);
            this.Controls.Add(this.input_birthDate);
            this.Controls.Add(this.input_registerDate);
            this.Controls.Add(this.label_birthDate);
            this.Controls.Add(this.label_registerDate);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_ie);
            this.Controls.Add(this.label_cpf);
            this.Controls.Add(this.label_personType);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_submitRegister);
            this.Controls.Add(this.button_returnMainMenu);
            this.Name = "AddClient";
            this.Text = "Cadastro de Novo Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbClientsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_returnMainMenu;
        private System.Windows.Forms.Button button_submitRegister;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_personType;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Label label_ie;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_registerDate;
        private System.Windows.Forms.Label label_birthDate;
        private System.Windows.Forms.DateTimePicker input_registerDate;
        private System.Windows.Forms.DateTimePicker input_birthDate;
        private System.Windows.Forms.ComboBox input_personType;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_inscricaoEstadual;
        private System.Windows.Forms.ComboBox input_gender;
        private System.Windows.Forms.CheckBox input_blockedClient;
        private System.Windows.Forms.CheckBox input_isentoInscEstadual;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox input_passwordCheck;
        private System.Windows.Forms.Label label_passwordCheck;
        private dbClientsDataSet dbClientsDataSet;
        private System.Windows.Forms.BindingSource clientTableBindingSource;
        private dbClientsDataSetTableAdapters.ClientTableTableAdapter clientTableTableAdapter;
        private System.Windows.Forms.MaskedTextBox input_phone;
        private System.Windows.Forms.MaskedTextBox input_cpfOrCnpj;
    }
}