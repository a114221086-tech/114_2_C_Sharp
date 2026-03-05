namespace Review_Q2
{
    /// <summary>
    /// 維修服務費用常數定義
    /// </summary>
    public static class RepairServiceConstants
    {
        // 機油與潤滑服務
        public const decimal OIL_CHANGE_PRICE = 780m;
        public const decimal OIL_FILTER_PRICE = 540m;

        // 清洗服務
        public const decimal WATER_WASH_PRICE = 900m;
        public const decimal TRANSMISSION_OIL_CLEAN_PRICE = 2400m;

        // 其他維修服務
        public const decimal INSPECTION_PRICE = 450m;
        public const decimal MUFFLER_REPLACEMENT_PRICE = 3000m;
        public const decimal TIRE_ROTATION_PRICE = 600m;

        // 工時和稅金
        public const decimal LABOR_HOURLY_RATE = 600m;
        public const decimal TAX_RATE = 0.06m; // 6%
    }

    /// <summary>
    /// 維修服務費用計算類別
    /// </summary>
    public class CostCalculator
    {
        /// <summary>
        /// 計算所有選定服務的費用總額
        /// </summary>
        /// <param name="selectedServices">選定的服務費用清單</param>
        /// <returns>服務費用總額</returns>
        public decimal CalculateServiceCost(params decimal[] selectedServices)
        {
            return selectedServices.Sum();
        }

        /// <summary>
        /// 計算工資費用
        /// </summary>
        /// <param name="laborHours">工時數</param>
        /// <returns>工資總額</returns>
        public decimal CalculateLaborCost(decimal laborHours)
        {
            if (laborHours < 0)
                throw new ArgumentException("工時數不能為負數");
            
            return laborHours * RepairServiceConstants.LABOR_HOURLY_RATE;
        }

        /// <summary>
        /// 計算零件稅金
        /// </summary>
        /// <param name="partsCost">零件費用</param>
        /// <returns>稅金額度</returns>
        public decimal CalculatePartsTax(decimal partsCost)
        {
            if (partsCost < 0)
                throw new ArgumentException("零件費用不能為負數");
            
            return partsCost * RepairServiceConstants.TAX_RATE;
        }

        /// <summary>
        /// 計算服務與工資的總額
        /// </summary>
        /// <param name="serviceCost">服務費用</param>
        /// <param name="laborCost">工資費用</param>
        /// <returns>服務與工資總額</returns>
        public decimal CalculateServiceAndLaborTotal(decimal serviceCost, decimal laborCost)
        {
            return serviceCost + laborCost;
        }

        /// <summary>
        /// 計算最終總費用
        /// </summary>
        /// <param name="serviceAndLaborTotal">服務與工資總額</param>
        /// <param name="partsCost">零件費用</param>
        /// <param name="taxCost">稅金</param>
        /// <returns>最終總費用</returns>
        public decimal CalculateTotalCost(decimal serviceAndLaborTotal, decimal partsCost, decimal taxCost)
        {
            return serviceAndLaborTotal + partsCost + taxCost;
        }

        /// <summary>
        /// 驗證輸入值是否為有效的數字
        /// </summary>
        /// <param name="value">輸入值</param>
        /// <param name="result">轉換後的結果</param>
        /// <returns>是否轉換成功</returns>
        public bool TryParseAmount(string value, out decimal result)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                result = 0;
                return true;
            }

            return decimal.TryParse(value, out result) && result >= 0;
        }
    }

    /// <summary>
    /// 報表數據模型
    /// </summary>
    public class RepairReport
    {
        public DateTime ReportDate { get; set; }
        public List<string> SelectedServices { get; set; }
        public decimal PartsAmount { get; set; }
        public decimal LaborHours { get; set; }
        public decimal ServiceCost { get; set; }
        public decimal LaborCost { get; set; }
        public decimal PartsCost { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalCost { get; set; }

        public RepairReport()
        {
            ReportDate = DateTime.Now;
            SelectedServices = new List<string>();
        }

        /// <summary>
        /// 生成報表文本
        /// </summary>
        /// <returns>格式化的報表文本</returns>
        public string GenerateReportText()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("========================================");
            sb.AppendLine("        汽車維修費用計算報表");
            sb.AppendLine("========================================");
            sb.AppendLine($"報表日期: {ReportDate:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine();

            sb.AppendLine("【已選服務項目】");
            if (SelectedServices.Count > 0)
            {
                foreach (var service in SelectedServices)
                {
                    sb.AppendLine($"  ? {service}");
                }
            }
            else
            {
                sb.AppendLine("  (無)");
            }
            sb.AppendLine();

            sb.AppendLine("【零件與工時】");
            sb.AppendLine($"  零件費用: NT${PartsCost:N0}");
            sb.AppendLine($"  工時: {LaborHours} 小時 @ NT${RepairServiceConstants.LABOR_HOURLY_RATE}/小時");
            sb.AppendLine();

            sb.AppendLine("【費用明細】");
            sb.AppendLine($"  服務費用: NT${ServiceCost:N0}");
            sb.AppendLine($"  工資費用: NT${LaborCost:N0}");
            sb.AppendLine($"  ─────────────────");
            sb.AppendLine($"  服務與工資合計: NT${(ServiceCost + LaborCost):N0}");
            sb.AppendLine();
            sb.AppendLine($"  零件費用: NT${PartsCost:N0}");
            sb.AppendLine($"  零件稅金 (6%): NT${TaxAmount:N0}");
            sb.AppendLine($"  ═════════════════");
            sb.AppendLine($"  【最終總費用】: NT${TotalCost:N0}");
            sb.AppendLine("========================================");

            return sb.ToString();
        }
    }
}
