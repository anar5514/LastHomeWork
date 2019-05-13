using _23._04HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _23._04HomeWork.Commands.GroupsViewCommands
{
    public class RejectGroupCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private GroupViewModel groupViewModel;

        public RejectGroupCommand(GroupViewModel groupViewModel)
        {
            this.groupViewModel = groupViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var item = groupViewModel.SelectedItem;
            groupViewModel.AllGroups.Remove(item);
            groupViewModel.CurrentGroup = new Entities.Group();
        }
    }
}
