using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class AddEmployeeForm : Form
    {
        private TextBox textId;
        private TextBox textName;
        private TextBox textDept;
        private TextBox textPos;
        private Button btnAdd;
        private Button btnClose;
        private ListBox listBoxPreview;

        public AddEmployeeForm()
        {
            this.Text = "新增員工";
            this.ClientSize = new System.Drawing.Size(500, 400);

            var lblTitle = new Label { Text = "新增員工", Font = new System.Drawing.Font("微軟正黑體", 18F), AutoSize = true, Location = new System.Drawing.Point(20, 10) };
            this.Controls.Add(lblTitle);

            var lblId = new Label { Text = "員工編號：", Location = new System.Drawing.Point(20, 60), AutoSize = true };
            textId = new TextBox { Location = new System.Drawing.Point(120, 56), Width = 200 };
            this.Controls.Add(lblId);
            this.Controls.Add(textId);

            var lblName = new Label { Text = "姓名：", Location = new System.Drawing.Point(20, 100), AutoSize = true };
            textName = new TextBox { Location = new System.Drawing.Point(120, 96), Width = 200 };
            this.Controls.Add(lblName);
            this.Controls.Add(textName);

            var lblDept = new Label { Text = "部門：", Location = new System.Drawing.Point(20, 140), AutoSize = true };
            textDept = new TextBox { Location = new System.Drawing.Point(120, 136), Width = 200 };
            this.Controls.Add(lblDept);
            this.Controls.Add(textDept);

            var lblPos = new Label { Text = "職稱：", Location = new System.Drawing.Point(20, 180), AutoSize = true };
            textPos = new TextBox { Location = new System.Drawing.Point(120, 176), Width = 200 };
            this.Controls.Add(lblPos);
            this.Controls.Add(textPos);

            btnAdd = new Button { Text = "新增", Location = new System.Drawing.Point(120, 220), Size = new System.Drawing.Size(100, 30) };
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            btnClose = new Button { Text = "離開", Location = new System.Drawing.Point(240, 220), Size = new System.Drawing.Size(100, 30) };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);

            listBoxPreview = new ListBox { Location = new System.Drawing.Point(20, 260), Size = new System.Drawing.Size(460, 120) };
            this.Controls.Add(listBoxPreview);
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號需為數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var name = textName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("請輸入姓名。", "資料不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EmployeeStore.Employees.Exists(x => x.IdNumber == id))
            {
                MessageBox.Show("員工編號已存在。", "重複", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emp = new Employee(name, id, textDept.Text.Trim(), textPos.Text.Trim());
            EmployeeStore.Employees.Add(emp);
            listBoxPreview.Items.Add(emp);
            MessageBox.Show("新增完成。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void ClearInputs()
        {
            textId.Text = string.Empty;
            textName.Text = string.Empty;
            textDept.Text = string.Empty;
            textPos.Text = string.Empty;
        }
    }
}
