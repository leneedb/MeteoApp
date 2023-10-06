namespace MeteoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TempCelForm = new System.Windows.Forms.MaskedTextBox();
            this.weather = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Comt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveInFile = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.SaveDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TempCelForm
            // 
            this.TempCelForm.Location = new System.Drawing.Point(45, 50);
            this.TempCelForm.Mask = "#00.0";
            this.TempCelForm.Name = "TempCelForm";
            this.TempCelForm.Size = new System.Drawing.Size(100, 23);
            this.TempCelForm.TabIndex = 0;
            this.TempCelForm.Tag = "";
            this.TempCelForm.ValidatingType = typeof(int);
            this.TempCelForm.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // weather
            // 
            this.weather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weather.FormattingEnabled = true;
            this.weather.Location = new System.Drawing.Point(24, 79);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(121, 23);
            this.weather.TabIndex = 1;
            this.weather.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Градусы Цельсия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Погодные условия";
            // 
            // Comt
            // 
            this.Comt.Location = new System.Drawing.Point(24, 123);
            this.Comt.Multiline = true;
            this.Comt.Name = "Comt";
            this.Comt.Size = new System.Drawing.Size(312, 112);
            this.Comt.TabIndex = 4;
            this.Comt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Заметки";
            // 
            // SaveInFile
            // 
            this.SaveInFile.Location = new System.Drawing.Point(24, 241);
            this.SaveInFile.Name = "SaveInFile";
            this.SaveInFile.Size = new System.Drawing.Size(100, 72);
            this.SaveInFile.TabIndex = 6;
            this.SaveInFile.Text = "Сохранить в файл";
            this.SaveInFile.UseVisualStyleBackColor = true;
            this.SaveInFile.Click += new System.EventHandler(this.SaveInFile_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(130, 241);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(100, 72);
            this.View.TabIndex = 7;
            this.View.Text = "Показать";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // SaveDB
            // 
            this.SaveDB.Location = new System.Drawing.Point(236, 241);
            this.SaveDB.Name = "SaveDB";
            this.SaveDB.Size = new System.Drawing.Size(100, 72);
            this.SaveDB.TabIndex = 8;
            this.SaveDB.Text = "Сохранить в базу";
            this.SaveDB.UseVisualStyleBackColor = true;
            this.SaveDB.Click += new System.EventHandler(this.SaveDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveDB);
            this.Controls.Add(this.View);
            this.Controls.Add(this.SaveInFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Comt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weather);
            this.Controls.Add(this.TempCelForm);
            this.Name = "Form1";
            this.Text = "MeteoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox TempCelForm;
        private ComboBox weather;
        private Label label1;
        private Label label2;
        private TextBox Comt;
        private Label label3;
        private Button SaveInFile;
        private Button View;
        private Button SaveDB;
    }
}