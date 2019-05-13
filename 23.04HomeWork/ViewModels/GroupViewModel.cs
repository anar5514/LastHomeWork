using _23._04HomeWork.Commands;
using _23._04HomeWork.Commands.GroupsViewCommands;
using _23._04HomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04HomeWork.ViewModels
{
    public class GroupViewModel : BaseViewModel
    {
        public AddGroupCommand AddGroupCommand => new AddGroupCommand(this);
        public UpdateGroupCommand UpdateGroupCommand => new UpdateGroupCommand(this);
        public RejectGroupCommand RejectGroupCommand => new RejectGroupCommand(this);

        public ImportExcelCommand ImportExcelCommand => new ImportExcelCommand();
        public ImportPDFCommand ImportPDFCommand => new ImportPDFCommand();

        private ObservableCollection<Group> allGroups;

        private string text;

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Text)));
            }
        }

        private Group currentGroup;

        public Group CurrentGroup {

            get
            {
                return currentGroup;
            }
            set
            {
                currentGroup = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentGroup)));
            }
                
        }

        private int state; 

        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(State)));
            }
        }

        private Group selectedItem;

        public Group SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                if (value != null)
                {
                    CurrentGroup = SelectedItem.Clone();
                }
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(SelectedItem)));
            }
        }

        public List<Subject> Subjects { get; set; }

        public List<Level> Levels { get; set; }

        public List<Branch> Branches { get; set; }

        public ObservableCollection<Group> AllGroups
        {
            get
            {
                return allGroups;
            }
            set
            {
                allGroups = value;
                OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllGroups)));
            }
        }

    }
}
