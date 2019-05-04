using _23._04HomeWork.Commands;
using _23._04HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04HomeWork.ViewModels
{
    public class StudentViewModel : BaseViewModel
    {
        public AddStudentCommand AddStudentCommand => new AddStudentCommand(this);

        private ObservableCollection<Student> students;

        public Student CurrentStudent { get; set; }

        public ObservableCollection<Student> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Students"));  
            }
        }

    }
}
