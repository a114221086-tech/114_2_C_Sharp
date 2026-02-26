namespace Review_Q1
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
            lblComputerOutput = new Label();
            lblPlayerOutput = new Label();
            lblComputerChoice = new Label();
            lblPlayerChoice = new Label();
            lblResult = new Label();
            btnRock = new Button();
            btnPaper = new Button();
            btnScissors = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblComputerOutput
            // 
            lblComputerOutput.AutoSize = true;
            lblComputerOutput.Font = new Font("微軟正黑體", 14F);
            lblComputerOutput.Location = new Point(120, 20);
            lblComputerOutput.Name = "lblComputerOutput";
            lblComputerOutput.Size = new Size(99, 35);
            lblComputerOutput.TabIndex = 0;
            lblComputerOutput.Text = "電腦出";
            // 
            // lblPlayerOutput
            // 
            lblPlayerOutput.AutoSize = true;
            lblPlayerOutput.Font = new Font("微軟正黑體", 14F);
            lblPlayerOutput.Location = new Point(340, 20);
            lblPlayerOutput.Name = "lblPlayerOutput";
            lblPlayerOutput.Size = new Size(99, 35);
            lblPlayerOutput.TabIndex = 1;
            lblPlayerOutput.Text = "玩家出";
            // 
            // lblComputerChoice
            // 
            lblComputerChoice.BackColor = SystemColors.ActiveBorder;
            lblComputerChoice.BorderStyle = BorderStyle.FixedSingle;
            lblComputerChoice.Font = new Font("微軟正黑體", 36F);
            lblComputerChoice.Location = new Point(40, 60);
            lblComputerChoice.Name = "lblComputerChoice";
            lblComputerChoice.Size = new Size(200, 150);
            lblComputerChoice.TabIndex = 2;
            lblComputerChoice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerChoice
            // 
            lblPlayerChoice.BackColor = SystemColors.ActiveBorder;
            lblPlayerChoice.BorderStyle = BorderStyle.FixedSingle;
            lblPlayerChoice.Font = new Font("微軟正黑體", 36F);
            lblPlayerChoice.Location = new Point(328, 60);
            lblPlayerChoice.Name = "lblPlayerChoice";
            lblPlayerChoice.Size = new Size(200, 150);
            lblPlayerChoice.TabIndex = 3;
            lblPlayerChoice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("微軟正黑體", 16F);
            lblResult.Location = new Point(80, 230);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(460, 40);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRock
            // 
            btnRock.Font = new Font("微軟正黑體", 14F);
            btnRock.Location = new Point(80, 290);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(100, 50);
            btnRock.TabIndex = 5;
            btnRock.Text = "石頭";
            btnRock.Click += BtnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("微軟正黑體", 14F);
            btnPaper.Location = new Point(220, 290);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(100, 50);
            btnPaper.TabIndex = 6;
            btnPaper.Text = "布";
            btnPaper.Click += BtnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Font = new Font("微軟正黑體", 14F);
            btnScissors.Location = new Point(360, 290);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(100, 50);
            btnScissors.TabIndex = 7;
            btnScissors.Text = "剪刀";
            btnScissors.Click += BtnScissors_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("微軟正黑體", 14F);
            btnExit.Location = new Point(180, 360);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 50);
            btnExit.TabIndex = 8;
            btnExit.Text = "結束遊戲";
            btnExit.Click += BtnExit_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(580, 430);
            Controls.Add(lblComputerOutput);
            Controls.Add(lblPlayerOutput);
            Controls.Add(lblComputerChoice);
            Controls.Add(lblPlayerChoice);
            Controls.Add(lblResult);
            Controls.Add(btnRock);
            Controls.Add(btnPaper);
            Controls.Add(btnScissors);
            Controls.Add(btnExit);
            Font = new Font("微軟正黑體", 10F);
            Name = "Form1";
            Text = "猜拳遊戲";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblComputerOutput;
        private System.Windows.Forms.Label lblPlayerOutput;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnExit;
    }
}
