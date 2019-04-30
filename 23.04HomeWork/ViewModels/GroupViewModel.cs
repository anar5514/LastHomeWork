using _23._04HomeWork.Commands;
using _23._04HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04HomeWork.ViewModels
{
    public class GroupViewModel : BaseViewModel
    {
        public AddGroupCommand AddGroupCommand => new AddGroupCommand(this);

        private List<Group> allGroups;

        public Group CurrentGroup { get; set; }

        public List<Group> AllGroups
        {
            get
            {
                return allGroups;
            }
            set
            {
                allGroups = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("AllGroups"));
            }
        }

    }
}
