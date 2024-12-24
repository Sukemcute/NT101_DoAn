using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Unidecode.NET;

namespace NT101_PJ
{
    public partial class PlayFairForm : Form
    {
        private int matrixSize = 5;
        private Button[,] arrayMatrix;
        private List<string> alphabet;
        private bool separateDuplicatesFS = true;
        private bool separateDuplicateLetters = true;
        private string firstSeparator = "X";
        private string secondSeparator = "Y";
        private bool ignoreDuplicateLetters = true;

        public PlayFairForm()
        {
            InitializeComponent();
            InitializePlayFair();

            // Thiết lập các tùy chọn mặc định
            rBtnSeparateDuplicates.Checked = separateDuplicateLetters;
            rBtnSeparateDuplicatesFS.Checked = separateDuplicatesFS;
            rBtnIgnoreDuplicates.Checked = ignoreDuplicateLetters;
            textFirstSeparator.Text = firstSeparator;
            textSecondSeparator.Text = secondSeparator;
        }

        private void InitializePlayFair()
        {
            alphabet = new List<string>();
            arrayMatrix = new Button[6, 6];
            InitMatrix(matrixSize);

            textKey.KeyPress += Matrix5_KeyPress;
            rBtn5x5.CheckedChanged += RadioButtons_CheckedChanged;
            rBtn6x6.CheckedChanged += RadioButtons_CheckedChanged;
            textKey.TextChanged += textKey_TextChanged; // Đăng ký sự kiện TextChanged
        }

        private void PlayFair_Load(object sender, EventArgs e) { }

        private string PreparePlainText(int size)
        {
            string text = textMessage.Text?.Trim();
            if (string.IsNullOrEmpty(text)) return string.Empty;

            if (separateDuplicateLetters)
            {
                text = Regex.Replace(text.Unidecode().ToUpperInvariant(), size == 5 ? "[^A-Z]" : "[^A-Z0-9]", "");
                if (size == 5) text = text.Replace("J", "I");
                text = Regex.Replace(text, "([A-Z])\\1", "$1" + firstSeparator);
            }
            else
            {
                text = Regex.Replace(text.Unidecode().ToUpperInvariant(), "[^A-Z]", "");
            }

            return text.Length % 2 == 0 ? text : text + "X";
        }

        private string DistinctString(string input) => string.Concat(input.Distinct());

        private void ModifyMatrix(int startRow, int startCol, string replacement)
        {
            List<string> newAlphabet = new List<string>(alphabet);
            foreach (char c in replacement) newAlphabet.Remove(c.ToString());

            if (newAlphabet.Count < (matrixSize * matrixSize - startRow * matrixSize - startCol))
            {
                throw new InvalidOperationException("Matrix cannot be completed with the given alphabet.");
            }

            for (int i = startRow, index = 0; i < matrixSize; i++)
            {
                for (int j = (i == startRow) ? startCol : 0; j < matrixSize; j++)
                {
                    arrayMatrix[i, j].Text = newAlphabet[index % newAlphabet.Count];
                    index++;
                }
            }
        }

        private void ReplaceOnMatrix(string text)
        {
            text = DistinctString(text);
            int row = 0, col = 0;
            foreach (char c in text)
            {
                arrayMatrix[row, col].Text = c.ToString();
                col++;
                if (col >= matrixSize)
                {
                    col = 0;
                    row++;
                }
            }
            ModifyMatrix(row, col, text);
        }

