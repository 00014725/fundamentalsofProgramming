namespace Dictionary_EL___EN
{
    partial class Dictionary
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDictionaryName = new System.Windows.Forms.Label();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDictionaryName
            // 
            this.lblDictionaryName.AutoSize = true;
            this.lblDictionaryName.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDictionaryName.Location = new System.Drawing.Point(53, 56);
            this.lblDictionaryName.Name = "lblDictionaryName";
            this.lblDictionaryName.Size = new System.Drawing.Size(199, 33);
            this.lblDictionaryName.TabIndex = 0;
            this.lblDictionaryName.Text = "Elbonian Dictionary";
            this.lblDictionaryName.Click += new System.EventHandler(this.lblDictionaryName_Click);
            // 
            // tbxWord
            // 
            this.tbxWord.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWord.Location = new System.Drawing.Point(36, 170);
            this.tbxWord.Multiline = true;
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(235, 34);
            this.tbxWord.TabIndex = 1;
            this.tbxWord.Text = " ";
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.SystemColors.Info;
            this.btnTranslate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranslate.Location = new System.Drawing.Point(69, 234);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(141, 37);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Search";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(120, 127);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 21);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(209, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit ";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.tbxWord);
            this.Controls.Add(this.lblDictionaryName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result ";
            this.Load += new System.EventHandler(this.Dictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDictionaryName;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnExit;
    }
}

