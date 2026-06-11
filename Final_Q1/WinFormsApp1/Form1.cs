using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // 每一筆摩斯碼資料，使用 struct 儲存：字元與對應的摩斯代碼
        private struct MorseEntry
        {
            // 儲存對應的字元（例如 'A', '1', 或空白 ' '）
            public char Character;
            // 儲存摩斯碼字串（例如 ".-" 或 "-----"，空白以 "/" 表示）
            public string Code;
        }

        // 使用 List 儲存整張摩斯密碼表（題目要求不可使用 Dictionary）
        private List<MorseEntry> morseTable = new List<MorseEntry>();

        public Form1()
        {
            InitializeComponent();
            LoadMorseTable();
        }

        private void LoadMorseTable()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "morse_code_table.md");
            if (!File.Exists(path))
            {
                MessageBox.Show($"找不到 morse_code_table.md 檔案：{path}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 以 File.OpenText 開啟檔案並使用 StreamReader 讀取
            using (StreamReader inputFile = File.OpenText(path))
            {
                // 使用 !inputFile.EndOfStream 判斷是否還有未讀取資料
                while (!inputFile.EndOfStream)
                {
                    string line = inputFile.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // 支援兩種表格格式：
                    // 1) Markdown pipe table (每行以 '|' 分隔欄位)
                    // 2) 單行格式如: "A .-"
                    if (line.TrimStart().StartsWith("|"))
                    {
                        // 跳過表頭或分隔列
                        var headerStart = line.TrimStart();
                        if (headerStart.StartsWith("| Character", StringComparison.OrdinalIgnoreCase)
                            || headerStart.StartsWith("| :---"))
                        {
                            continue;
                        }

                        // 以 '|' 分割欄位，並取出非空白的欄位內容
                        var cols = line.Split('|').Select(p => p.Trim()).Where(p => p.Length > 0).ToArray();
                        // 欄位是成對出現 (Character, Code)，所以逐兩個一組處理
                        for (int i = 0; i + 1 < cols.Length; i += 2)
                        {
                            string charText = cols[i];
                            string codeText = cols[i + 1];
                            if (string.IsNullOrEmpty(charText) || string.IsNullOrEmpty(codeText))
                                continue;

                            // 移除 code 兩側可能的反引號 `...
                            codeText = codeText.Trim();
                            if (codeText.StartsWith("`") && codeText.EndsWith("`"))
                                codeText = codeText.Substring(1, codeText.Length - 2);

                            char ch;
                            if (charText.Equals("space", StringComparison.OrdinalIgnoreCase))
                            {
                                ch = ' ';
                                if (codeText.Equals("*space*", StringComparison.OrdinalIgnoreCase))
                                    codeText = "/";
                            }
                            else if (charText.Length == 1)
                            {
                                ch = charText[0];
                                if (char.IsLetter(ch))
                                    ch = char.ToUpperInvariant(ch);
                            }
                            else
                            {
                                if (charText.Equals("comma", StringComparison.OrdinalIgnoreCase))
                                    ch = ',';
                                else if (charText.Equals("period", StringComparison.OrdinalIgnoreCase))
                                    ch = '.';
                                else if (charText.Equals("?", StringComparison.OrdinalIgnoreCase) || charText.Equals("question", StringComparison.OrdinalIgnoreCase))
                                    ch = '?';
                                else
                                    continue;
                            }

                            if (!morseTable.Any(e => e.Character == ch))
                            {
                                morseTable.Add(new MorseEntry { Character = ch, Code = codeText });
                            }
                        }
                    }
                    else
                    {
                        // 每行格式預期為: "A .-" 或 "0 -----"
                        var parts = line.Trim().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length < 2)
                            continue;

                        string key = parts[0];
                        string code = parts[1];

                        char ch;
                        if (key.Equals("space", StringComparison.OrdinalIgnoreCase))
                        {
                            ch = ' ';
                            if (string.IsNullOrEmpty(code) || code == "*space*")
                                code = "/";
                        }
                        else if (key.Length == 1)
                        {
                            ch = key[0];
                            if (char.IsLetter(ch))
                                ch = char.ToUpperInvariant(ch);
                        }
                        else
                        {
                            if (key.Equals("comma", StringComparison.OrdinalIgnoreCase))
                                ch = ',';
                            else if (key.Equals("period", StringComparison.OrdinalIgnoreCase))
                                ch = '.';
                            else if (key.Equals("question", StringComparison.OrdinalIgnoreCase) || key == "?")
                                ch = '?';
                            else
                                continue;
                        }

                        if (!morseTable.Any(e => e.Character == ch))
                        {
                            morseTable.Add(new MorseEntry { Character = ch, Code = code });
                        }
                    }
                }
            }

            // ensure space mapping exists
            if (!morseTable.Any(e => e.Character == ' '))
            {
                morseTable.Add(new MorseEntry { Character = ' ', Code = "/" });
            }
        }

        private void ButtonConvert_Click(object? sender, EventArgs e)
        {
            listBoxLookup.Items.Clear();
            textBoxFullMorse.Clear();

            string input = textBoxInput.Text;
            if (string.IsNullOrEmpty(input))
                return;

            List<string> morsePieces = new List<string>();

            foreach (char raw in input)
            {
                char ch = raw;
                if (char.IsLetter(ch))
                    ch = char.ToUpperInvariant(ch);

                var entry = morseTable.FirstOrDefault(m => m.Character == ch);
                if (!string.IsNullOrEmpty(entry.Code))
                {
                    morsePieces.Add(entry.Code);
                    string displayChar = ch == ' ' ? "空白" : ch.ToString();
                    listBoxLookup.Items.Add($"{displayChar}  {entry.Code}");
                }
                else
                {
                    morsePieces.Add("?");
                    listBoxLookup.Items.Add($"{ch}  (無對應)");
                }
            }

            textBoxFullMorse.Text = string.Join(" ", morsePieces);
        }

        private void ButtonClear_Click(object? sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxFullMorse.Clear();
            listBoxLookup.Items.Clear();
        }
    }
}
