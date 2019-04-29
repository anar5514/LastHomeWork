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

namespace _23._04HomeWork
{
    /// <summary>
    /// Interaction logic for Groups.xaml
    /// </summary>
    public partial class Groups : Window
    {
        public GroupViewModel GroupVM { get; set; }

        public Groups(GroupViewModel GroupVM)
        {
            InitializeComponent();

            this.GroupVM = GroupVM;

            DataContext = GroupVM;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Group group = new Group()
            {
                Name = "1814_az",
                Level = "Beginner",
                Branch = "Nerimanov",
                Note = "Hello world !",
                Subject = "General English"
            };

            GroupVM.AllGroups.Add(group);
            GroupVM.AddGroupCommand.Execute(5);
        }
    }
}
