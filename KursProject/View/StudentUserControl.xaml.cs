using KursProject.Model;
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

namespace KursProject.View
{
    /// <summary>
    /// Логика взаимодействия для StudentUserControl.xaml
    /// </summary>
    public partial class StudentUserControl : UserControl
    {
        public Student Student { get; set; }
        public StudentUserControl(Student student)
        {
            InitializeComponent();
            Student = student;
            DataContext = Student;
        }
    }
}
