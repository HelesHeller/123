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

namespace _123
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
        // Обработчики событий для каждой кнопки
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMessageBox("Вы нажали кнопку 'Сохранить'");
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMessageBox("Вы нажали кнопку 'Открыть'");
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMessageBox("Вы нажали кнопку 'Новый'");
        }

        private void CutButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMessageBox("Вы нажали кнопку 'Вырезать'");
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMessageBox("Вы нажали кнопку 'Копировать'");
        }

        // Метод для отображения MessageBox
        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
