using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using QuizBio.Models;
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
            Session.HitsCount = 0;
            NavigationParameters navParam = new NavigationParameters();
            navParam.Add("QuestionNumber", 1);
            _navigationService.NavigateAsync("QueryPage",navParam);
        }

    }
}
