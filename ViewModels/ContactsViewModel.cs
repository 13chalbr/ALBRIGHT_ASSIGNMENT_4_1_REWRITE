using ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Utility;
using ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Models;
using ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ALBRIGHT_ASSIGNMENT_4_1_REWRITE.ViewModels
{
    public class ContactsViewModel : ObservableObject
    {
        private Contact _selectedContact;
        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set { OnPropertyChanged(ref _selectedContact, value); }
        }

        private bool _isEditMode;
        public bool IsEditMode
        {
            get { return _isEditMode; }
            set
            {
                OnPropertyChanged(ref _isEditMode, value);
                OnPropertyChanged("IsDisplayMode");
            }
        }
        public bool IsDisplayMode
        {
            get { return !_isEditMode; }
        }

        public ObservableCollection<Contact> Contacts { get; private set; }

        public ICommand EditCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }
        public ICommand UpdateCommand { get; private set; }
        public ICommand BrowseImageCommand { get; private set; }
        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public ContactsViewModel()
        {

        }

        public void LoadContacts(IEnumerable<Contact> contacts)
        {
            Contacts = new ObservableCollection<Contact>(contacts);
            OnPropertyChanged("Contacts");
        }


    }
}
