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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            GroupViewModel groupViewModel = new GroupViewModel();

            groupViewModel.CurrentGroup = new Entities.Group();

            Groups groups = new Groups(groupViewModel);

            groupViewModel.Subjects = new List<Entities.Subject>()
            {
                new Entities.Subject()
                {
                    Name = "General English"
                },

                new Entities.Subject()
                {
                    Name = "Computer Science"
                }
            };


            groupViewModel.Levels = new List<Entities.Level>()
            {
                new Entities.Level()
                {
                    LevelName = "Beginner"
                },

                new Entities.Level()
                {
                    LevelName = "Elementary"
                },

                new Entities.Level()
                {
                    LevelName = "Intermediate"
                },

                new Entities.Level()
                {
                    LevelName = "Upper-Intermediate"
                },

                new Entities.Level()
                {
                    LevelName = "Advanced"
                }
                    
            };

            groupViewModel.Branches = new List<Entities.Branch>()
            {
                new Entities.Branch()
                {
                    Name = "Nerimanov"
                },

                new Entities.Branch()
                {
                    Name = "Bakixanov"
                },

                new Entities.Branch()
                {
                    Name = "Sebail"
                },

                new Entities.Branch()
                {
                    Name = "Sabuncu"
                },

                new Entities.Branch()
                {
                    Name = "Yasamal"
                }
            };

            groups.ShowDialog();
        }

        private void BtnShowGroup_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
