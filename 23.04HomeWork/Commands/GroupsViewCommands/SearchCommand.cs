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
    public class SearchCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private GroupViewModel groupViewModel;

        public ObservableCollection<Entities.Group> AllGroupsCopy { get; set; }

        public SearchCommand(GroupViewModel groupViewModel)
        {
            this.groupViewModel = groupViewModel;
            AllGroupsCopy = groupViewModel.AllGroups;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (groupViewModel.Text != String.Empty)
            {

                var items = AllGroupsCopy.Where(x => (x.Name == null) ? true : x.Name.Contains(groupViewModel.Text) || (x.Branch.Name == null) ? true : x.Branch.Name.Contains(groupViewModel.Text)
                || (x.Level.LevelName == null) ? true : x.Level.LevelName.Contains(groupViewModel.Text) || (x.Subject.Name == null) ? true : x.Subject.Name.Contains(groupViewModel.Text) ||
                (x.Note == null) ? true : x.Note.Contains(groupViewModel.Text)
                ).ToList();

                if (items.Count != 0)
                {

                    groupViewModel.AllGroups = new ObservableCollection<Entities.Group>(items);
                }
            }
            else
            {
                groupViewModel.AllGroups = AllGroupsCopy;
            }
        }
    }
}
