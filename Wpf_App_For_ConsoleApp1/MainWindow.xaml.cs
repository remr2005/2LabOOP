using System;
using System.Windows;
using System.Windows.Controls;
using static GCDAlgorithms;

namespace Wpf_App_For_ConsoleApp1
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
        /// <summary>
        /// Парсит строку возвращая 0 если она пустая
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns>возвращает int</returns>
        private int ParseToInt(string? str)
        {
            if (string.IsNullOrEmpty(str) || str.Equals("-")) { return 0; }
            return Convert.ToInt32(str);
        }
        /// <summary>
        /// Обработчик для назжатия первого CAlculate GCD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Euclid_Res.Content = FindGCDEuclid(ParseToInt(TxtBox1.Text), ParseToInt(TxtBox2.Text), ParseToInt(TxtBox3.Text), ParseToInt(TxtBox4.Text), ParseToInt(TxtBox5.Text));
            Stein_Res.Content = FindGCDEuclid(ParseToInt(TxtBox1.Text), ParseToInt(TxtBox2.Text), ParseToInt(TxtBox3.Text), ParseToInt(TxtBox4.Text), ParseToInt(TxtBox5.Text));
        }
        /// <summary>
        /// Текст в правильном формате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBox1_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            TextBox? txt = sender as TextBox;
            if (txt != null)
            {
                e.Handled = !int.TryParse(e.Text+txt.Text, out _);
            }
            
        }

        private void ButtonParamGCD_Click(object sender, RoutedEventArgs e)
        {
            string[] arr = TxtSomeParamtrs.Text.Split(' ');
            int[] param = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (!int.TryParse(arr[i], out param[i])) { Euclid_Res2.Content = Stein_Res2.Content = "Неправильный ввод"; return; }  
            }
            Euclid_Res2.Content = FindGCDEuclid(param);
            Stein_Res2.Content = FindGCDStein(param);
        }

        private void Button_Click_Find_Prime(object sender, RoutedEventArgs e)
        {
            PrimeLabel.Content = FindLargestSimple(ParseToInt(TxtPrimeNumber.Text));
        }
    }
}
