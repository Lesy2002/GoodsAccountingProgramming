
namespace GoodsAccountingPractice1
{
    partial class InvoiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceList));
            this.label1 = new System.Windows.Forms.Label();
            this.InvoicesGrid = new System.Windows.Forms.DataGridView();
            this.invoiceGoodsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGoodsListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список накладных";
            // 
            // InvoicesGrid
            // 
            this.InvoicesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InvoicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoicesGrid.Location = new System.Drawing.Point(18, 42);
            this.InvoicesGrid.Name = "InvoicesGrid";
            this.InvoicesGrid.RowHeadersWidth = 62;
            this.InvoicesGrid.RowTemplate.Height = 28;
            this.InvoicesGrid.Size = new System.Drawing.Size(574, 158);
            this.InvoicesGrid.TabIndex = 17;
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.openBtn.ForeColor = System.Drawing.Color.Transparent;
            this.openBtn.Location = new System.Drawing.Point(460, 220);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(132, 45);
            this.openBtn.TabIndex = 21;
            this.openBtn.Text = "Открыть";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(18, 220);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 45);
            this.exitBtn.TabIndex = 22;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addBtn.Location = new System.Drawing.Point(322, 221);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 45);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // InvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(611, 278);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.InvoicesGrid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товароучёт";
            this.Load += new System.EventHandler(this.InvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGoodsListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView InvoicesGrid;
        
        private System.Windows.Forms.BindingSource invoiceGoodsListBindingSource;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn idListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
    }
}