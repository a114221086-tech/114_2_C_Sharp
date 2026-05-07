namespace _05_07_Q1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_depositPrompt;
        private System.Windows.Forms.TextBox textBox_deposit;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.Label label_lastWin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_betPrompt;
        private System.Windows.Forms.ComboBox comboBox_bet;
        private System.Windows.Forms.Label label_totalSpins;
        private System.Windows.Forms.Label label_winCount;
        private System.Windows.Forms.Label label_winRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_depositPrompt = new System.Windows.Forms.Label();
            this.textBox_deposit = new System.Windows.Forms.TextBox();
            this.button_deposit = new System.Windows.Forms.Button();
            this.label_balance = new System.Windows.Forms.Label();
            this.label_lastWin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_betPrompt = new System.Windows.Forms.Label();
            this.comboBox_bet = new System.Windows.Forms.ComboBox();
            this.label_totalSpins = new System.Windows.Forms.Label();
            this.label_winCount = new System.Windows.Forms.Label();
            this.label_winRate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_depositPrompt
            // 
            this.label_depositPrompt.AutoSize = true;
            this.label_depositPrompt.Location = new System.Drawing.Point(20, 20);
            this.label_depositPrompt.Name = "label_depositPrompt";
            this.label_depositPrompt.Size = new System.Drawing.Size(100, 15);
            this.label_depositPrompt.TabIndex = 0;
            this.label_depositPrompt.Text = "存入金額：$";
            // 
            // textBox_deposit
            // 
            this.textBox_deposit.Location = new System.Drawing.Point(120, 16);
            this.textBox_deposit.Name = "textBox_deposit";
            this.textBox_deposit.Size = new System.Drawing.Size(100, 23);
            this.textBox_deposit.TabIndex = 1;
            // 
            // button_deposit
            // 
            this.button_deposit.Location = new System.Drawing.Point(230, 15);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(75, 25);
            this.button_deposit.TabIndex = 2;
            this.button_deposit.Text = "存入";
            this.button_deposit.UseVisualStyleBackColor = true;
            this.button_deposit.Click += new System.EventHandler(this.button_deposit_Click);
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(20, 55);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(120, 15);
            this.label_balance.TabIndex = 3;
            this.label_balance.Text = "目前餘額：$0.00";
            // 
            // label_lastWin
            // 
            this.label_lastWin.AutoSize = true;
            this.label_lastWin.Location = new System.Drawing.Point(300, 55);
            this.label_lastWin.Name = "label_lastWin";
            this.label_lastWin.Size = new System.Drawing.Size(120, 15);
            this.label_lastWin.TabIndex = 4;
            this.label_lastWin.Text = "本次獲得：$0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(160, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(300, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label_betPrompt
            // 
            this.label_betPrompt.AutoSize = true;
            this.label_betPrompt.Location = new System.Drawing.Point(20, 230);
            this.label_betPrompt.Name = "label_betPrompt";
            this.label_betPrompt.Size = new System.Drawing.Size(100, 15);
            this.label_betPrompt.TabIndex = 8;
            this.label_betPrompt.Text = "下注金額：";
            // 
            // comboBox_bet
            // 
            this.comboBox_bet.FormattingEnabled = true;
            this.comboBox_bet.Location = new System.Drawing.Point(120, 226);
            this.comboBox_bet.Name = "comboBox_bet";
            this.comboBox_bet.Size = new System.Drawing.Size(100, 23);
            this.comboBox_bet.TabIndex = 9;
            this.comboBox_bet.SelectedIndexChanged += new System.EventHandler(this.comboBox_bet_SelectedIndexChanged);
            // 
            // label_totalSpins
            // 
            this.label_totalSpins.AutoSize = true;
            this.label_totalSpins.Location = new System.Drawing.Point(20, 265);
            this.label_totalSpins.Name = "label_totalSpins";
            this.label_totalSpins.Size = new System.Drawing.Size(95, 15);
            this.label_totalSpins.TabIndex = 10;
            this.label_totalSpins.Text = "累計旋轉：0";
            // 
            // label_winCount
            // 
            this.label_winCount.AutoSize = true;
            this.label_winCount.Location = new System.Drawing.Point(160, 265);
            this.label_winCount.Name = "label_winCount";
            this.label_winCount.Size = new System.Drawing.Size(95, 15);
            this.label_winCount.TabIndex = 11;
            this.label_winCount.Text = "累計中獎：0";
            // 
            // label_winRate
            // 
            this.label_winRate.AutoSize = true;
            this.label_winRate.Location = new System.Drawing.Point(300, 265);
            this.label_winRate.Name = "label_winRate";
            this.label_winRate.Size = new System.Drawing.Size(80, 15);
            this.label_winRate.TabIndex = 12;
            this.label_winRate.Text = "勝率：0.00%";
            // 
            // button1 (旋轉)
            // 
            this.button1.Location = new System.Drawing.Point(20, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "旋轉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2 (離開)
            // 
            this.button2.Location = new System.Drawing.Point(140, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "離開";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(120, 120);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_winRate);
            this.Controls.Add(this.label_winCount);
            this.Controls.Add(this.label_totalSpins);
            this.Controls.Add(this.comboBox_bet);
            this.Controls.Add(this.label_betPrompt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_lastWin);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.button_deposit);
            this.Controls.Add(this.textBox_deposit);
            this.Controls.Add(this.label_depositPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "水果轉盤";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}