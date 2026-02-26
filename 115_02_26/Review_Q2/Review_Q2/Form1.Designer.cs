namespace Review_Q2
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
            this.components = new System.ComponentModel.Container();
            
            // 標題
            Label titleLabel = new Label();
            titleLabel.Text = "汽車維修修飾";
            titleLabel.Font = new Font("Microsoft YaHei", 12, FontStyle.Bold);
            titleLabel.Location = new Point(10, 10);
            titleLabel.Size = new Size(250, 25);

            // ===== 機油相關服務區塊 =====
            GroupBox engineOilGroup = new GroupBox();
            engineOilGroup.Text = "機油相關服務";
            engineOilGroup.Location = new Point(10, 40);
            engineOilGroup.Size = new Size(250, 120);

            CheckBox chkOilChange = new CheckBox();
            chkOilChange.Text = "更換機油 (NT$780)";
            chkOilChange.Location = new Point(10, 25);
            chkOilChange.Size = new Size(220, 20);
            chkOilChange.Tag = 780;

            CheckBox chkOilFilter = new CheckBox();
            chkOilFilter.Text = "潤滑保養 (NT$540)";
            chkOilFilter.Location = new Point(10, 50);
            chkOilFilter.Size = new Size(220, 20);
            chkOilFilter.Tag = 540;

            engineOilGroup.Controls.Add(chkOilChange);
            engineOilGroup.Controls.Add(chkOilFilter);

            // ===== 其他服務區塊 =====
            GroupBox otherServicesGroup = new GroupBox();
            otherServicesGroup.Text = "其他服務";
            otherServicesGroup.Location = new Point(10, 165);
            otherServicesGroup.Size = new Size(250, 120);

            CheckBox chkEngineClean = new CheckBox();
            chkEngineClean.Text = "機械 (NT$450)";
            chkEngineClean.Location = new Point(10, 25);
            chkEngineClean.Size = new Size(220, 20);
            chkEngineClean.Tag = 450;

            CheckBox chkBrakeFluid = new CheckBox();
            chkBrakeFluid.Text = "煞車油溶液 (NT$3,000)";
            chkBrakeFluid.Location = new Point(10, 50);
            chkBrakeFluid.Size = new Size(220, 20);
            chkBrakeFluid.Tag = 3000;

            CheckBox chkTransmissionOil = new CheckBox();
            chkTransmissionOil.Text = "變速機油 (NT$600)";
            chkTransmissionOil.Location = new Point(10, 75);
            chkTransmissionOil.Size = new Size(220, 20);
            chkTransmissionOil.Tag = 600;

            otherServicesGroup.Controls.Add(chkEngineClean);
            otherServicesGroup.Controls.Add(chkBrakeFluid);
            otherServicesGroup.Controls.Add(chkTransmissionOil);

            // ===== 清洗服務區塊 =====
            GroupBox cleaningGroup = new GroupBox();
            cleaningGroup.Text = "清洗服務";
            cleaningGroup.Location = new Point(270, 40);
            cleaningGroup.Size = new Size(250, 120);

            CheckBox chkWaterWash = new CheckBox();
            chkWaterWash.Text = "水槍清洗 (NT$900)";
            chkWaterWash.Location = new Point(10, 25);
            chkWaterWash.Size = new Size(220, 20);
            chkWaterWash.Tag = 900;

            CheckBox chkSteamWash = new CheckBox();
            chkSteamWash.Text = "蒸機蒸洗 (NT$2,400)";
            chkSteamWash.Location = new Point(10, 50);
            chkSteamWash.Size = new Size(220, 20);
            chkSteamWash.Tag = 2400;

            cleaningGroup.Controls.Add(chkWaterWash);
            cleaningGroup.Controls.Add(chkSteamWash);

            // ===== 零件材工費區塊 =====
            GroupBox partsGroup = new GroupBox();
            partsGroup.Text = "零件材工費";
            partsGroup.Location = new Point(270, 165);
            partsGroup.Size = new Size(250, 120);

            Label lblPartLabel = new Label();
            lblPartLabel.Text = "零件 (NT$)";
            lblPartLabel.Location = new Point(10, 25);
            lblPartLabel.Size = new Size(100, 20);

            TextBox txtParts = new TextBox();
            txtParts.Location = new Point(120, 25);
            txtParts.Size = new Size(110, 25);
            txtParts.Tag = "parts";

            Label lblLaborLabel = new Label();
            lblLaborLabel.Text = "工資費 (小時)";
            lblLaborLabel.Location = new Point(10, 55);
            lblLaborLabel.Size = new Size(100, 20);

            TextBox txtLabor = new TextBox();
            txtLabor.Location = new Point(120, 55);
            txtLabor.Size = new Size(110, 25);
            txtLabor.Tag = "labor";

            partsGroup.Controls.Add(lblPartLabel);
            partsGroup.Controls.Add(txtParts);
            partsGroup.Controls.Add(lblLaborLabel);
            partsGroup.Controls.Add(txtLabor);

            // ===== 費用概要區塊 =====
            GroupBox summaryGroup = new GroupBox();
            summaryGroup.Text = "費用概要";
            summaryGroup.Location = new Point(530, 40);
            summaryGroup.Size = new Size(250, 245);

            Label lblServiceCostLabel = new Label();
            lblServiceCostLabel.Text = "服務與工資";
            lblServiceCostLabel.Location = new Point(10, 25);
            lblServiceCostLabel.Size = new Size(120, 20);

            TextBox txtServiceCost = new TextBox();
            txtServiceCost.Location = new Point(140, 25);
            txtServiceCost.Size = new Size(100, 25);
            txtServiceCost.ReadOnly = true;
            txtServiceCost.Tag = "serviceCost";

            Label lblPartsCostLabel = new Label();
            lblPartsCostLabel.Text = "零件";
            lblPartsCostLabel.Location = new Point(10, 60);
            lblPartsCostLabel.Size = new Size(120, 20);

            TextBox txtPartsCost = new TextBox();
            txtPartsCost.Location = new Point(140, 60);
            txtPartsCost.Size = new Size(100, 25);
            txtPartsCost.ReadOnly = true;
            txtPartsCost.Tag = "partsCost";

            Label lblLaborCostLabel = new Label();
            lblLaborCostLabel.Text = "稅金 (零件)";
            lblLaborCostLabel.Location = new Point(10, 95);
            lblLaborCostLabel.Size = new Size(120, 20);

            TextBox txtLaborCost = new TextBox();
            txtLaborCost.Location = new Point(140, 95);
            txtLaborCost.Size = new Size(100, 25);
            txtLaborCost.ReadOnly = true;
            txtLaborCost.Tag = "laborCost";

            Label lblCleanupsLabel = new Label();
            lblCleanupsLabel.Text = "總費用";
            lblCleanupsLabel.Location = new Point(10, 130);
            lblCleanupsLabel.Size = new Size(120, 20);

            TextBox txtCleanups = new TextBox();
            txtCleanups.Location = new Point(140, 130);
            txtCleanups.Size = new Size(100, 25);
            txtCleanups.ReadOnly = true;
            txtCleanups.Font = new Font("Microsoft YaHei", 10, FontStyle.Bold);
            txtCleanups.Tag = "cleanups";

            summaryGroup.Controls.Add(lblServiceCostLabel);
            summaryGroup.Controls.Add(txtServiceCost);
            summaryGroup.Controls.Add(lblPartsCostLabel);
            summaryGroup.Controls.Add(txtPartsCost);
            summaryGroup.Controls.Add(lblLaborCostLabel);
            summaryGroup.Controls.Add(txtLaborCost);
            summaryGroup.Controls.Add(lblCleanupsLabel);
            summaryGroup.Controls.Add(txtCleanups);

            // ===== 按鈕區塊 =====
            Button btnCalculate = new Button();
            btnCalculate.Text = "計算總額";
            btnCalculate.Location = new Point(100, 320);
            btnCalculate.Size = new Size(80, 35);
            btnCalculate.Click += (s, e) => CalculateTotal(engineOilGroup, otherServicesGroup, cleaningGroup, partsGroup, summaryGroup);

            Button btnClear = new Button();
            btnClear.Text = "清除";
            btnClear.Location = new Point(220, 320);
            btnClear.Size = new Size(80, 35);
            btnClear.Click += (s, e) => ClearAll(engineOilGroup, otherServicesGroup, cleaningGroup, partsGroup, summaryGroup);

            Button btnExit = new Button();
            btnExit.Text = "關閉";
            btnExit.Location = new Point(340, 320);
            btnExit.Size = new Size(80, 35);
            btnExit.Click += (s, e) => this.Close();

            // 將控制項添加到表單
            this.Controls.Add(titleLabel);
            this.Controls.Add(engineOilGroup);
            this.Controls.Add(otherServicesGroup);
            this.Controls.Add(cleaningGroup);
            this.Controls.Add(partsGroup);
            this.Controls.Add(summaryGroup);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnExit);

            // 表單設置
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Text = "汽車維修修飾";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CalculateTotal(GroupBox engineOilGroup, GroupBox otherServicesGroup, 
                                    GroupBox cleaningGroup, GroupBox partsGroup, GroupBox summaryGroup)
        {
            decimal serviceTotal = 0;
            decimal partsTotal = 0;
            decimal laborTotal = 0;

            // 計算服務費用
            foreach (Control control in engineOilGroup.Controls)
            {
                if (control is CheckBox chk && chk.Checked && chk.Tag is int cost)
                {
                    serviceTotal += cost;
                }
            }

            foreach (Control control in otherServicesGroup.Controls)
            {
                if (control is CheckBox chk && chk.Checked && chk.Tag is int cost)
                {
                    serviceTotal += cost;
                }
            }

            foreach (Control control in cleaningGroup.Controls)
            {
                if (control is CheckBox chk && chk.Checked && chk.Tag is int cost)
                {
                    serviceTotal += cost;
                }
            }

            // 計算零件費用
            TextBox txtParts = partsGroup.Controls.Cast<Control>()
                .FirstOrDefault(c => c is TextBox && c.Tag?.ToString() == "parts") as TextBox;
            TextBox txtLabor = partsGroup.Controls.Cast<Control>()
                .FirstOrDefault(c => c is TextBox && c.Tag?.ToString() == "labor") as TextBox;

            if (txtParts != null && decimal.TryParse(txtParts.Text, out decimal parts))
            {
                partsTotal = parts;
            }

            if (txtLabor != null && decimal.TryParse(txtLabor.Text, out decimal laborHours))
            {
                laborTotal = laborHours * 1500; // 假設時薪為NT$1,500
            }

            decimal totalCost = serviceTotal + partsTotal + laborTotal;

            // 更新顯示
            TextBox txtServiceCost = summaryGroup.Controls.Cast<Control>()
                .FirstOrDefault(c => c is TextBox && c.Tag?.ToString() == "serviceCost") as TextBox;
            TextBox txtPartsCost = summaryGroup.Controls.Cast<Control>()
                .FirstOrDefault(c => c is TextBox && c.Tag?.ToString() == "partsCost") as TextBox;
            TextBox txtLaborCost = summaryGroup.Controls.Cast<Control>()
                .FirstOrDefault(c => c is TextBox && c.Tag?.ToString() == "laborCost") as TextBox;
            TextBox txtCleanups = summaryGroup.Controls.Cast<Control>()
                .FirstOrDefault(c => c is TextBox && c.Tag?.ToString() == "cleanups") as TextBox;

            if (txtServiceCost != null) txtServiceCost.Text = serviceTotal.ToString("N0");
            if (txtPartsCost != null) txtPartsCost.Text = partsTotal.ToString("N0");
            if (txtLaborCost != null) txtLaborCost.Text = laborTotal.ToString("N0");
            if (txtCleanups != null) txtCleanups.Text = totalCost.ToString("N0");
        }

        private void ClearAll(GroupBox engineOilGroup, GroupBox otherServicesGroup, 
                             GroupBox cleaningGroup, GroupBox partsGroup, GroupBox summaryGroup)
        {
            // 取消所有複選框
            foreach (Control control in engineOilGroup.Controls)
                if (control is CheckBox chk) chk.Checked = false;

            foreach (Control control in otherServicesGroup.Controls)
                if (control is CheckBox chk) chk.Checked = false;

            foreach (Control control in cleaningGroup.Controls)
                if (control is CheckBox chk) chk.Checked = false;

            // 清除文字方塊
            TextBox txtParts = partsGroup.Controls.Cast<Control>()
                .FirstOrDefault(c => c is TextBox && c.Tag?.ToString() == "parts") as TextBox;
            TextBox txtLabor = partsGroup.Controls.Cast<Control>()
                .FirstOrDefault(c => c is TextBox && c.Tag?.ToString() == "labor") as TextBox;

            if (txtParts != null) txtParts.Clear();
            if (txtLabor != null) txtLabor.Clear();

            // 清除費用顯示
            foreach (Control control in summaryGroup.Controls)
                if (control is TextBox && control.Tag != null)
                    ((TextBox)control).Clear();
        }

        #endregion
    }
}
