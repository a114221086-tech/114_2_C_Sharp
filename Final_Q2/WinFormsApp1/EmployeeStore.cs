using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WinFormsApp1
{
    public static class EmployeeStore
    {
        public static List<Employee> Employees { get; } = new List<Employee>();

        public static void LoadFromFile(string path)
        {
            Employees.Clear();
            if (!File.Exists(path)) return;

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split('|');
                if (parts.Length < 4) continue;
                if (!int.TryParse(parts[0], out int id)) continue;
                var name = parts[1];
                var dept = parts[2];
                var pos = parts[3];
                Employees.Add(new Employee(name, id, dept, pos));
            }
        }

        public static void SaveToFile(string path)
        {
            var lines = Employees.Select(e => $"{e.IdNumber}|{e.Name}|{e.Department}|{e.Position}");
            File.WriteAllLines(path, lines);
        }
    }
}
