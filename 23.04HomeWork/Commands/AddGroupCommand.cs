using _23._04HomeWork.Entities;
using _23._04HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _23._04HomeWork.Commands
{
    public class AddGroupCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public GroupViewModel GroupViewModel { get; set; }     

        public AddGroupCommand(GroupViewModel GroupViewModel)
        {
            this.GroupViewModel = GroupViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            List<Group> groups = new List<Group>()
            {
                new Group()
                {
                    Id = 0,
                    Name = "1814_az",
                    Level = "Beginner",
                    Branch = "Nerimanov",
                    Note = "Hello world !",
                    Subject = "General English"
                },
                
                new Group()
                {
                    Id = 1,
                    Name = "1814_az",
                    Level = "Beginner",
                    Branch = "Nerimanov",
                    Note = "Hello world !",
                    Subject = "General English"
                },

                new Group()
                {
                    Id = 2,
                    Name = "1814_az",
                    Level = "Beginner",
                    Branch = "Nerimanov",
                    Note = "Hello world !",
                    Subject = "General English"
                }
            };
            
            GroupViewModel.AllGroups = groups;

        }
    }
}
