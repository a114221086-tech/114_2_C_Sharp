namespace WinFormsApp1
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

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelFull;
        private System.Windows.Forms.TextBox textBoxFullMorse;
        private System.Windows.Forms.Label labelLookup;
        private System.Windows.Forms.ListBox listBoxLookup;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClear;

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelFull = new System.Windows.Forms.Label();
            this.textBoxFullMorse = new System.Windows.Forms.TextBox();
            this.labelLookup = new System.Windows.Forms.Label();
            this.listBoxLookup = new System.Windows.Forms.ListBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(80, 15);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "請輸入字串：";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 27);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(460, 80);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelFull
            // 
            this.labelFull.AutoSize = true;
            this.labelFull.Location = new System.Drawing.Point(12, 120);
            this.labelFull.Name = "labelFull";
            this.labelFull.Size = new System.Drawing.Size(110, 15);
            this.labelFull.TabIndex = 2;
            this.labelFull.Text = "完整摩斯密碼：";
            // 
            // textBoxFullMorse
            // 
            this.textBoxFullMorse.Location = new System.Drawing.Point(12, 138);
            this.textBoxFullMorse.Multiline = true;
            this.textBoxFullMorse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFullMorse.Name = "textBoxFullMorse";
            this.textBoxFullMorse.ReadOnly = true;
            this.textBoxFullMorse.Size = new System.Drawing.Size(460, 80);
            this.textBoxFullMorse.TabIndex = 3;
            // 
            // labelLookup
            // 
            this.labelLookup.AutoSize = true;
            this.labelLookup.Location = new System.Drawing.Point(12, 230);
            this.labelLookup.Name = "labelLookup";
            this.labelLookup.Size = new System.Drawing.Size(80, 15);
            this.labelLookup.TabIndex = 4;
            this.labelLookup.Text = "逐字對照：";
            // 
            // listBoxLookup
            // 
            this.listBoxLookup.FormattingEnabled = true;
            this.listBoxLookup.ItemHeight = 15;
            this.listBoxLookup.Location = new System.Drawing.Point(12, 248);
            this.listBoxLookup.Name = "listBoxLookup";
            this.listBoxLookup.Size = new System.Drawing.Size(460, 139);
            this.listBoxLookup.TabIndex = 5;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(300, 400);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(80, 30);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "轉換";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(392, 400);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 30);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.listBoxLookup);
            this.Controls.Add(this.labelLookup);
            this.Controls.Add(this.textBoxFullMorse);
            this.Controls.Add(this.labelFull);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "摩斯密碼轉換";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
