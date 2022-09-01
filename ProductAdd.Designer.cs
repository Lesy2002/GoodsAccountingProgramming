
namespace GoodsAccountingPractice1
{
    partial class ProductAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.countBox = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.titleBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Добавление товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Количество";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.countBox);
            this.panel1.Location = new System.Drawing.Point(153, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 34);
            this.panel1.TabIndex = 23;
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(2, 2);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(192, 26);
            this.countBox.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.Controls.Add(this.titleBox);
            this.panel9.Location = new System.Drawing.Point(153, 52);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(196, 35);
            this.panel9.TabIndex = 24;
            // 
            // titleBox
            // 
            this.titleBox.FormattingEnabled = true;
            this.titleBox.Location = new System.Drawing.Point(2, 2);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(192, 28);
            this.titleBox.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addBtn.Location = new System.Drawing.Point(231, 149);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(118, 44);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editBtn.ForeColor = System.Drawing.Color.Transparent;
            this.editBtn.Location = new System.Drawing.Point(17, 149);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(118, 44);
            this.editBtn.TabIndex = 26;
            this.editBtn.Text = "Закрыть";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(370, 205);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товароучёт";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox titleBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
    }
}