using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Letter_to_Number_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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

        private void Button_Click(object sender, RoutedEventArgs e)
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
