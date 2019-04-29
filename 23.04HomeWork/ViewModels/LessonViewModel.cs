using _23._04HomeWork.Commands;
using _23._04HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04HomeWork.ViewModels
{
    public class LessonViewModel : BaseViewModel
    {
        public AddLessonCommand AddLessonCommand => new AddLessonCommand(this);

        private List<Lesson> lessons;

        public Lesson CurrentLesson { get; set; }

        public List<Lesson> Lessons
        {
            get
            {
                return lessons;
            }

            set
            {
                lessons = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Lessons"));
            }
        }

    }
}
