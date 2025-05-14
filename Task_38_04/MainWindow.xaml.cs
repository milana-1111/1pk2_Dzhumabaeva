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

namespace Task_38_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new();
        private readonly string dataFile = "students.json";
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists(dataFile))
            {
                var json = File.ReadAllText(dataFile);
                students = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
                RefreshListBox();
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student
            {
                LastName = LastNameBox.Text,
                FirstName = FirstNameBox.Text,
                MiddleName = MiddleNameBox.Text,
                Group = GroupBox.Text,
                Gender = ((ComboBoxItem)GenderBox.SelectedItem)?.Content.ToString() ?? "",
                BirthDate = BirthDatePicker.SelectedDate ?? DateTime.Now
            };

            students.Add(student);
            RefreshListBox();
        }
        private void RefreshListBox()
        {
            StudentListBox.Items.Clear();
            foreach (var s in students)
            StudentListBox.Items.Add($"{s.LastName} {s.FirstName} {s.MiddleName} — {s.Group}, {s.Gender}, {s.BirthDate.ToShortDateString()}");
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var json = JsonSerializer.Serialize(students);
            File.WriteAllText(dataFile, json);
        }
    }
}
