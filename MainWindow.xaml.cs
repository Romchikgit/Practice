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
using static System.Net.Mime.MediaTypeNames;

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Task> tasks = new List<Task>();
        List<Categories> categories = new List<Categories>();
        public MainWindow()
        {
            InitializeComponent();
            CreateDate();
        }

        private void CreateDate()
        {
            categories.Add(new Categories { CategoryID = 1, CategoryName = "Дела по дому", ImageCategory="/Image/home.png"});
            categories.Add(new Categories { CategoryID = 2, CategoryName = "Образование", ImageCategory = "/Image/study.png" });
            categories.Add(new Categories { CategoryID = 3, CategoryName = "Работа", ImageCategory = "/Image/job.png" });
            categories.Add(new Categories { CategoryID = 3, CategoryName = "Семья и друзья", ImageCategory = "/Image/Friends.png" });

            tasks.Add(new Task { ID = 1, Title = "Покормить кота", Categories = categories[0] });
            tasks.Add(new Task { ID = 2, Title = "Сделать уроки", Categories = categories[1] });
            TaskLV.ItemsSource = tasks;
        }

        private void AddNewTaks(object sender, RoutedEventArgs e)
        {
            int index = 0;
            if (ComboBoxIcon.SelectedIndex == 0)
            {
                index = 0;
            }
            else if (ComboBoxIcon.SelectedIndex == 1)
            {
                index = 1;

            }
            else if (ComboBoxIcon.SelectedIndex == 2)
            {
                index = 2;
            }
            else if (ComboBoxIcon.SelectedIndex == 3)
            {
                index = 3;
            }

            Task newTasks = new Task();
            newTasks.ID = tasks.Count() + 1;
            newTasks.Title = TextBoxName.Text;
            newTasks.Categories = categories[index];

            tasks.Add(newTasks);
            TaskLV.ItemsSource = null;
            TaskLV.ItemsSource = tasks;

        }

    }
}
