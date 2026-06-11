using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class DeleteEmployeeForm : Form
    {
        private TextBox textId;
        private Button btnDelete;
        private Button btnClose;
        private ListBox listBoxPreview;

        public DeleteEmployeeForm()
        {
            this.Text = "刪除員工";
            this.ClientSize = new System.Drawing.Size(500, 360);

            var lblTitle = new Label { Text = "刪除員工", Font = new System.Drawing.Font("微軟正黑體", 18F), AutoSize = true, Location = new System.Drawing.Point(20, 10) };
            this.Controls.Add(lblTitle);

            var lblId = new Label { Text = "員工編號：", Location = new System.Drawing.Point(20, 60), AutoSize = true };
            textId = new TextBox { Location = new System.Drawing.Point(120, 56), Width = 200 };
            this.Controls.Add(lblId);
            this.Controls.Add(textId);

            btnDelete = new Button { Text = "刪除", Location = new System.Drawing.Point(120, 96), Size = new System.Drawing.Size(100, 30) };
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            btnClose = new Button { Text = "離開", Location = new System.Drawing.Point(240, 96), Size = new System.Drawing.Size(100, 30) };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);

            listBoxPreview = new ListBox { Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(460, 200) };
            this.Controls.Add(listBoxPreview);

            RefreshPreview();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(textId.Text.Trim(), out int id))
            {
                MessageBox.Show("請輸入數字員工編號。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emp = EmployeeStore.Employees.FirstOrDefault(x => x.IdNumber == id);
            if (emp == null)
            {
                MessageBox.Show("找不到該員工。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"確定要刪除 {emp.IdNumber} - {emp.Name} 嗎?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                EmployeeStore.Employees.Remove(emp);
                RefreshPreview();
                MessageBox.Show("刪除完成。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshPreview()
        {
            listBoxPreview.Items.Clear();
            foreach (var emp in EmployeeStore.Employees.OrderBy(x => x.IdNumber))
                listBoxPreview.Items.Add(emp);
        }
    }
}
