
namespace GoodsAccountingPractice1
{
    partial class InvoicesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.Idlbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.supplbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Накладная";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дата оформления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(533, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Поставщик";
            // 
            // productGrid
            // 
            this.productGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Location = new System.Drawing.Point(22, 166);
            this.productGrid.Name = "productGrid";
            this.productGrid.RowHeadersWidth = 62;
            this.productGrid.RowTemplate.Height = 28;
            this.productGrid.Size = new System.Drawing.Size(723, 154);
            this.productGrid.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(17, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Список товаров:";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addBtn.Location = new System.Drawing.Point(598, 341);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(147, 45);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Добавить товар";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(22, 341);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 45);
            this.exitBtn.TabIndex = 25;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Idlbl
            // 
            this.Idlbl.AutoSize = true;
            this.Idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Idlbl.Location = new System.Drawing.Point(452, 20);
            this.Idlbl.Name = "Idlbl";
            this.Idlbl.Size = new System.Drawing.Size(44, 25);
            this.Idlbl.TabIndex = 26;
            this.Idlbl.Text = "kjkj";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datelbl.Location = new System.Drawing.Point(235, 71);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(44, 25);
            this.datelbl.TabIndex = 27;
            this.datelbl.Text = "kjkj";
            // 
            // supplbl
            // 
            this.supplbl.AutoSize = true;
            this.supplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplbl.Location = new System.Drawing.Point(680, 71);
            this.supplbl.Name = "supplbl";
            this.supplbl.Size = new System.Drawing.Size(44, 25);
            this.supplbl.TabIndex = 28;
            this.supplbl.Text = "kjkj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(425, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "№";
            // 
            // InvoicesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(901, 403);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.supplbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.Idlbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoicesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товароучёт";
            this.Load += new System.EventHandler(this.InvoicesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label Idlbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label supplbl;
        private System.Windows.Forms.Label label5;
    }
}