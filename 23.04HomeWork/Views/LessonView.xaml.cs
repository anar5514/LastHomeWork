using _23._04HomeWork.Entities;
using _23._04HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _23._04HomeWork.Views
{
    /// <summary>
    /// Interaction logic for LessonView.xaml
    /// </summary>
    public partial class LessonView : Window
    {
        public LessonViewModel LessonViewModel { get; set; }

        public LessonView(LessonViewModel LessonViewModel)
        {
            InitializeComponent();

            this.LessonViewModel = LessonViewModel;

            DataContext = LessonViewModel;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Lesson lesson = new Lesson()
            {
                StartTime = DateTime.Now,
                Teacher = "Anar Ahmadov",
                KindOfService = "Learnin C++",
                Level = 3,
                Group = new Group(),
                EndTime = DateTime.Now            
            };


        }
    }
}
