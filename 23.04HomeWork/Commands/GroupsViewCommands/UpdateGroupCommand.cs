using _23._04HomeWork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _23._04HomeWork.Commands.GroupsViewCommands
{
    public class UpdateGroupCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private GroupViewModel groupViewModel;

        public UpdateGroupCommand(GroupViewModel groupViewModel)
        {
            this.groupViewModel = groupViewModel;
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            var item = groupViewModel.AllGroups.FirstOrDefault(x => x.Id == groupViewModel.CurrentGroup.Id);

            if (item != null)
            {
                var index = groupViewModel.AllGroups.IndexOf(item);
                groupViewModel.AllGroups[index] = groupViewModel.CurrentGroup;
                MessageBoxResult update = MessageBox.Show("updated");
                groupViewModel.CurrentGroup = new Entities.Group();
                groupViewModel.SelectedItem = new Entities.Group();
            }
        }
    }
}
