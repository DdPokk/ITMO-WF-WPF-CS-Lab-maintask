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
            this.SuspendLayout();
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(51, -1);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(431, 39);
            this.cmdTest.TabIndex = 1;
            this.cmdTest.Text = "Выгрузить данные из БД";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.Location = new System.Drawing.Point(-1, 182);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(555, 173);
            this.Result.TabIndex = 2;
            // 
            // cmdTest1
            // 
            this.cmdTest1.Location = new System.Drawing.Point(51, 44);
            this.cmdTest1.Name = "cmdTest1";
            this.cmdTest1.Size = new System.Drawing.Size(431, 49);
            this.cmdTest1.TabIndex = 3;
            this.cmdTest1.Text = "Количество строк";
            this.cmdTest1.UseVisualStyleBackColor = true;
            this.cmdTest1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdTest2
            // 
            this.cmdTest2.Location = new System.Drawing.Point(51, 99);
            this.cmdTest2.Name = "cmdTest2";
            this.cmdTest2.Size = new System.Drawing.Size(431, 43);
            this.cmdTest2.TabIndex = 4;
            this.cmdTest2.Text = "Добавить данные";
            this.cmdTest2.UseVisualStyleBackColor = true;
            this.cmdTest2.Click += new System.EventHandler(this.cmdTest2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 346);
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
    }
}

