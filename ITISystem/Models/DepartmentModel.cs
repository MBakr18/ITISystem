using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ITISystem.Models
{
    public class DepartmentModel : BaseEntity, INotifyPropertyChanged
    {

        static int Counter = 5000;

        int dept_Id = Counter += 100;
        public int Department_id
        {
            get => dept_Id;

        }

        string? dept_Name;
        public string Dept_Name
        {
            get => dept_Name;
            set
            {
                if (dept_Name != value)
                {
                    OnPropertyChanged();
                    dept_Name = value.Length < 50 ? value : value.Substring(0, 50);
                }
            }
        }

        //[Dept_Desc][nvarchar] (100) NULL,
        string? dept_Desc;
        public string Dept_Desc
        {
            get => dept_Desc;
            set
            {
                if (dept_Desc != value)
                {
                    OnPropertyChanged();
                    dept_Desc = value.Length < 100 ? value : value.Substring(0, 100);
                }

            }
        }

        string? dept_Location;
        public string Dept_Location
        {
            get => dept_Location;
            set
            {
                if (dept_Location != value)
                {
                    OnPropertyChanged();
                    dept_Location = value.Length < 100 ? value : value.Substring(0, 100);
                }
            }
        }

        int? dept_Manager;
        public int? Dept_Manager
        {
            get => dept_Manager;
            set
            {
                if (value != dept_Manager)
                {
                    OnPropertyChanged();
                    dept_Manager = value;
                }
            }
        }

        DateTime? manager_hiredate;
        public DateTime? Manager_hiredate
        {
            get => manager_hiredate;
            set
            {
                if(value != manager_hiredate){}
                    OnPropertyChanged();
                manager_hiredate = value;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = default)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
