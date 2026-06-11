namespace WinFormsApp1
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int IdNumber { get; set; }
        public string Department { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;

        // 礚把计篶
        public Employee()
        {
            Name = string.Empty;
            IdNumber = 0;
            Department = string.Empty;
            Position = string.Empty;
        }

        // ㄢ把计篶 - 砞﹚ Name, IdNumber
        public Employee(string name, int idNumber)
        {
            Name = name;
            IdNumber = idNumber;
            Department = string.Empty;
            Position = string.Empty;
        }

        // 把计篶
        public Employee(string name, int idNumber, string department, string position)
        {
            Name = name;
            IdNumber = idNumber;
            Department = department;
            Position = position;
        }

        public override string ToString()
        {
            // 陪ボΑIdNumber|Name|Department|Position
            return $"{IdNumber}|{Name}|{Department}|{Position}";
        }
    }
}
