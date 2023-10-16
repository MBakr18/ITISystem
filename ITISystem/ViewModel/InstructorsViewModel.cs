using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ITISystem.Enums;
using ITISystem.Models;
using ITISystem.ViewModel.Commands;
using Microsoft.VisualBasic;

namespace ITISystem.ViewModel
{
    public class InstructorsViewModel : INotifyPropertyChanged
    {
        InstructorModel inputInstructor = new();
        public InstructorModel InputInstructor
        {
            get => inputInstructor;
            set
            {
                inputInstructor = value;
                OnPropertyChanged();
            }
        }
        InstructorModel selectedInstructor;
        public InstructorModel SelectedInstructor
        {
            get => selectedInstructor;
            set
            {
                selectedInstructor = value;
                OnPropertyChanged();
            }
        }
        //int selectIndex;
        ////public int SelectIndex
        ////{
        ////    get => selectIndex;
        ////    set
        ////    {
        ////        selectIndex = value;
        ////        OnPropertyChanged();
        ////    }
        ////}



        public static ObservableCollection<InstructorModel> InstructorList { get; set; }

        static InstructorsViewModel()
        {
            InstructorList = new ObservableCollection<InstructorModel>
            {
                new() {Ins_Name = "Ahmed Magdy", Ins_Degree = "Master", Dept_Id = 5500, Salary = 10_000M},
                new() {Ins_Name = "Hani Safwat", Ins_Degree = "Bachelor", Dept_Id = 5500, Salary = 15_000M},
                new() {Ins_Name = "Adel Eldemiry", Ins_Degree = "Bachelor", Dept_Id = 5700, Salary = 15_000M},
                new() {Ins_Name = "Ahmed Ali", Ins_Degree = "Bachelor", Dept_Id = 5600, Salary = 10_000M},
                new() {Ins_Name = "Mohamed Hossam", Ins_Degree = "PHD", Dept_Id = 5100, Salary = 12_000M},
                new() {Ins_Name = "Ali Hashim", Ins_Degree = "Bachelor", Dept_Id = 5300, Salary = 13_000M},
                new() {Ins_Name = "Mohamed Hossam", Ins_Degree = "Bachelor", Dept_Id = 5100, Salary = 14_000M},
            };
        }

        public InstructorsViewModel()
        {
            AddInstructor = new CustomCommand(AddNewInstructor, CanAddNewInstructor);
            DeleteInstructor = new CustomCommand(DeleteSelectedInstructor, CanDeleteInstructor);
            UpdateCommand = new CustomCommand(Update, CanUpdate);


        }

        public CustomCommand AddInstructor { get; set; }
        public CustomCommand DeleteInstructor { get; set; }
        public CustomCommand UpdateCommand { get; set; }



        private void AddNewInstructor(object parameter)
        {
            InstructorList.Add(InputInstructor);
            InputInstructor = new InstructorModel();
        }
        private bool CanAddNewInstructor(object parameter)
        {
            return true;
        }
        private void DeleteSelectedInstructor(object parameter)
        {
            InstructorList.Remove(SelectedInstructor);
        }
        private bool CanDeleteInstructor(object parameter)
        {
            return SelectedInstructor != null;
        }

        private void Update(object obj)
        {
            //InstructorList[selectIndex] = SelectedInstructor;
        }

        private bool CanUpdate(object obj)
        {

            return SelectedInstructor != null;
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

