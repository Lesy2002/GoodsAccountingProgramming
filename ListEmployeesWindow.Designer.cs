
namespace GoodsAccountingPractice1
{
    partial class ListEmployeesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListEmployeesWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsAccountingDataSet1 = new GoodsAccountingPractice1.GoodsAccountingDataSet1();
            this.usersTableAdapter = new GoodsAccountingPractice1.GoodsAccountingDataSet1TableAdapters.UsersTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.goodsAccountingDataSet2 = new GoodsAccountingPractice1.GoodsAccountingDataSet2();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new GoodsAccountingPractice1.GoodsAccountingDataSet2TableAdapters.UsersTableAdapter();
            this.listUsersGrid = new System.Windows.Forms.DataGridView();
            this.idUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirhdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.goodsAccountingDataSet3 = new GoodsAccountingPractice1.GoodsAccountingDataSet3();
            this.usersTableAdapter2 = new GoodsAccountingPractice1.GoodsAccountingDataSet3TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsAccountingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsAccountingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUsersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsAccountingDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список сотрудников";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodsAccountingPractice1.Properties.Resources.png_clipart_user_computer_icons_sprite_sprite_blue_logo__1___1_;
            this.pictureBox1.Location = new System.Drawing.Point(343, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(382, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(28, 25);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "Л";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.goodsAccountingDataSet1;
            // 
            // goodsAccountingDataSet1
            // 
            this.goodsAccountingDataSet1.DataSetName = "GoodsAccountingDataSet1";
            this.goodsAccountingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Location = new System.Drawing.Point(1143, 368);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(132, 45);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addBtn.Location = new System.Drawing.Point(991, 368);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 45);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editBtn.ForeColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(827, 368);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(140, 45);
            this.editBtn.TabIndex = 19;
            this.editBtn.Text = "Редактировать";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(20, 368);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 45);
            this.exitBtn.TabIndex = 20;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // goodsAccountingDataSet2
            // 
            this.goodsAccountingDataSet2.DataSetName = "GoodsAccountingDataSet2";
            this.goodsAccountingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.goodsAccountingDataSet2;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // listUsersGrid
            // 
            this.listUsersGrid.AutoGenerateColumns = false;
            this.listUsersGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listUsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUsersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsersDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.dateOfBirhdayDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.idRoleDataGridViewTextBoxColumn});
            this.listUsersGrid.DataSource = this.usersBindingSource2;
            this.listUsersGrid.Location = new System.Drawing.Point(13, 56);
            this.listUsersGrid.Name = "listUsersGrid";
            this.listUsersGrid.RowHeadersWidth = 62;
            this.listUsersGrid.RowTemplate.Height = 28;
            this.listUsersGrid.Size = new System.Drawing.Size(1266, 280);
            this.listUsersGrid.TabIndex = 21;
            // 
            // idUsersDataGridViewTextBoxColumn
            // 
            this.idUsersDataGridViewTextBoxColumn.DataPropertyName = "IdUsers";
            this.idUsersDataGridViewTextBoxColumn.HeaderText = "IdUsers";
            this.idUsersDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idUsersDataGridViewTextBoxColumn.Name = "idUsersDataGridViewTextBoxColumn";
            this.idUsersDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsersDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfBirhdayDataGridViewTextBoxColumn
            // 
            this.dateOfBirhdayDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirhday";
            this.dateOfBirhdayDataGridViewTextBoxColumn.HeaderText = "DateOfBirhday";
            this.dateOfBirhdayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfBirhdayDataGridViewTextBoxColumn.Name = "dateOfBirhdayDataGridViewTextBoxColumn";
            this.dateOfBirhdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // idRoleDataGridViewTextBoxColumn
            // 
            this.idRoleDataGridViewTextBoxColumn.DataPropertyName = "IdRole";
            this.idRoleDataGridViewTextBoxColumn.HeaderText = "IdRole";
            this.idRoleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idRoleDataGridViewTextBoxColumn.Name = "idRoleDataGridViewTextBoxColumn";
            this.idRoleDataGridViewTextBoxColumn.Width = 150;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.goodsAccountingDataSet3;
            // 
            // goodsAccountingDataSet3
            // 
            this.goodsAccountingDataSet3.DataSetName = "GoodsAccountingDataSet3";
            this.goodsAccountingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // ListEmployeesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1415, 439);
            this.Controls.Add(this.listUsersGrid);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListEmployeesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товароучёт";
            this.Load += new System.EventHandler(this.ListEmployeesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsAccountingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsAccountingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUsersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsAccountingDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private GoodsAccountingDataSet1 goodsAccountingDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GoodsAccountingDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button exitBtn;
        private GoodsAccountingDataSet2 goodsAccountingDataSet2;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private GoodsAccountingDataSet2TableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridView listUsersGrid;
        private GoodsAccountingDataSet3 goodsAccountingDataSet3;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private GoodsAccountingDataSet3TableAdapters.UsersTableAdapter usersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirhdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoleDataGridViewTextBoxColumn;
    }
}