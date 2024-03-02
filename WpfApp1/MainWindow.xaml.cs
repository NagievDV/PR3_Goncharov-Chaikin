using System;
using System.Windows;

namespace MinMaxCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text) || string.IsNullOrEmpty(txtNumber3.Text))
            {
                lblResult.Content = "Заполните все поля с числами!";
                return;
            }

            if (!rbMin.IsChecked.Value && !rbMax.IsChecked.Value)
            {
                lblResult.Content = "Выберите минимум или максимум!";
                return;
            }

            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);
                int num3 = int.Parse(txtNumber3.Text);

                if (rbMin.IsChecked.Value)
                {
                    int min = Math.Min(num1, Math.Min(num2, num3));
                    lblResult.Content = $"Минимум: {min}";
                }
                else
                {
                    int max = Math.Max(num1, Math.Max(num2, num3));
                    lblResult.Content = $"Максимум: {max}";
                }
            }
            catch (FormatException)
            {
                lblResult.Content = "Некорректный формат ввода числа!";
            }
            catch (OverflowException)
            {
                lblResult.Content = "Слишком большое или слишком маленькое число!";
            }
        }
    }
}
