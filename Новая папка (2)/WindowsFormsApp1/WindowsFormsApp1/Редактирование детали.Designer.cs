
namespace WindowsFormsApp1
{
    partial class Редактирование_детали
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kol = new System.Windows.Forms.TextBox();
            this.metal = new System.Windows.Forms.TextBox();
            this.ves = new System.Windows.Forms.TextBox();
            this.detail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Металл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Наименование";
            // 
            // kol
            // 
            this.kol.Location = new System.Drawing.Point(295, 138);
            this.kol.Name = "kol";
            this.kol.Size = new System.Drawing.Size(217, 20);
            this.kol.TabIndex = 12;
            // 
            // metal
            // 
            this.metal.Location = new System.Drawing.Point(295, 57);
            this.metal.Name = "metal";
            this.metal.Size = new System.Drawing.Size(217, 20);
            this.metal.TabIndex = 11;
            // 
            // ves
            // 
            this.ves.Location = new System.Drawing.Point(56, 138);
            this.ves.Name = "ves";
            this.ves.Size = new System.Drawing.Size(198, 20);
            this.ves.TabIndex = 10;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(56, 57);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(198, 20);
            this.detail.TabIndex = 9;
            // 
            // Редактирование_детали
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kol);
            this.Controls.Add(this.metal);
            this.Controls.Add(this.ves);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.button1);
            this.Name = "Редактирование_детали";
            this.Text = "Редактирование_детали";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kol;
        private System.Windows.Forms.TextBox metal;
        private System.Windows.Forms.TextBox ves;
        private System.Windows.Forms.TextBox detail;
    }
}