using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ITISystem.Models;
using ITISystem.ViewModel.Commands;
using Microsoft.VisualBasic;

namespace ITISystem.ViewModel
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        StudentModel inputStudent = new();
        public StudentModel InputStudent
        {
            get => inputStudent;
            set
            {
                inputStudent = value;
                OnPropertyChanged();
            }
        }


         StudentModel selectedStudent;
        public  StudentModel SelectedStudent
        {
            get => selectedStudent;
            set
            {
                selectedStudent = value;
                OnPropertyChanged();
            }
        }
        //int selectIndex;
        //public int SelectIndex
        //{
        //    get => selectIndex;
        //    set
        //    {
        //        selectIndex = value;
        //        OnPropertyChanged();
        //    }
        //}
           

        public static ObservableCollection<StudentModel> StudentList { get; set; }

        static StudentViewModel()
        {
            StudentList = new ObservableCollection<StudentModel>
            {
                new StudentModel()
                {

                    St_Fname = "John",
                    St_Lname = "Doe",
                    St_Address = "123 Main St.",
                    St_Age = 20,
                    Dept_Id = 5100,
                    St_super = 1
                },
                new StudentModel()
                {

                    St_Fname = "Jane",
                    St_Lname = "Smith",
                    St_Address = "456 Elm St.",
                    St_Age = 22,
                    Dept_Id = 5100,
                    St_super = 1
                },
                new StudentModel()
                {

                    St_Fname = "Alice",
                    St_Lname = "Johnson",
                    St_Address = "789 Oak St.",
                    St_Age = 19,
                    Dept_Id = 5200,
                    St_super = 1
                },
                new StudentModel()
                {

                    St_Fname = "Bob",
                    St_Lname = "Martin",
                    St_Address = "111 Pine St.",
                    St_Age = 21,
                    Dept_Id = 5300,
                    St_super = 1
                },
                new StudentModel()
                {

                    St_Fname = "Charlie",
                    St_Lname = "Brown",
                    St_Address = "222 Birch St.",
                    St_Age = 23,
                    Dept_Id = 5400,
                    St_super = 1
                },
                new StudentModel()
                {

                    St_Fname = "Diana",
                    St_Lname = "Prince",
                    St_Address = "333 Cedar St.",
                    St_Age = 25,
                    Dept_Id = 5500,
                    St_super = 2
                },
                new StudentModel()
                {

                    St_Fname = "Eddie",
                    St_Lname = "Murphy",
                    St_Address = "444 Spruce St.",
                    St_Age = 24,
                    Dept_Id = 5600,
                    St_super = 3
                },
                new StudentModel()
                {

                    St_Fname = "Fiona",
                    St_Lname = "Shrek",
                    St_Address = "555 Maple St.",
                    St_Age = 22,
                    Dept_Id = 5700,
                    St_super = 1
                },
                new StudentModel()
                {

                    St_Fname = "George",
                    St_Lname = "Lucas",
                    St_Address = "666 Palm St.",
                    St_Age = 26,
                    Dept_Id = 5500,
                    St_super = 1
                },
                new StudentModel()
                {

                    St_Fname = "Hannah",
                    St_Lname = "Montana",
                    St_Address = "777 Fir St.",
                    St_Age = 20,
                    Dept_Id = 5700,
                    St_super = 1
                },
            };
        }

        public StudentViewModel()
        {
            AddStudent = new CustomCommand(AddNewStudent, CanAddNewStudent);
            DeleteStudent = new CustomCommand(DeleteSelectedStudent, CanDeleteStudent);
            UpdateCommand = new CustomCommand(Update, CanUpdate);

        }
        public CustomCommand AddStudent { get; set; }
        public CustomCommand DeleteStudent { get; set; }
        public CustomCommand UpdateCommand { get; set; }

        private void AddNewStudent(object parameter)
        {


            StudentList.Add(InputStudent);
            InputStudent = new StudentModel();
           

        }
        private bool CanAddNewStudent(object parameter)
        {
            return true;
        }
        private void DeleteSelectedStudent(object parameter)
        {
            StudentList.Remove(SelectedStudent);
        }
        private bool CanDeleteStudent(object parameter)
        {
            return SelectedStudent != null;
        }
        private void Update(object obj)
        {
            
            //StudentList[selectIndex] = SelectedStudent;
        }

        private bool CanUpdate(object obj)
        {

            return SelectedStudent != null;
        }
        public event PropertyChangedEventHandler? PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
