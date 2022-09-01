
namespace GoodsAccountingPractice1
{
    partial class ListSuppliersWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSuppliersWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsAccountingDataSet = new GoodsAccountingPractice1.GoodsAccountingDataSet();
            this.suppliersTableAdapter = new GoodsAccountingPractice1.GoodsAccountingDataSetTableAdapters.SuppliersTableAdapter();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.listSuppliersGrid = new System.Windows.Forms.DataGridView();
            this.idSuppliersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsAccountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSuppliersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список поставщиков";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.goodsAccountingDataSet;
            // 
            // goodsAccountingDataSet
            // 
            this.goodsAccountingDataSet.DataSetName = "GoodsAccountingDataSet";
            this.goodsAccountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Location = new System.Drawing.Point(1174, 288);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(95, 44);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addBtn.Location = new System.Drawing.Point(1055, 288);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 44);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(25, 288);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 44);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(403, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(28, 25);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Л";
            // 
            // listSuppliersGrid
            // 
            this.listSuppliersGrid.AutoGenerateColumns = false;
            this.listSuppliersGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listSuppliersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSuppliersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSuppliersDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn});
            this.listSuppliersGrid.DataSource = this.suppliersBindingSource;
            this.listSuppliersGrid.Location = new System.Drawing.Point(25, 54);
            this.listSuppliersGrid.Name = "listSuppliersGrid";
            this.listSuppliersGrid.RowHeadersWidth = 62;
            this.listSuppliersGrid.RowTemplate.Height = 28;
            this.listSuppliersGrid.Size = new System.Drawing.Size(1244, 228);
            this.listSuppliersGrid.TabIndex = 12;
            // 
            // idSuppliersDataGridViewTextBoxColumn
            // 
            this.idSuppliersDataGridViewTextBoxColumn.DataPropertyName = "IdSuppliers";
            this.idSuppliersDataGridViewTextBoxColumn.HeaderText = "IdSuppliers";
            this.idSuppliersDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idSuppliersDataGridViewTextBoxColumn.Name = "idSuppliersDataGridViewTextBoxColumn";
            this.idSuppliersDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSuppliersDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "Inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "Inn";
            this.innDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            this.innDataGridViewTextBoxColumn.Width = 150;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editBtn.ForeColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(889, 288);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(144, 44);
            this.editBtn.TabIndex = 11;
            this.editBtn.Text = "Редактировать";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodsAccountingPractice1.Properties.Resources.png_clipart_user_computer_icons_sprite_sprite_blue_logo__1___1_;
            this.pictureBox1.Location = new System.Drawing.Point(375, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ListSuppliersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1281, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.listSuppliersGrid);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListSuppliersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товароучёт";
            this.Load += new System.EventHandler(this.ListSuppliersWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsAccountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSuppliersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GoodsAccountingDataSet goodsAccountingDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private GoodsAccountingDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridView listSuppliersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSuppliersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}