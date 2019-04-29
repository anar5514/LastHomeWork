using _23._04HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _23._04HomeWork.Commands
{
    public class AddLessonCommand : ICommand
    {
        public LessonViewModel LessonViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public AddLessonCommand(LessonViewModel LessonViewModel)
        {
            this.LessonViewModel = LessonViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            LessonViewModel.Lessons.Add(LessonViewModel.CurrentLesson);
        }
    }
}
