using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ITISystem.Models
{
   public class StudentModel : BaseEntity,INotifyPropertyChanged
    {

        static public int Counter = 0;
        int id= Counter+=1;
        public int Id
        {
            get => id;
     

        }

        
        
        string? st_Fname;
        public string St_Fname
        {
            get => st_Fname;
            set
            {
                if (value != st_Fname)
                {
                    OnPropertyChanged();
                    st_Fname = value.Length < 50 ? value : value.Substring(0, 50);
                }
            }
        }

        string st_Lname;
        public string St_Lname
        {
            get => st_Lname;
            set
            {
                if (value != st_Lname)
                {
                    OnPropertyChanged();
                    st_Lname = value.Length < 50 ? value : value.Substring(0, 50);
                }
            }
        }

        string? st_Address;
        public string St_Address
        {
            get => st_Address;
            set
            {
                if (value != st_Address)
                {
                    OnPropertyChanged();
                    st_Address = value.Length < 100 ? value : value.Substring(0, 100);
                }
            }
        }

        int st_Age;
        public int St_Age
        {
            get => st_Age;
            set
            {
                if (value != st_Age)
                {
                    OnPropertyChanged();
                    st_Age = value;
                }
            }
        }

        int dept_Id;
        public int Dept_Id
        {
            get => dept_Id;
            set
            {
                if (value != dept_Id)
                {
                    dept_Id = value;
                    OnPropertyChanged();
                }
            }
        }

        int? st_super;
        public int? St_super
        {
            get => st_super;
            set
            {
                if (value != st_super)
                {
                    st_super = value;
                    OnPropertyChanged();
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
