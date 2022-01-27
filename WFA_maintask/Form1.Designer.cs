namespace WFA_maintask
{
    partial class Form1
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
            this.cmdTest = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListBox();
            this.cmdTest1 = new System.Windows.Forms.Button();
            this.cmdTest2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(12, -1);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(259, 39);
            this.cmdTest.TabIndex = 1;
            this.cmdTest.Text = "Выгрузить данные из БД";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.Location = new System.Drawing.Point(-1, 104);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(713, 329);
            this.Result.TabIndex = 2;
            // 
            // cmdTest1
            // 
            this.cmdTest1.Location = new System.Drawing.Point(12, 44);
            this.cmdTest1.Name = "cmdTest1";
            this.cmdTest1.Size = new System.Drawing.Size(259, 39);
            this.cmdTest1.TabIndex = 3;
            this.cmdTest1.Text = "Количество строк";
            this.cmdTest1.UseVisualStyleBackColor = true;
            this.cmdTest1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdTest2
            // 
            this.cmdTest2.Location = new System.Drawing.Point(332, 0);
            this.cmdTest2.Name = "cmdTest2";
            this.cmdTest2.Size = new System.Drawing.Size(259, 38);
            this.cmdTest2.TabIndex = 4;
            this.cmdTest2.Text = "Добавить данные";
            this.cmdTest2.UseVisualStyleBackColor = true;
            this.cmdTest2.Click += new System.EventHandler(this.cmdTest2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Удалить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdTest2);
            this.Controls.Add(this.cmdTest1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.cmdTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdTest;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Button cmdTest1;
        private System.Windows.Forms.Button cmdTest2;
        private System.Windows.Forms.Button button1;
    }
}

