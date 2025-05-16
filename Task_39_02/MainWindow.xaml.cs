using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> products = new();
        private const string SavePath = "products.json";
        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists(SavePath))
            {
                var json = File.ReadAllText(SavePath);
                products = JsonSerializer.Deserialize<ObservableCollection<string>>(json) ?? new();
            }
            ProductListBox.ItemsSource = products;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProductTextBox.Text))
            {
                products.Add(ProductTextBox.Text.Trim());
                ProductTextBox.Clear();
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListBox.SelectedItem is string selected)
            {
                products.Remove(selected);
            }
        }
        private void ProductListBox_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ProductListBox.SelectedItem is string selected)
            {
                var input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Редактировать продукт:", "Изменение", selected);
                if (!string.IsNullOrWhiteSpace(input))
                {
                    int index = products.IndexOf(selected);
                    products[index] = input.Trim();
                }
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Сохранить список покупок"
            };
            if (dialog.ShowDialog() == true)
            {
                File.WriteAllLines(dialog.FileName, products);
                MessageBox.Show("Список сохранён!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var json = JsonSerializer.Serialize(products);
            File.WriteAllText(SavePath, json);
        }
    }
}
