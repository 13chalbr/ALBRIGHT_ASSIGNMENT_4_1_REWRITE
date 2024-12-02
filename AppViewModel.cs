using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Services;
using ALBRIGHT_ASSIGNMENT_4_1_REWRITE.Utility;
using ALBRIGHT_ASSIGNMENT_4_1_REWRITE.ViewModels;

namespace ALBRIGHT_ASSIGNMENT_4_1_REWRITE
{
    public class AppViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value); }
        }

        private BookViewModel _bookVM;
        public BookViewModel BookVM
        {
            get { return _bookVM; }
            set { OnPropertyChanged(ref _bookVM, value); }
        }

        public AppViewModel()
        {
            var dataService = new MockDataService();

            BookVM = new BookViewModel(dataService);
            CurrentView = BookVM;
        }
    }
}
