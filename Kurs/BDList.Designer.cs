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
            this.ElementsPanel.SuspendLayout();
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
            // BDList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kurs.Properties.Resources.d51ea6e460ff3245;
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameDataBase);
            this.Name = "BDList";
            this.Size = new System.Drawing.Size(694, 426);
            this.ElementsPanel.ResumeLayout(false);
            this.ElementsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameDataBase;
        private System.Windows.Forms.FlowLayoutPanel ElementsPanel;
        private System.Windows.Forms.Label BdInfo;
    }
}
