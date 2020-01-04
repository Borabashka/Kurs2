namespace Kurs
{
    partial class BDList
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
            this.label2 = new System.Windows.Forms.Label();
            this.NameDataBase = new System.Windows.Forms.TextBox();
            this.ElementsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BdInfo = new System.Windows.Forms.Label();
            this.TabInfoPanel = new System.Windows.Forms.Panel();
            this.TabBut1 = new System.Windows.Forms.Button();
            this.TabBut2 = new System.Windows.Forms.Button();
            this.TabBut3 = new System.Windows.Forms.Button();
            this.BackBut = new System.Windows.Forms.PictureBox();
            this.ElementsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBut)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя базы данных:";
            // 
            // NameDataBase
            // 
            this.NameDataBase.BackColor = System.Drawing.Color.White;
            this.NameDataBase.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDataBase.Location = new System.Drawing.Point(7, 34);
            this.NameDataBase.Name = "NameDataBase";
            this.NameDataBase.Size = new System.Drawing.Size(276, 29);
            this.NameDataBase.TabIndex = 6;
            this.NameDataBase.TabStop = false;
            this.NameDataBase.TextChanged += new System.EventHandler(this.NameDatabase_TextChanged);
            // 
            // ElementsPanel
            // 
            this.ElementsPanel.AutoScroll = true;
            this.ElementsPanel.BackColor = System.Drawing.Color.White;
            this.ElementsPanel.Controls.Add(this.BdInfo);
            this.ElementsPanel.Location = new System.Drawing.Point(7, 68);
            this.ElementsPanel.Name = "ElementsPanel";
            this.ElementsPanel.Size = new System.Drawing.Size(311, 354);
            this.ElementsPanel.TabIndex = 8;
            // 
            // BdInfo
            // 
            this.BdInfo.AutoSize = true;
            this.BdInfo.BackColor = System.Drawing.Color.Transparent;
            this.BdInfo.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.BdInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BdInfo.Location = new System.Drawing.Point(3, 0);
            this.BdInfo.Name = "BdInfo";
            this.BdInfo.Size = new System.Drawing.Size(223, 21);
            this.BdInfo.TabIndex = 9;
            this.BdInfo.Text = "Выбранная база данных пуста";
            this.BdInfo.Visible = false;
            // 
            // TabInfoPanel
            // 
            this.TabInfoPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TabInfoPanel.Location = new System.Drawing.Point(324, 68);
            this.TabInfoPanel.Name = "TabInfoPanel";
            this.TabInfoPanel.Size = new System.Drawing.Size(367, 3);
            this.TabInfoPanel.TabIndex = 9;
            // 
            // TabBut1
            // 
            this.TabBut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.TabBut1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut1.FlatAppearance.BorderSize = 0;
            this.TabBut1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabBut1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabBut1.Location = new System.Drawing.Point(330, 38);
            this.TabBut1.Name = "TabBut1";
            this.TabBut1.Size = new System.Drawing.Size(60, 30);
            this.TabBut1.TabIndex = 10;
            this.TabBut1.TabStop = false;
            this.TabBut1.Text = "Edit BD";
            this.TabBut1.UseVisualStyleBackColor = false;
            this.TabBut1.Click += new System.EventHandler(this.TabBut1_Click);
            // 
            // TabBut2
            // 
            this.TabBut2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut2.FlatAppearance.BorderSize = 0;
            this.TabBut2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabBut2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabBut2.Location = new System.Drawing.Point(390, 38);
            this.TabBut2.Name = "TabBut2";
            this.TabBut2.Size = new System.Drawing.Size(60, 30);
            this.TabBut2.TabIndex = 11;
            this.TabBut2.TabStop = false;
            this.TabBut2.Text = "1";
            this.TabBut2.UseVisualStyleBackColor = false;
            this.TabBut2.Click += new System.EventHandler(this.TabBut2_Click);
            // 
            // TabBut3
            // 
            this.TabBut3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.TabBut3.FlatAppearance.BorderSize = 0;
            this.TabBut3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TabBut3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabBut3.Location = new System.Drawing.Point(450, 38);
            this.TabBut3.Name = "TabBut3";
            this.TabBut3.Size = new System.Drawing.Size(60, 30);
            this.TabBut3.TabIndex = 12;
            this.TabBut3.TabStop = false;
            this.TabBut3.Text = "2";
            this.TabBut3.UseVisualStyleBackColor = false;
            this.TabBut3.Click += new System.EventHandler(this.TabBut3_Click);
            // 
            // BackBut
            // 
            this.BackBut.Image = global::Kurs.Properties.Resources.Back_Default;
            this.BackBut.Location = new System.Drawing.Point(655, 6);
            this.BackBut.Name = "BackBut";
            this.BackBut.Size = new System.Drawing.Size(30, 30);
            this.BackBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBut.TabIndex = 13;
            this.BackBut.TabStop = false;
            this.BackBut.Click += new System.EventHandler(this.BackBut_Click);
            this.BackBut.MouseEnter += new System.EventHandler(this.BackBut_Enter);
            this.BackBut.MouseLeave += new System.EventHandler(this.BackBut_Leave);
            // 
            // BDList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kurs.Properties.Resources.d51ea6e460ff3245;
            this.Controls.Add(this.BackBut);
            this.Controls.Add(this.TabInfoPanel);
            this.Controls.Add(this.TabBut1);
            this.Controls.Add(this.TabBut2);
            this.Controls.Add(this.TabBut3);
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameDataBase);
            this.Name = "BDList";
            this.Size = new System.Drawing.Size(694, 426);
            this.ElementsPanel.ResumeLayout(false);
            this.ElementsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameDataBase;
        private System.Windows.Forms.FlowLayoutPanel ElementsPanel;
        private System.Windows.Forms.Label BdInfo;
        private System.Windows.Forms.Panel TabInfoPanel;
        private System.Windows.Forms.Button TabBut1;
        private System.Windows.Forms.Button TabBut2;
        public System.Windows.Forms.Button TabBut3;
        private System.Windows.Forms.PictureBox BackBut;
    }
}
