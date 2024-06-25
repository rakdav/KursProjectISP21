using KursProject.Model;
using KursProject.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.ModelView
{
    class StudentPageViewModel:BaseClass
    {
        UchebContext db = new UchebContext();
        private ObservableCollection<Student> studentList;
        public ObservableCollection<Student> StudentList
        {
            get { return studentList; }
            set
            {
                studentList = value;
                OnPropertyChanged(nameof(StudentList));
            }
        }

        public StudentPage window;

        private Student? selectedStudent;
        public Student? SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }

        public StudentPageViewModel(StudentPage w)
        {
            this.window = w;
            db.Database.EnsureCreated();
                db.Students.Load();
                StudentList = db.Students.Local.ToObservableCollection();
        }

        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddEditSttudent window = new AddEditSttudent(new Student());
                        if (window.ShowDialog() == true)
                        {
                            Student student = window.Student;
                            db.Students.Add(student);
                            db.SaveChanges();
                        }
                    }));
            }
        }
        private RelayCommand? editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                    (editCommand = new RelayCommand(obj =>
                    {
                        Student? student = obj as Student;
                        if (student == null) return;
                        AddEditSttudent window = new AddEditSttudent(student!);
                        if(window.ShowDialog()==true)
                        {
                            student.Surname = window.Student.Surname;
                            student.Name = window.Student.Name;
                            student.Stipend = window.Student.Stipend;
                            student.Kurs = window.Student.Kurs;
                            student.BirthDay = window.Student.BirthDay;
                            student.City = window.Student.City;
                            student.UnivId = window.Student.UnivId;
                            db.Entry(student).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }));
            }
        }
        RelayCommand? deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand(selectedItem =>
                  {
                      // получаем выделенный объект
                      Student? student = selectedItem as Student;
                      if (student == null) return;
                      db.Students.Remove(student);
                      db.SaveChanges();
                  }));
            }
        }
    }
}
