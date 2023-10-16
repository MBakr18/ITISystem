using ITISystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ITISystem.ViewModel.Commands;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ITISystem.ViewModel
{
    public class CourseViewModel : INotifyPropertyChanged
    {
        CourseModel inputCourse;
        public CourseModel InputCourse
        {
            get => inputCourse;
            set
            {
                inputCourse = value;
                OnPropertyChanged();
            }
        }
        CourseModel selectedCourse;
        public CourseModel SelectedCourse
        {
            get => selectedCourse;
            set
            {
                selectedCourse = value;
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

        public static ObservableCollection<CourseModel> CourseList { get; set; }

        static CourseViewModel()
        {
            CourseList = new ObservableCollection<CourseModel>
            {
                new(){Crs_Name = "Html", Crs_Duration = 20, Top_Name = "Web"},
                new(){Crs_Name = "C Programming", Crs_Duration = 60, Top_Name = "Programming"},
                new(){Crs_Name = "OOP", Crs_Duration = 80, Top_Name = "Programming"},
                new(){Crs_Name = "Unix", Crs_Duration = 50, Top_Name = "Operating System"},
                new(){Crs_Name = "SQL Server", Crs_Duration = 60, Top_Name = "DB"},
                new(){Crs_Name = "C#", Crs_Duration = 80, Top_Name = "Programming"},
                new(){Crs_Name = "Web Service", Crs_Duration = 20, Top_Name = "Web"},
                new(){Crs_Name = "Java", Crs_Duration = 60, Top_Name = "Programming"},
                new(){Crs_Name = "Oracle", Crs_Duration = 50, Top_Name = "DB"},
                new(){Crs_Name = "ASP.Net", Crs_Duration = 60, Top_Name = "Web"},
                new(){Crs_Name = "Win_XP", Crs_Duration = 20, Top_Name = "Operating System"},
                new(){Crs_Name = "Photoshop", Crs_Duration = 30, Top_Name = "Design"},
            };
        }

        public CourseViewModel()
        {
            AddCourse = new CustomCommand(AddNewCourse, CanAddNewCourse);
            DeleteCourse = new CustomCommand(DeleteSelectedCourse, CanDeleteCourse);
            UpdateCommand = new CustomCommand(Update, CanUpdate);

        }
        public CustomCommand AddCourse { get; set; }
        public CustomCommand DeleteCourse { get; set; }
        public CustomCommand UpdateCommand { get; set; }

        private void AddNewCourse(object parameter)
        {
            CourseList.Add(InputCourse);
            InputCourse = new CourseModel();
        }
        private bool CanAddNewCourse(object parameter)
        {
            return true;
        }
        private void DeleteSelectedCourse(object parameter)
        {
            CourseList.Remove(SelectedCourse);
        }
        private bool CanDeleteCourse(object parameter)
        {
            return SelectedCourse != null;
        }
        private void Update(object obj)
        {
            //CourseList[selectIndex]= SelectedCourse;
        }

        private bool CanUpdate(object obj)
        {
            return SelectedCourse != null;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
