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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();
            
            double a, b, c, ac, bc;
            double? product = null;
             
            if (String.IsNullOrEmpty(NumberATextBox.Text) || String.IsNullOrEmpty(NumberBTextBox.Text) || String.IsNullOrEmpty(NumberCTextBox.Text))
            {
                return;
            }
            
            if(!double.TryParse(NumberATextBox.Text, out a))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!double.TryParse(NumberBTextBox.Text, out b))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (!double.TryParse(NumberCTextBox.Text, out c))
            {
                AnswerTextBox.Text += "Введены не корректные данные\n";
            }

            if (c > a && c < b)
            {
                ac = Abs(a - c);
                bc = Abs(b - c);
                product = ac * bc;
                AnswerTextBox.Text += $"Произведение отрезков = {product}";
            }
            else
            {
                AnswerTextBox.Text += "Точка C должна быть между А и В";
            }

        }
    }
}
