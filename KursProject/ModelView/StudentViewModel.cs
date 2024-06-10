﻿using KursProject.Model;
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
    class StudentViewModel : BaseClass
    {
        UchebContext db = new UchebContext();
        private StudentPage? studentPage;
        public ObservableCollection<Student>? StudentList { get; set; }

        private Student? selectedStudent;
        public Student? SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                selectedStudent = value;
                OnPropertyChanged("SelectedStudent");
            }
        }
        public StudentViewModel(StudentPage page)
        {
            this.studentPage = page;
            db.Database.EnsureCreated();
            db.Students.Load();
            StudentList = db.Students.Local.ToObservableCollection();
        }
    }
}