﻿namespace Kurs
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.NameDatabase = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.KindSport = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Generate);
            this.panel1.Controls.Add(this.Random);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.NameDatabase);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.KindSport);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.Country);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(96, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 423);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(5, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Фамилия участника";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(179, 152);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(170, 20);
            this.LastName.TabIndex = 23;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.ForeColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(18, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "Last";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Last_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.GhostWhite;
            this.label12.Location = new System.Drawing.Point(192, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Или случайная генерация";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.GhostWhite;
            this.label11.Location = new System.Drawing.Point(3, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Колличество медалей";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(402, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Next_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.GhostWhite;
            this.label9.Location = new System.Drawing.Point(14, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(485, 44);
            this.label9.TabIndex = 16;
            this.label9.Text = "Введите данные для существующего процесса или создайте\r\nслучайные данные";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // NameDatabase
            // 
            this.NameDatabase.Location = new System.Drawing.Point(91, 56);
            this.NameDatabase.Name = "NameDatabase";
            this.NameDatabase.Size = new System.Drawing.Size(314, 20);
            this.NameDatabase.TabIndex = 15;
            this.NameDatabase.TextChanged += new System.EventHandler(this.NameDatabase_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(179, 335);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(170, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextChanged += new System.EventHandler(this.BronzeMedal_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(179, 309);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.SilverMedal_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.GoldMedal_TextChanged);
            // 
            // KindSport
            // 
            this.KindSport.Location = new System.Drawing.Point(179, 212);
            this.KindSport.Name = "KindSport";
            this.KindSport.Size = new System.Drawing.Size(170, 20);
            this.KindSport.TabIndex = 11;
            this.KindSport.TextChanged += new System.EventHandler(this.Sport_TextChanged);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(179, 183);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(170, 20);
            this.Age.TabIndex = 10;
            this.Age.TextChanged += new System.EventHandler(this.Age_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(179, 121);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(170, 20);
            this.FirstName.TabIndex = 9;
            this.FirstName.TextChanged += new System.EventHandler(this.Initials_TextChanged);
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(179, 92);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(170, 20);
            this.Country.TabIndex = 8;
            this.Country.TextChanged += new System.EventHandler(this.Country_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.GhostWhite;
            this.label8.Location = new System.Drawing.Point(78, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Бронзовых";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(68, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Серебряных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(94, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Золотых";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(65, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вид спорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(90, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(46, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя участника";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Страна-участница";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Процесс";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Random
            // 
            this.Random.BackColor = System.Drawing.SystemColors.Highlight;
            this.Random.ForeColor = System.Drawing.SystemColors.Window;
            this.Random.Location = new System.Drawing.Point(195, 383);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(135, 27);
            this.Random.TabIndex = 25;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = false;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(383, 333);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(99, 22);
            this.Generate.TabIndex = 26;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox KindSport;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameDatabase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Generate;
    }
}