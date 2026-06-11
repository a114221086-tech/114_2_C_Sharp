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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonSearch = new Button();
            buttonExit = new Button();
            listBoxEmployees = new ListBox();
            titleLabel = new Label();
            labelList = new Label();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(20, 80);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 40);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "新增員工";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(20, 140);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 40);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "刪除員工";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(20, 200);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(120, 40);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "修改員工";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(20, 260);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(120, 40);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "查詢員工";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(20, 320);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(120, 40);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "離開";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.Location = new Point(160, 80);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(480, 326);
            listBoxEmployees.TabIndex = 5;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("微軟正黑體", 24F);
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(315, 61);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "員工資料管理";
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Location = new Point(160, 56);
            labelList.Name = "labelList";
            labelList.Size = new Size(154, 23);
            labelList.TabIndex = 7;
            labelList.Text = "員工編號與姓名：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(labelList);
            Controls.Add(titleLabel);
            Controls.Add(listBoxEmployees);
            Controls.Add(buttonExit);
            Controls.Add(buttonSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "EmployeeRoster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label labelList;
    }
}
