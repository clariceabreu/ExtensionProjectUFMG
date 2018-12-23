using System;
using Prism.Commands;
using Prism.Navigation;
using QuizBio.Models;

namespace QuizBio.ViewModels
{
    public class FinishPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand GoBackTapped { get; private set; }

        public FinishPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;

            Title = "Fim";

            GoBackTapped = new DelegateCommand(GoToMainPage);

            if (Session.hitsCount > 1)
            {
                CongratulationsVisible = true;
            }

            HitsCount = "Você acertou " + Session.hitsCount + " das 10 questões.";
        }

        #region functions
        private async void GoToMainPage()
        {
            await _navigationService.NavigateAsync(new Uri("app://NavigationPage/MainPage", UriKind.Absolute));
        }
        #endregion

        #region properties
        private bool _congratulationsVisible;
        public bool CongratulationsVisible
        {
            get { return _congratulationsVisible; }
            set { SetProperty(ref _congratulationsVisible, value); }
        }

        private string _hitsCount;
        public string HitsCount
        {
            get { return _hitsCount; }
            set { SetProperty(ref _hitsCount, value); }
        }
        #endregion
    }
}
