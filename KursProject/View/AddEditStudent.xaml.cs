using KursProject.Model;
using KursProject.ModelView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace KursProject.View
{
    /// <summary>
    /// Логика взаимодействия для AddEditSttudent.xaml
    /// </summary>
    public partial class AddEditSttudent : Window
    {
        public Student Student { get; private set; }

        public AddEditSttudent(Student student)
        {
            InitializeComponent();
            Student = student;
            DataContext = Student;
            using (UchebContext db = new UchebContext())
            {
                UnivId.ItemsSource = db.Universities.ToList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
