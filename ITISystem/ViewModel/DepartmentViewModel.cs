using ITISystem.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITISystem.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ITISystem.ViewModel
{
    public class DepartmentViewModel : INotifyPropertyChanged
    {
        DepartmentModel inputDepartment = new DepartmentModel();
        public DepartmentModel InputDepartment
        {
            get => inputDepartment;
            set
            {
                inputDepartment = value;
                OnPropertyChanged();
            }
        }
        DepartmentModel selectedDepartment;
        public DepartmentModel SelectedDepartment
        {
            get => selectedDepartment;
            set
            {
                selectedDepartment = value;
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

        public static ObservableCollection<DepartmentModel> DepartmentList { get; set; }
        static DepartmentViewModel()
        {
            DepartmentList = new ObservableCollection<DepartmentModel>
            {
                new(){Dept_Name = "SD", Dept_Desc = "System Development", Dept_Location = "Cairo", Dept_Manager = 1010,Manager_hiredate = new DateTime(2017, 1, 11)},
                new(){Dept_Name = "El", Dept_Desc = "E-Learning", Dept_Location = "Mansoura", Dept_Manager = 1020 ,Manager_hiredate = new DateTime(2010, 2, 2)},
                new(){Dept_Name = "Java", Dept_Desc = "Java", Dept_Location = "Cairo", Dept_Manager = 1040 ,Manager_hiredate = new DateTime(2013, 3, 11)},
                new(){Dept_Name = "MM", Dept_Desc = "Multi Media", Dept_Location = "Alex", Dept_Manager = 1050 ,Manager_hiredate = new DateTime(2015, 4, 1)},
                new(){Dept_Name = "Unix", Dept_Desc = "Unix", Dept_Location = "Alex", Dept_Manager = 1010 ,Manager_hiredate = new DateTime(2011, 1, 5)},
                new(){Dept_Name = "NC", Dept_Desc = "Network", Dept_Location = "Cairo", Dept_Manager = 1020, Manager_hiredate = new DateTime(2018, 2, 1)},
                new(){Dept_Name = "EB", Dept_Desc = "E-Business", Dept_Location = "Alex", Dept_Manager = 1050, Manager_hiredate = new DateTime(2022, 8, 9)},
            };
        }

        public DepartmentViewModel()
        {
            AddDepartment = new CustomCommand(AddNewDepartment, CanAddNewDepartment);
            DeleteDepartment = new CustomCommand(DeleteSelectedDepartment, CanDeleteDepartment);
            UpdateCommand = new CustomCommand(Update, CanUpdate);


        }
        public CustomCommand AddDepartment { get; set; }
        public CustomCommand DeleteDepartment { get; set; }
        public CustomCommand UpdateCommand { get; set; }

        private void AddNewDepartment(object parameter)
        {
            DepartmentList.Add(InputDepartment);
            InputDepartment = new DepartmentModel();

        }
        private bool CanAddNewDepartment(object parameter)
        {
            return true;
        }
        private void DeleteSelectedDepartment(object parameter)
        {
            DepartmentList.Remove(SelectedDepartment);
        }
        private bool CanDeleteDepartment(object parameter)
        {
            return SelectedDepartment != null;
        }

        private bool CanUpdateDepartment(object parameter)
        {
            return SelectedDepartment != null;
        }
        private void Update(object obj)
        {
            //DepartmentList[selectIndex] = SelectedDepartment;
        }

        private bool CanUpdate(object obj)
        {

            return SelectedDepartment != null;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
