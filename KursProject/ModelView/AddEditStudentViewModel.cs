using KursProject.Model;
using KursProject.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.ModelView
{
    class AddEditStudentViewModel : BaseClass
    {
        private AddEditSttudent window;
        public IList<University> Universities { get; } = new ObservableCollection<University>();
        private Student Student { get; set; } = new Student();
        public AddEditStudentViewModel(AddEditSttudent w)
        {
            this.window = w;
            using (UchebContext db = new UchebContext())
            {
                Universities = db.Universities.ToList();
            }
        }

        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        using (UchebContext db=new UchebContext())
                        {
                            Student newStudent = new Student();
                            newStudent.Surname = window.Surname.Text;
                            newStudent.Name = window.Name.Text;
                            newStudent.Stipend = int.Parse(window.Stipend.Text);
                            newStudent.Kurs = int.Parse(window.Kurs.Text.ToString());
                            newStudent.City = window.City.Text;
                            newStudent.BirthDay = window.Birthday.Text;
                            newStudent.UnivId = int.Parse(window.UnivId.SelectedValue.ToString()!);
                            db.Students.Add(newStudent);
                            db.SaveChanges();
                            window.Close();
                        }
                    }));
            }
        }
    }
}
