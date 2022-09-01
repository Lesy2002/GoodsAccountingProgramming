
namespace GoodsAccountingPractice1
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listSuppliersBtn = new System.Windows.Forms.Button();
            this.listEmployeesBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Меню администратора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Список сотрудников";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Список поставщиков";
            // 
            // listSuppliersBtn
            // 
            this.listSuppliersBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listSuppliersBtn.ForeColor = System.Drawing.Color.Transparent;
            this.listSuppliersBtn.Location = new System.Drawing.Point(283, 100);
            this.listSuppliersBtn.Name = "listSuppliersBtn";
            this.listSuppliersBtn.Size = new System.Drawing.Size(102, 35);
            this.listSuppliersBtn.TabIndex = 10;
            this.listSuppliersBtn.Text = "Открыть";
            this.listSuppliersBtn.UseVisualStyleBackColor = false;
            this.listSuppliersBtn.Click += new System.EventHandler(this.listSuppliersBtn_Click);
            // 
            // listEmployeesBtn
            // 
            this.listEmployeesBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listEmployeesBtn.ForeColor = System.Drawing.Color.Transparent;
            this.listEmployeesBtn.Location = new System.Drawing.Point(283, 48);
            this.listEmployeesBtn.Name = "listEmployeesBtn";
            this.listEmployeesBtn.Size = new System.Drawing.Size(102, 35);
            this.listEmployeesBtn.TabIndex = 9;
            this.listEmployeesBtn.Text = "Открыть";
            this.listEmployeesBtn.UseVisualStyleBackColor = false;
            this.listEmployeesBtn.Click += new System.EventHandler(this.listEmployeesBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.backBtn.ForeColor = System.Drawing.Color.Transparent;
            this.backBtn.Location = new System.Drawing.Point(17, 148);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(368, 44);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Выйти";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.entranceBtn_Click_1);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(405, 206);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.listSuppliersBtn);
            this.Controls.Add(this.listEmployeesBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товароучёт";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button listSuppliersBtn;
        private System.Windows.Forms.Button listEmployeesBtn;
        private System.Windows.Forms.Button backBtn;
    }
}