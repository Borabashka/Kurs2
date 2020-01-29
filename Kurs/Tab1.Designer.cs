using System.Windows.Forms;

namespace Kurs
{
    partial class Tab1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Sport = new System.Windows.Forms.TextBox();
            this.NewBut = new System.Windows.Forms.Button();
            this.DelBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.RandomBut = new System.Windows.Forms.Button();
            this.Gold = new System.Windows.Forms.TextBox();
            this.Silver = new System.Windows.Forms.TextBox();
            this.Bronze = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Страна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(16, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Вид спорта";
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Country.Location = new System.Drawing.Point(133, 8);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(212, 27);
            this.Country.TabIndex = 13;
            this.Country.TabStop = false;
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(133, 48);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(212, 27);
            this.NameText.TabIndex = 14;
            this.NameText.TabStop = false;
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(133, 88);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(212, 27);
            this.Surname.TabIndex = 15;
            this.Surname.TabStop = false;
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Age.Location = new System.Drawing.Point(133, 128);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(212, 27);
            this.Age.TabIndex = 16;
            this.Age.TabStop = false;
            // 
            // Sport
            // 
            this.Sport.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sport.Location = new System.Drawing.Point(133, 168);
            this.Sport.Name = "Sport";
            this.Sport.Size = new System.Drawing.Size(212, 27);
            this.Sport.TabIndex = 17;
            this.Sport.TabStop = false;
            // 
            // NewBut
            // 
            this.NewBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.NewBut.Enabled = false;
            this.NewBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.NewBut.FlatAppearance.BorderSize = 0;
            this.NewBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBut.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewBut.Location = new System.Drawing.Point(20, 279);
            this.NewBut.Name = "NewBut";
            this.NewBut.Size = new System.Drawing.Size(73, 30);
            this.NewBut.TabIndex = 18;
            this.NewBut.TabStop = false;
            this.NewBut.Text = "New";
            this.NewBut.UseVisualStyleBackColor = false;
            this.NewBut.Click += new System.EventHandler(this.NewBut_Click);
            // 
            // DelBut
            // 
            this.DelBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.DelBut.Enabled = false;
            this.DelBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.DelBut.FlatAppearance.BorderSize = 0;
            this.DelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBut.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelBut.Location = new System.Drawing.Point(272, 279);
            this.DelBut.Name = "DelBut";
            this.DelBut.Size = new System.Drawing.Size(73, 30);
            this.DelBut.TabIndex = 19;
            this.DelBut.TabStop = false;
            this.DelBut.Text = "Delete";
            this.DelBut.UseVisualStyleBackColor = false;
            this.DelBut.Click += new System.EventHandler(this.DelBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.SaveBut.Enabled = false;
            this.SaveBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.SaveBut.FlatAppearance.BorderSize = 0;
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBut.Location = new System.Drawing.Point(193, 279);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(73, 30);
            this.SaveBut.TabIndex = 20;
            this.SaveBut.TabStop = false;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = false;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // RandomBut
            // 
            this.RandomBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.RandomBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.RandomBut.FlatAppearance.BorderSize = 0;
            this.RandomBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomBut.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomBut.Location = new System.Drawing.Point(20, 315);
            this.RandomBut.Name = "RandomBut";
            this.RandomBut.Size = new System.Drawing.Size(73, 30);
            this.RandomBut.TabIndex = 21;
            this.RandomBut.TabStop = false;
            this.RandomBut.Text = "Random";
            this.RandomBut.UseVisualStyleBackColor = false;
            this.RandomBut.Click += new System.EventHandler(this.RandomBut_Click);
            // 
            // Gold
            // 
            this.Gold.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gold.ForeColor = System.Drawing.Color.Black;
            this.Gold.Location = new System.Drawing.Point(79, 210);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(25, 27);
            this.Gold.TabIndex = 25;
            this.Gold.TabStop = false;
            this.Gold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Silver
            // 
            this.Silver.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Silver.ForeColor = System.Drawing.Color.Black;
            this.Silver.Location = new System.Drawing.Point(187, 210);
            this.Silver.Name = "Silver";
            this.Silver.Size = new System.Drawing.Size(25, 27);
            this.Silver.TabIndex = 26;
            this.Silver.TabStop = false;
            this.Silver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bronze
            // 
            this.Bronze.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bronze.ForeColor = System.Drawing.Color.Black;
            this.Bronze.Location = new System.Drawing.Point(295, 210);
            this.Bronze.Name = "Bronze";
            this.Bronze.Size = new System.Drawing.Size(25, 27);
            this.Bronze.TabIndex = 27;
            this.Bronze.TabStop = false;
            this.Bronze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kurs.Properties.Resources.bronze;
            this.pictureBox3.Location = new System.Drawing.Point(259, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kurs.Properties.Resources.silver;
            this.pictureBox2.Location = new System.Drawing.Point(151, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kurs.Properties.Resources.gold;
            this.pictureBox1.Location = new System.Drawing.Point(43, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // SelectCheck
            // 
            this.SelectCheck.Tick += new System.EventHandler(this.SelectCheck_Tick);
            // 
            // Tab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Bronze);
            this.Controls.Add(this.Silver);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RandomBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.DelBut);
            this.Controls.Add(this.NewBut);
            this.Controls.Add(this.Sport);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Tab1";
            this.Size = new System.Drawing.Size(367, 353);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Gold;
        private System.Windows.Forms.TextBox Silver;
        private System.Windows.Forms.TextBox Bronze;
        public System.Windows.Forms.Button NewBut;
        public System.Windows.Forms.Button DelBut;
        public System.Windows.Forms.Button SaveBut;
        public System.Windows.Forms.Button RandomBut;
        public TextBox Sport;
        public Timer SelectCheck;
    }
}
