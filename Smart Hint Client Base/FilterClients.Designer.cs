namespace Smart_Hint_Client_Base
{
    partial class FilterClients
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
            this.label1 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.input_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.input_registerDate = new System.Windows.Forms.DateTimePicker();
            this.label_registerDate = new System.Windows.Forms.Label();
            this.input_blockedClient = new System.Windows.Forms.CheckBox();
            this.clientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbClientsDataSet = new Smart_Hint_Client_Base.dbClientsDataSet();
            this.button_submitFilter = new System.Windows.Forms.Button();
            this.dbClientsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableTableAdapter = new Smart_Hint_Client_Base.dbClientsDataSetTableAdapters.ClientTableTableAdapter();
            this.filterClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbClientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbClientsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(761, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite os Possiveis Filtros e Clique em Filtrar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(195, 50);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(600, 20);
            this.input_name.TabIndex = 18;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_name.Location = new System.Drawing.Point(12, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(176, 25);
            this.label_name.TabIndex = 17;
            this.label_name.Text = "Nome/Razão Social:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(195, 90);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(600, 20);
            this.input_email.TabIndex = 20;
            // 
            // label_email
            // 
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_email.Location = new System.Drawing.Point(15, 90);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(173, 25);
            this.label_email.TabIndex = 19;
            this.label_email.Text = "Email:";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // input_phone
            // 
            this.input_phone.Location = new System.Drawing.Point(195, 130);
            this.input_phone.Name = "input_phone";
            this.input_phone.Size = new System.Drawing.Size(600, 20);
            this.input_phone.TabIndex = 22;
            // 
            // label_phone
            // 
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_phone.Location = new System.Drawing.Point(15, 130);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(173, 25);
            this.label_phone.TabIndex = 21;
            this.label_phone.Text = "Telefone:";
            this.label_phone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // input_registerDate
            // 
            this.input_registerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_registerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_registerDate.Location = new System.Drawing.Point(195, 170);
            this.input_registerDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.input_registerDate.Name = "input_registerDate";
            this.input_registerDate.Size = new System.Drawing.Size(121, 23);
            this.input_registerDate.TabIndex = 24;
            // 
            // label_registerDate
            // 
            this.label_registerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_registerDate.Location = new System.Drawing.Point(56, 170);
            this.label_registerDate.Name = "label_registerDate";
            this.label_registerDate.Size = new System.Drawing.Size(260, 25);
            this.label_registerDate.TabIndex = 23;
            this.label_registerDate.Text = "Data de Cadastro:";
            // 
            // input_blockedClient
            // 
            this.input_blockedClient.AutoSize = true;
            this.input_blockedClient.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.input_blockedClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.input_blockedClient.Location = new System.Drawing.Point(386, 171);
            this.input_blockedClient.Name = "input_blockedClient";
            this.input_blockedClient.Size = new System.Drawing.Size(162, 24);
            this.input_blockedClient.TabIndex = 27;
            this.input_blockedClient.Text = "Cliente Bloqueado:";
            this.input_blockedClient.UseVisualStyleBackColor = true;
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
            // button_submitFilter
            // 
            this.button_submitFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_submitFilter.Location = new System.Drawing.Point(595, 170);
            this.button_submitFilter.Name = "button_submitFilter";
            this.button_submitFilter.Size = new System.Drawing.Size(200, 50);
            this.button_submitFilter.TabIndex = 29;
            this.button_submitFilter.Text = "Filtrar";
            this.button_submitFilter.UseVisualStyleBackColor = true;
            this.button_submitFilter.Click += new System.EventHandler(this.button_submitFilter_Click);
            // 
            // dbClientsDataSetBindingSource
            // 
            this.dbClientsDataSetBindingSource.DataSource = this.dbClientsDataSet;
            this.dbClientsDataSetBindingSource.Position = 0;
            // 
            // clientTableTableAdapter
            // 
            this.clientTableTableAdapter.ClearBeforeFill = true;
            // 
            // filterClientsBindingSource
            // 
            this.filterClientsBindingSource.DataSource = typeof(Smart_Hint_Client_Base.FilterClients);
            // 
            // FilterClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 243);
            this.Controls.Add(this.button_submitFilter);
            this.Controls.Add(this.input_blockedClient);
            this.Controls.Add(this.input_registerDate);
            this.Controls.Add(this.label_registerDate);
            this.Controls.Add(this.input_phone);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Name = "FilterClients";
            this.Text = "Filtrar Clientes Cadastrados";
            this.Load += new System.EventHandler(this.FilterClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbClientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbClientsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterClientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox input_phone;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.DateTimePicker input_registerDate;
        private System.Windows.Forms.Label label_registerDate;
        private System.Windows.Forms.CheckBox input_blockedClient;
        private System.Windows.Forms.Button button_submitFilter;
        private System.Windows.Forms.BindingSource filterClientsBindingSource;
        private dbClientsDataSet dbClientsDataSet;
        private System.Windows.Forms.BindingSource dbClientsDataSetBindingSource;
        private System.Windows.Forms.BindingSource clientTableBindingSource;
        private dbClientsDataSetTableAdapters.ClientTableTableAdapter clientTableTableAdapter;
    }
}