        private void Matrix5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), "^[A-IK-Z]$");
        }

        private void Matrix6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), "^[A-Z0-9]$");
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            matrixSize = ((RadioButton)sender) == rBtn5x5 ? 5 : 6;
            panel1.Controls.Clear();
            InitMatrix(matrixSize);
            ValidateKeyInput();

            textKey.Clear();
            textResult.Clear();

            textKey.KeyPress -= Matrix6_KeyPress;
            textKey.KeyPress -= Matrix5_KeyPress;
            textKey.KeyPress += matrixSize == 5 ? Matrix5_KeyPress : Matrix6_KeyPress;
        }

        private void InitMatrix(int size)
        {
            alphabet.Clear();
            arrayMatrix = new Button[size, size];

            int charNum = 65;
            int offset = 0;

            for (int i = 0; i < size; i++)
            {
                Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, offset * 30) };
                for (int j = 0; j < size; j++)
                {
                    Button btn = new Button()
                    {
                        Width = 30,
                        Height = 30,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y)
                    };

                    btn.Text = Encoding.ASCII.GetString(new byte[] { (byte)charNum });
                    alphabet.Add(btn.Text);

                    arrayMatrix[i, j] = btn;
                    panel1.Controls.Add(btn);
                    oldBtn = btn;
                    charNum++;

                    if (charNum == 74 && size == 5) charNum++;
                    if (charNum > 90) charNum = 48;
                }
                offset++;
            }
        }

        private void ValidateKeyInput()
        {
            if (textKey.Text == string.Empty) return;

            textKey.Text = Regex.Replace(textKey.Text, matrixSize == 5 ? "[^A-IK-Z]" : "[^A-Z0-9]", "");
            textKey.SelectionStart = textKey.Text.Length; // Ensure cursor is at the end.
        }

        private string EncryptPair(string pair)
        {
            return ProcessPair(pair, (r, c) => (r + 1) % matrixSize, (c) => (c + 1) % matrixSize);
        }

        private string DecryptPair(string pair)
        {
            return ProcessPair(pair, (r, c) => (r - 1 + matrixSize) % matrixSize, (c) => (c - 1 + matrixSize) % matrixSize);
        }

        private string ProcessPair(string pair, Func<int, int, int> rowOperation, Func<int, int> colOperation)
        {
            if (pair.Length < 2)
            {
                throw new ArgumentException("Pair must contain two characters.");
            }

            int r0 = CheckRow(pair[0]);
            int c0 = CheckCol(pair[0]);
            int r1 = CheckRow(pair[1]);
            int c1 = CheckCol(pair[1]);

            if (r0 == -1 || r1 == -1 || c0 == -1 || c1 == -1)
            {
                MessageBox.Show($"Character(s) not found in matrix: {pair}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ""; // Trả về chuỗi rỗng hoặc xử lý khác
            }

            if (c0 == c1)
                return arrayMatrix[rowOperation(r0, c0), c0].Text + arrayMatrix[rowOperation(r1, c1), c1].Text;

            if (r0 == r1)
                return arrayMatrix[r0, colOperation(c0)].Text + arrayMatrix[r1, colOperation(c1)].Text;

            return arrayMatrix[r0, c1].Text + arrayMatrix[r1, c0].Text;
        }

        private int CheckRow(char c)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (arrayMatrix[i, j].Text == c.ToString())
                        return i;
                }
            }
            return -1; // Trả về -1 nếu ký tự không tồn tại
        }

        private int CheckCol(char c)
        {
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (arrayMatrix[i, j].Text == c.ToString())
                        return j;
                }
            }
            return -1; // Trả về -1 nếu ký tự không tồn tại
        }

        private List<string> SplitPairs(string text)
        {
            var pairs = new List<string>();
            for (int i = 0; i < text.Length; i += 2)
            {
                pairs.Add(text.Substring(i, Math.Min(2, text.Length - i)));
            }
            return pairs;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string text = PreparePlainText(matrixSize);
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter a valid message!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var pairs = SplitPairs(text);
            textResult.Text = string.Join("", pairs.Select(EncryptPair));
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string text = PreparePlainText(matrixSize);
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter a valid message!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var pairs = SplitPairs(text);
            textResult.Text = string.Join("", pairs.Select(DecryptPair));
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            textMessage.Clear();
            textResult.Clear();
            textKey.Clear();
            panel1.Controls.Clear();
            InitMatrix(5);
            ValidateKeyInput();
            matrixSize = 5;
            rBtn5x5.Select();
        }

        private void textKey_TextChanged(object sender, EventArgs e)
        {
            // Chuyển đổi văn bản thành chữ hoa và loại bỏ ký tự không hợp lệ
            textKey.Text = Regex.Replace(textKey.Text.Unidecode().ToUpperInvariant(), matrixSize == 5 ? "[^A-IK-Z]" : "[^A-Z0-9]", "");
            textKey.MaxLength = 36;
            textKey.SelectionStart = textKey.Text.Length;

            // Cập nhật ma trận dựa trên khóa
            UpdateMatrixWithKey(textKey.Text);
        }

        private void UpdateMatrixWithKey(string key)
        {
            // Chuẩn hóa khóa đầu vào: loại bỏ ký tự không hợp lệ và trùng lặp
            string filteredKey = Regex.Replace(key.ToUpperInvariant(), matrixSize == 5 ? "[^A-IK-Z]" : "[^A-Z0-9]", "");
            filteredKey = DistinctString(filteredKey); // Loại bỏ ký tự trùng lặp

            // Tập hợp các ký tự đã sử dụng
            HashSet<char> usedChars = new HashSet<char>(filteredKey);

            // Xóa nội dung cũ trong ma trận
            for (int r = 0; r < matrixSize; r++)
            {
                for (int c = 0; c < matrixSize; c++)
                {
                    arrayMatrix[r, c].Text = string.Empty;
                }
            }

            // Thêm khóa vào ma trận
            int row = 0, col = 0;
            foreach (char ch in filteredKey)
            {
                arrayMatrix[row, col].Text = ch.ToString();
                col++;
                if (col >= matrixSize)
                {
                    col = 0;
                    row++;
                }
            }

            // Bổ sung các ký tự còn thiếu từ bảng chữ cái
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                if (ch == 'J' && matrixSize == 5) continue; // Bỏ qua 'J' nếu ma trận 5x5
                if (usedChars.Add(ch)) // Chỉ thêm nếu chưa được sử dụng
                {
                    arrayMatrix[row, col].Text = ch.ToString();
                    col++;
                    if (col >= matrixSize)
                    {
                        col = 0;
                        row++;
                    }
                }
            }

            // Bổ sung các số (cho ma trận 6x6)
            if (matrixSize == 6)
            {
                for (char numChar = '0'; numChar <= '9'; numChar++)
                {
                    if (usedChars.Add(numChar)) // Chỉ thêm nếu chưa được sử dụng
                    {
                        arrayMatrix[row, col].Text = numChar.ToString();
                        col++;
                        if (col >= matrixSize)
                        {
                            col = 0;
                            row++;
                        }
                    }
                }
            }
        }

        // Thêm các phương thức xử lý sự kiện cho các tùy chọn
        private void rBtnSeparateDuplicates_CheckedChanged(object sender, EventArgs e)
        {
            separateDuplicateLetters = rBtnSeparateDuplicates.Checked;
        }

        private void rBtnIgnoreDuplicates_CheckedChanged(object sender, EventArgs e)
        {
            ignoreDuplicateLetters = rBtnIgnoreDuplicates.Checked;
        }

        private void textFirstSeparator_TextChanged(object sender, EventArgs e)
        {
            firstSeparator = textFirstSeparator.Text;
        }

        private void textSecondSeparator_TextChanged(object sender, EventArgs e)
        {
            secondSeparator = textSecondSeparator.Text;
        }

        private void PlayFair_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
