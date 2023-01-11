namespace DbConnection
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
            this.list = new System.Windows.Forms.ListBox();
            this.ProcessorsBox = new System.Windows.Forms.ComboBox();
            this.VideoadaptersBox = new System.Windows.Forms.ComboBox();
            this.MemoryBox = new System.Windows.Forms.ComboBox();
            this.AddPcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 15;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(382, 439);
            this.list.TabIndex = 0;
            // 
            // ProcessorsBox
            // 
            this.ProcessorsBox.FormattingEnabled = true;
            this.ProcessorsBox.Location = new System.Drawing.Point(400, 12);
            this.ProcessorsBox.Name = "ProcessorsBox";
            this.ProcessorsBox.Size = new System.Drawing.Size(349, 23);
            this.ProcessorsBox.TabIndex = 1;
            // 
            // VideoadaptersBox
            // 
            this.VideoadaptersBox.FormattingEnabled = true;
            this.VideoadaptersBox.Location = new System.Drawing.Point(400, 41);
            this.VideoadaptersBox.Name = "VideoadaptersBox";
            this.VideoadaptersBox.Size = new System.Drawing.Size(349, 23);
            this.VideoadaptersBox.TabIndex = 1;
            // 
            // MemoryBox
            // 
            this.MemoryBox.FormattingEnabled = true;
            this.MemoryBox.Location = new System.Drawing.Point(400, 70);
            this.MemoryBox.Name = "MemoryBox";
            this.MemoryBox.Size = new System.Drawing.Size(349, 23);
            this.MemoryBox.TabIndex = 1;
            // 
            // AddPcBtn
            // 
            this.AddPcBtn.Location = new System.Drawing.Point(674, 99);
            this.AddPcBtn.Name = "AddPcBtn";
            this.AddPcBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPcBtn.TabIndex = 2;
            this.AddPcBtn.Text = "Добавить";
            this.AddPcBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 463);
            this.Controls.Add(this.AddPcBtn);
            this.Controls.Add(this.MemoryBox);
            this.Controls.Add(this.VideoadaptersBox);
            this.Controls.Add(this.ProcessorsBox);
            this.Controls.Add(this.list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox list;
        private ComboBox ProcessorsBox;
        private ComboBox VideoadaptersBox;
        private ComboBox MemoryBox;
        private Button AddPcBtn;
    }
}