using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letter_to_Number_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int ConvertNumber(string word)
        {
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            char[] charWord = word.ToUpper().ToCharArray();

            int score = 0;

            for (int i = 0; i < word.Length; i++)
            {
                score += Array.IndexOf(letters, charWord[i]);
            }
            return score + word.Length;
        }

        private void ConvertLetters_Click(object sender, EventArgs e)
        {
            EnteredWord.Focus();
            if (EnteredWord.Text == string.Empty)
            {
                MessageBox.Show("Please enter a word");
            }
            else
            {
                int score = ConvertNumber(EnteredWord.Text);
                MessageBox.Show(EnteredWord.Text.ToUpper() + " equals " + score + "%");
                EnteredWord.Clear();
            }
        }

    }
}
