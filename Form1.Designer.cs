namespace ButtonsLabelsLab2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.button1.Location = new System.Drawing.Point(30, 50);
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.Text = "Изменить цвет (1-2)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.button2.Location = new System.Drawing.Point(30, 100);
            this.button2.Size = new System.Drawing.Size(200, 36);
            this.button2.Text = "Изменить цвет (3-4)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            int lx = 270, ly = 50, lw = 240, lh = 36;
            System.Windows.Forms.Label[] labels = { this.label1, this.label2, this.label3, this.label4 };
            string[] texts = { "Метка 1", "Метка 2", "Метка 3", "Метка 4" };
            for (int i = 0; i < 4; i++)
            {
                labels[i].Location = new System.Drawing.Point(lx, ly + i * 50);
                labels[i].Size = new System.Drawing.Size(lw, lh);
                labels[i].Text = texts[i];
                labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                labels[i].BackColor = System.Drawing.Color.White;
                labels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                labels[i].Font = new System.Drawing.Font("Segoe UI", 11F);
            }

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "ЛР №2 Вариант 5 — Студент гр. ИС24 ФИО Гаврилов Артём Викторович";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
        }
    }
}
