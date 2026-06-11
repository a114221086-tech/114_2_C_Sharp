using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class UpdateEmployeeForm : Form
    {
        private TextBox textId;
        private TextBox textName;
        private TextBox textDept;
        private TextBox textPos;
        private Button btnFind;
        private Button btnSave;
        private Button btnClose;
        private ListBox listBoxPreview;

        public UpdateEmployeeForm()
        {
            this.Text = "修改員工資料";
            this.ClientSize = new System.Drawing.Size(600, 500);

            var lblTitle = new Label { Text = "修改員工資料", Font = new System.Drawing.Font("微軟正黑體", 24F), AutoSize = true, Location = new System.Drawing.Point(20, 10) };
            this.Controls.Add(lblTitle);

            var lblId = new Label { Text = "員工編號：", Location = new System.Drawing.Point(20, 80), AutoSize = true };
            textId = new TextBox { Location = new System.Drawing.Point(140, 76), Width = 360 };
            this.Controls.Add(lblId);
            this.Controls.Add(textId);

            btnFind = new Button { Text = "查詢", Location = new System.Drawing.Point(260, 120), Size = new System.Drawing.Size(100, 32) };
            btnFind.Click += BtnFind_Click;
            this.Controls.Add(btnFind);

            var lblName = new Label { Text = "姓名：", Location = new System.Drawing.Point(20, 170), AutoSize = true };
            textName = new TextBox { Location = new System.Drawing.Point(140, 166), Width = 360 };
            this.Controls.Add(lblName);
            this.Controls.Add(textName);

            var lblDept = new Label { Text = "部門：", Location = new System.Drawing.Point(20, 210), AutoSize = true };
            textDept = new TextBox { Location = new System.Drawing.Point(140, 206), Width = 360 };
            this.Controls.Add(lblDept);
            this.Controls.Add(textDept);

            var lblPos = new Label { Text = "職稱：", Location = new System.Drawing.Point(20, 250), AutoSize = true };
            textPos = new TextBox { Location = new System.Drawing.Point(140, 246), Width = 360 };
            this.Controls.Add(lblPos);
            this.Controls.Add(textPos);

            btnSave = new Button { Text = "儲存", Location = new System.Drawing.Point(200, 300), Size = new System.Drawing.Size(100, 36) };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            btnClose = new Button { Text = "離開", Location = new System.Drawing.Point(320, 300), Size = new System.Drawing.Size(100, 36) };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);

            listBoxPreview = new ListBox { Location = new System.Drawing.Point(20, 360), Size = new System.Drawing.Size(540, 120) };
            this.Controls.Add(listBoxPreview);

            RefreshPreview();
        }

        private void BtnFind_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號需為數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emp = EmployeeStore.Employees.FirstOrDefault(x => x.IdNumber == id);
            if (emp == null)
            {
                MessageBox.Show("找不到該員工。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            textName.Text = emp.Name;
            textDept.Text = emp.Department;
            textPos.Text = emp.Position;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textId.Text.Trim(), out int id))
            {
                MessageBox.Show("員工編號需為數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emp = EmployeeStore.Employees.FirstOrDefault(x => x.IdNumber == id);
            if (emp == null)
            {
                MessageBox.Show("找不到該員工。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var name = textName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("姓名不可為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            emp.Name = name;
            emp.Department = textDept.Text.Trim();
            emp.Position = textPos.Text.Trim();

            RefreshPreview();
            MessageBox.Show("儲存完成。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshPreview()
        {
            listBoxPreview.Items.Clear();
            foreach (var emp in EmployeeStore.Employees.OrderBy(x => x.IdNumber))
                listBoxPreview.Items.Add(emp);
        }
    }
}
