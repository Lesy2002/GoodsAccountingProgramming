
namespace GoodsAccountingPractice1
{
    partial class AddInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInvoices));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ReceiptDateCmb = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.supCmb = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Оформление накладной";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Дата оформления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Поставщик";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.ReceiptDateCmb);
            this.panel4.Location = new System.Drawing.Point(228, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 34);
            this.panel4.TabIndex = 21;
            // 
            // ReceiptDateCmb
            // 
            this.ReceiptDateCmb.Location = new System.Drawing.Point(2, 3);
            this.ReceiptDateCmb.Name = "ReceiptDateCmb";
            this.ReceiptDateCmb.Size = new System.Drawing.Size(192, 26);
            this.ReceiptDateCmb.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.Controls.Add(this.supCmb);
            this.panel9.Location = new System.Drawing.Point(228, 108);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(196, 35);
            this.panel9.TabIndex = 22;
            // 
            // supCmb
            // 
            this.supCmb.FormattingEnabled = true;
            this.supCmb.Location = new System.Drawing.Point(2, 2);
            this.supCmb.Name = "supCmb";
            this.supCmb.Size = new System.Drawing.Size(192, 28);
            this.supCmb.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addBtn.ForeColor = System.Drawing.Color.Transparent;
            this.addBtn.Location = new System.Drawing.Point(293, 169);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 45);
            this.addBtn.TabIndex = 26;
            this.addBtn.Text = "Оформить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cancelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Location = new System.Drawing.Point(17, 169);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(132, 45);
            this.cancelBtn.TabIndex = 27;
            this.cancelBtn.Text = "Назад";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(449, 233);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товароучёт";
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker ReceiptDateCmb;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox supCmb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}