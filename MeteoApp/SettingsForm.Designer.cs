namespace MeteoApp
{
    partial class SettingsForm
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
            this.PathSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SettingFileQ = new System.Windows.Forms.Label();
            this.Standart = new System.Windows.Forms.RadioButton();
            this.JSONFormat = new System.Windows.Forms.RadioButton();
            this.XMLFormat = new System.Windows.Forms.RadioButton();
            this.LablePath = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathSave
            // 
            this.PathSave.Location = new System.Drawing.Point(12, 12);
            this.PathSave.Name = "PathSave";
            this.PathSave.Size = new System.Drawing.Size(349, 57);
            this.PathSave.TabIndex = 0;
            this.PathSave.Text = "Выбрать место сохранения";
            this.PathSave.UseVisualStyleBackColor = true;
            this.PathSave.Click += new System.EventHandler(this.PathSave_Click);
            // 
            // SettingFileQ
            // 
            this.SettingFileQ.AutoSize = true;
            this.SettingFileQ.Location = new System.Drawing.Point(12, 72);
            this.SettingFileQ.Name = "SettingFileQ";
            this.SettingFileQ.Size = new System.Drawing.Size(205, 15);
            this.SettingFileQ.TabIndex = 1;
            this.SettingFileQ.Text = "Выбор формата сохранения в файл";
            // 
            // Standart
            // 
            this.Standart.AutoSize = true;
            this.Standart.Checked = true;
            this.Standart.Location = new System.Drawing.Point(12, 90);
            this.Standart.Name = "Standart";
            this.Standart.Size = new System.Drawing.Size(98, 19);
            this.Standart.TabIndex = 2;
            this.Standart.TabStop = true;
            this.Standart.Text = "Стандартный";
            this.Standart.UseVisualStyleBackColor = true;
            // 
            // JSONFormat
            // 
            this.JSONFormat.AutoSize = true;
            this.JSONFormat.Location = new System.Drawing.Point(12, 115);
            this.JSONFormat.Name = "JSONFormat";
            this.JSONFormat.Size = new System.Drawing.Size(53, 19);
            this.JSONFormat.TabIndex = 3;
            this.JSONFormat.Text = "JSON";
            this.JSONFormat.UseVisualStyleBackColor = true;
            // 
            // XMLFormat
            // 
            this.XMLFormat.AutoSize = true;
            this.XMLFormat.Location = new System.Drawing.Point(12, 140);
            this.XMLFormat.Name = "XMLFormat";
            this.XMLFormat.Size = new System.Drawing.Size(49, 19);
            this.XMLFormat.TabIndex = 4;
            this.XMLFormat.Text = "XML";
            this.XMLFormat.UseVisualStyleBackColor = true;
            // 
            // LablePath
            // 
            this.LablePath.AutoSize = true;
            this.LablePath.Location = new System.Drawing.Point(12, 39);
            this.LablePath.Name = "LablePath";
            this.LablePath.Size = new System.Drawing.Size(0, 15);
            this.LablePath.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 176);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(349, 58);
            this.Start.TabIndex = 6;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 244);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.LablePath);
            this.Controls.Add(this.XMLFormat);
            this.Controls.Add(this.JSONFormat);
            this.Controls.Add(this.Standart);
            this.Controls.Add(this.SettingFileQ);
            this.Controls.Add(this.PathSave);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PathSave;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label SettingFileQ;
        private RadioButton Standart;
        private RadioButton JSONFormat;
        private RadioButton XMLFormat;
        private Label LablePath;
        private Button Start;
    }
}