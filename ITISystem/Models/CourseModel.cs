using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ITISystem.Models
{
    public class CourseModel : BaseEntity, INotifyPropertyChanged

    {
        static int Counter = 10000;
        int crs_Id = Counter += 1000;

        public int Crs_Id
        {
            get => crs_Id;
        }

        string? crs_Name;
        public string Crs_Name
        {
            get => crs_Name;
            set
            {
                if (value != crs_Name)
                {
                    OnPropertyChanged();
                    crs_Name = value.Length < 50 ? value : value.Substring(0, 50);
                }
            }
        }

        int crs_Duration;
        public int Crs_Duration
        {
            get => crs_Duration;
            set
            {
                if (value != crs_Duration)
                {
                    OnPropertyChanged();
                    crs_Duration = value;
                }
            }
        }

        string? top_Name;
        public string Top_Name
        {
            get => top_Name;
            set
            {
                if (value != top_Name)
                {
                    OnPropertyChanged();
                    top_Name = value.Length < 50 ? value : value.Substring(0, 50);
                }
            }
            
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = default)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
