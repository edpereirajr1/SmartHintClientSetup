namespace Smart_Hint_Client_Base
{
    partial class MainMenu
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
            this.button_AddClient = new System.Windows.Forms.Button();
            this.button_FilterClients = new System.Windows.Forms.Button();
            this.input_resetFilter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockedClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoEstadualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbClientsDataSet = new Smart_Hint_Client_Base.dbClientsDataSet();
            this.clientTableTableAdapter = new Smart_Hint_Client_Base.dbClientsDataSetTableAdapters.ClientTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbClientsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddClient
            // 
            this.button_AddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddClient.Location = new System.Drawing.Point(787, 12);
            this.button_AddClient.Name = "button_AddClient";
            this.button_AddClient.Size = new System.Drawing.Size(200, 50);
            this.button_AddClient.TabIndex = 1;
            this.button_AddClient.Text = "Adicionar Novo Cliente";
            this.button_AddClient.UseVisualStyleBackColor = true;
            this.button_AddClient.Click += new System.EventHandler(this.button_AddClient_Click);
            // 
            // button_FilterClients
            // 
            this.button_FilterClients.Location = new System.Drawing.Point(16, 12);
            this.button_FilterClients.Name = "button_FilterClients";
            this.button_FilterClients.Size = new System.Drawing.Size(200, 50);
            this.button_FilterClients.TabIndex = 2;
            this.button_FilterClients.Text = "Filtrar Clientes Existentes";
            this.button_FilterClients.UseVisualStyleBackColor = true;
            this.button_FilterClients.Click += new System.EventHandler(this.button_FilterClients_Click);
            // 
            // input_resetFilter
            // 
            this.input_resetFilter.Location = new System.Drawing.Point(400, 12);
            this.input_resetFilter.Name = "input_resetFilter";
            this.input_resetFilter.Size = new System.Drawing.Size(200, 50);
            this.input_resetFilter.TabIndex = 4;
            this.input_resetFilter.Text = "Limpar Filtros";
            this.input_resetFilter.UseVisualStyleBackColor = true;
            this.input_resetFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn,
            this.blockedClientDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.inscricaoEstadualDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.clientPasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(971, 500);
            this.dataGridView1.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "registerDate";
            this.registerDateDataGridViewTextBoxColumn.HeaderText = "Data de Cadastro";
            this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // blockedClientDataGridViewTextBoxColumn
            // 
            this.blockedClientDataGridViewTextBoxColumn.DataPropertyName = "blockedClient";
            this.blockedClientDataGridViewTextBoxColumn.HeaderText = "Cliente Bloqueado";
            this.blockedClientDataGridViewTextBoxColumn.Name = "blockedClientDataGridViewTextBoxColumn";
            this.blockedClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "clientType";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "Tipo de Cliente";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscricaoEstadualDataGridViewTextBoxColumn
            // 
            this.inscricaoEstadualDataGridViewTextBoxColumn.DataPropertyName = "inscricaoEstadual";
            this.inscricaoEstadualDataGridViewTextBoxColumn.HeaderText = "Inscricao Estadual";
            this.inscricaoEstadualDataGridViewTextBoxColumn.Name = "inscricaoEstadualDataGridViewTextBoxColumn";
            this.inscricaoEstadualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "birthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientPasswordDataGridViewTextBoxColumn
            // 
            this.clientPasswordDataGridViewTextBoxColumn.DataPropertyName = "clientPassword";
            this.clientPasswordDataGridViewTextBoxColumn.HeaderText = "Senha do Cliente";
            this.clientPasswordDataGridViewTextBoxColumn.Name = "clientPasswordDataGridViewTextBoxColumn";
            this.clientPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientTableBindingSource
            // 
            this.clientTableBindingSource.DataMember = "ClientTable";
            this.clientTableBindingSource.DataSource = this.dbClientsDataSet;
            this.clientTableBindingSource.CurrentChanged += new System.EventHandler(this.clientTableBindingSource_CurrentChanged);
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.input_resetFilter);
            this.Controls.Add(this.button_FilterClients);
            this.Controls.Add(this.button_AddClient);
            this.Name = "MainMenu";
            this.Text = "Consulte os seus Clientes cadastrados na sua loja ou realize o cadastro de novos " +
    "Clientes";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbClientsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_AddClient;
        private System.Windows.Forms.Button button_FilterClients;
        private System.Windows.Forms.Button input_resetFilter;
        private dbClientsDataSet dbClientsDataSet;
        private System.Windows.Forms.BindingSource clientTableBindingSource;
        private dbClientsDataSetTableAdapters.ClientTableTableAdapter clientTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockedClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoEstadualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPasswordDataGridViewTextBoxColumn;
    }
}

