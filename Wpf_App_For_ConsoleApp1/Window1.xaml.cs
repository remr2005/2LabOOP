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
using System.Windows.Shapes;
using static Wpf_App_For_ConsoleApp1.UIHandler;
using static Wpf_App_For_ConsoleApp1.Matrix;

namespace Wpf_App_For_ConsoleApp1
{

    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        /// <summary>
        /// Инициализация
        /// </summary>
        public Window1()
        {
            InitializeComponent();
            InitializeGrid(grid1,10,10);
            InitializeGrid(grid2, 10, 10);
            InitializeGrid(grid3, 10, 10);
        }
        /// <summary>
        /// Код для изменения размерности матриц
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                double[,] a = new double[Row1.SelectedIndex + 1, Column1.SelectedIndex + 1];
                double[,] b = new double[Column1.SelectedIndex + 1, Column2.SelectedIndex + 1];
                InitializeGrid(grid1, Column1.SelectedIndex + 1, Row1.SelectedIndex + 1);
                InitializeGrid(grid2, Column2.SelectedIndex + 1, Column1.SelectedIndex + 1);
                a = getValuesFromGrid(grid1);
                b = getValuesFromGrid(grid2);
                DisplayResult(grid3, Multiply(a, b));
            }
            catch { return; }
            
        }
        /// <summary>
        /// логика для вычисления произведения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double[,] a = new double[Row1.SelectedIndex + 1, Column1.SelectedIndex + 1];
                double[,] b = new double[Column1.SelectedIndex + 1, Column2.SelectedIndex + 1];
                a = getValuesFromGrid(grid1);
                b = getValuesFromGrid(grid2);
                DisplayResult(grid3, Multiply(a, b));
            }
            catch { return; }
        }
    }
}
