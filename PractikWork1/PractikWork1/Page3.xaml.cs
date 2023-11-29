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

namespace PractikWork1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();

            double v, u, t1, t2;
            double? s = null;

            if (String.IsNullOrEmpty(NumberVTextBox.Text) || String.IsNullOrEmpty(NumberUTextBox.Text) || String.IsNullOrEmpty(NumberT1TextBox.Text) || String.IsNullOrEmpty(NumberT1TextBox.Text))
            {
                return;
            }

            if (!double.TryParse(NumberVTextBox.Text, out v))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!double.TryParse(NumberUTextBox.Text, out u))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!double.TryParse(NumberT1TextBox.Text, out t1))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!double.TryParse(NumberT2TextBox.Text, out t2))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if(u < v)
            {
                s = t1 * v + t2 * (v - u);
                AnswerTextBox.Text += $"S = {s}";
            }
            else
            {
                AnswerTextBox.Text += "U должно быть меньше V";
            }

        }
    }
}
