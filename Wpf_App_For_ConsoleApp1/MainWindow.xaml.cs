using System;
using System.Windows;
using System.Windows.Controls;
using static GCDAlgorithms;
using Wpf_App_For_ConsoleApp1;

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
            // если строка пустая или равна -, то вернуть 0
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
            // Вычисляем НОд
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
            // преобразовываем объект посылающий событие в TextBox
            TextBox? txt = sender as TextBox;
            // если преобразование успешно
            if (txt != null)
            {
                // проверяем можно ли спарсить введенный текст
                e.Handled = !int.TryParse(e.Text+txt.Text, out _);
            }
            
        }
        /// <summary>
        /// Кнопка для вычисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonParamGCD_Click(object sender, RoutedEventArgs e)
        {
            // разделить текст по пробелу
            string[] arr = TxtSomeParamtrs.Text.Split(' ');
            int[] param = new int[arr.GetLength(0)];
            // пытаемся записать все в параметры, если не смог спарсить то выводит ошибку
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (!int.TryParse(arr[i], out param[i])) { Euclid_Res2.Content = Stein_Res2.Content = "Неправильный ввод"; return; }  
            }
            // вычисляем НОД
            Euclid_Res2.Content = FindGCDEuclid(param);
            Stein_Res2.Content = FindGCDStein(param);
        }
        /// <summary>
        /// Кнопка для нахождения наибольшего простого меньшего заданного числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Find_Prime(object sender, RoutedEventArgs e)
        {
            // вычисляем
            PrimeLabel.Content = FindLargestSimple(ParseToInt(TxtPrimeNumber.Text));
        }
        /// <summary>
        /// Кнопка для открытия задания с матрицой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Wpf_App_For_ConsoleApp1.Window1 secondWin = new Wpf_App_For_ConsoleApp1.Window1();
            secondWin.Show();
        }
    }
}
