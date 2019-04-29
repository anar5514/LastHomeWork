using _23._04HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _23._04HomeWork.Commands
{
    public class AddStudentCommand : ICommand
    {
        public StudentViewModel StudentViewModel { get; set; }

        public AddStudentCommand(StudentViewModel StudentViewModel)
        {
            this.StudentViewModel = StudentViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StudentViewModel.Students.Add(StudentViewModel.CurrentStudent);
        }
    }
}
