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
using static System.Math;

namespace PractikWork1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();
            double v, s, a;

            if (String.IsNullOrEmpty(NumberATextBox.Text))
            {
                return;
            }
            try
            {
                a = double.Parse(NumberATextBox.Text);
                v = Pow(a, 3);
                s = 6 * Pow(a, 2);

                AnswerTextBox.Text += $"V = {v}\nS = {s}";
            }
            catch (FormatException)
            {
                AnswerTextBox.Text += "Введены не корректные данные";
            }
        }
    }
}
