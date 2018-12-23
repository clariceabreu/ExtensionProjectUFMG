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

            if (Session.HitsCount >= 5)
            {
                FinishText = "Parabéns!";
            }
            else
            {
                FinishText = "Fim";
            }

            HitsCount = "Você acertou " + Session.HitsCount + " das 10 questões.";
        }

        #region functions
        private async void GoToMainPage()
        {
            await _navigationService.NavigateAsync(new Uri("http://QuizBio.com/NavigationPage/MainPage", UriKind.Absolute));
        }
        #endregion

        #region properties
        private string _finishText;
        public string FinishText
        {
            get { return _finishText; }
            set { SetProperty(ref _finishText, value); }
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
