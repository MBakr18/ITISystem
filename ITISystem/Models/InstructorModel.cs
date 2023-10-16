using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ITISystem.Enums;
using MaterialDesignThemes.Wpf;

namespace ITISystem.Models
{
    public class InstructorModel : INotifyPropertyChanged
    {
        static int Counter = 1000;
        int id = Counter += 10;
        public int Ins_Id
        {
            get => id;

        }

        private string? name;
        public string? Ins_Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    OnPropertyChanged();

                    name = value.Length < 50 ? value : value.Substring(0,50);
                }
            }
        }

        private string? degree;
        public string Ins_Degree
        {
            get => degree!;
            set
            {
                if (degree != value)
                {
                    OnPropertyChanged();
                    degree = value.Length < 50 ? value : value.Substring(0,50);
                }
            }
        }

        private decimal salary;
        public decimal Salary
        {
            get => salary;
            set
            {
                if (salary != value)
                {
                    OnPropertyChanged();
                    salary = value;
                }
            }
        }

        private int deptId;
        public int Dept_Id
        {
            get => deptId;
            set
            {
                if (deptId != value)
                {
                    OnPropertyChanged();
                    deptId = value;
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
