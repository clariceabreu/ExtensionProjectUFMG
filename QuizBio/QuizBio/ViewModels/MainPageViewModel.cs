using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizBio.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand Initialize { get; private set; }

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Initialize = new DelegateCommand(GoToQueryPage);

            _navigationService = navigationService;
        }

        public void GoToQueryPage()
        {
            _navigationService.NavigateAsync("QueryPage");
        }

    }
}
