using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using QuizBio.Models;
using Xamarin.Forms;

namespace QuizBio.ViewModels
{
    public class QueryPageViewModel: ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand Option_1_Tapped { get; private set; }
        public DelegateCommand Option_2_Tapped { get; private set; }
        public DelegateCommand Option_3_Tapped { get; private set; }
        public DelegateCommand Option_4_Tapped { get; private set; }
        public DelegateCommand NextTapped { get; private set; }

        public Action FadeOut { get; set; }
        public Action<EOptions> FadeIn { get; set; }

        private EOptions _optionTapped;
        private int _currentQuestionNumber;

        public QueryPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;

            Option_1_Tapped = new DelegateCommand(() =>
            {
                _optionTapped = EOptions.Option_1;
                CheckAnswer();
            });

            Option_2_Tapped = new DelegateCommand(() =>
            {
                _optionTapped = EOptions.Option_2;
                CheckAnswer();
            });

            Option_3_Tapped = new DelegateCommand(() =>
            {
                _optionTapped = EOptions.Option_3;
                CheckAnswer();
            });

            Option_4_Tapped = new DelegateCommand(() =>
            {
                _optionTapped = EOptions.Option_4;
                CheckAnswer();
            });

            NextTapped = new DelegateCommand(GoToNextQuestion);
        }

        #region functions
        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            if (parameters.Count > 0)
            {
                int questionNumber = (int)parameters["QuestionNumber"];

                if (questionNumber >= 1 && questionNumber <= 10)
                {
                    Title = "Questão " + questionNumber;
                    _currentQuestionNumber = questionNumber;
                    SetQuestion(questionNumber);

                    if (Session.QueriesAnswered.Contains(questionNumber))
                    {
                        ShowJustification();
                    }
                    else
                    {
                        ShowOptions();
                    }
                }
            }
        }


        public void SetQuestion(int questionNumber)
        {
            if (questionNumber == 1)
            {
                QueriesList.InitializeList();
                Session.QueriesAnswered.Clear();

            }

            questionNumber--; //Array starts at 0 instead of 1

            Question = QueriesList.QList[questionNumber].Question;
            Answer = QueriesList.QList[questionNumber].Answer;
            Justification = QueriesList.QList[questionNumber].Justification;
            Option_1 = QueriesList.QList[questionNumber].Option_1;
            Option_2 = QueriesList.QList[questionNumber].Option_2;
            Option_3 = QueriesList.QList[questionNumber].Option_3;
            Option_4 = QueriesList.QList[questionNumber].Option_4;
        }

        private void ShowOptions()
        {
            Option_1_Visible = true;
            Option_2_Visible = true;
            Option_3_Visible = true;
            Option_4_Visible = true;
        }

        private void ShowJustification()
        {
            if (Answer == EOptions.Option_1)
            {
                Option_1_Visible = true;
                Option_1_Color = Color.FromHex("#66B266");
                Option_2_Visible = false;
                Option_3_Visible = false;
                Option_4_Visible = false;
                JustificationVisible = true;
                JustificationOpacity = 1;
            }
            else if (Answer == EOptions.Option_2)
            {
                Option_1_Visible = false;
                Option_2_Visible = true;
                Option_2_Color = Color.FromHex("#66B266");
                Option_3_Visible = false;
                Option_4_Visible = false;
                JustificationVisible = true;
                JustificationOpacity = 1;
            }
            else if (Answer == EOptions.Option_3)
            {
                Option_1_Visible = false;
                Option_2_Visible = false;
                Option_3_Visible = true;
                Option_3_Color = Color.FromHex("#66B266");
                Option_4_Visible = false;
                JustificationVisible = true;
                JustificationOpacity = 1;
            }
            else
            {
                Option_1_Visible = false;
                Option_2_Visible = false;
                Option_3_Visible = false;
                Option_4_Visible = true;
                Option_4_Color = Color.FromHex("#66B266");
                JustificationVisible = true;
                JustificationOpacity = 1;
            }
        }

        private async void CheckAnswer()
        {
            if (_optionTapped == Answer)
            {
                Session.HitsCount++;

                if (_optionTapped == EOptions.Option_1)
                {
                    Option_1_Color = Color.FromHex("#66B266");

                    await Task.Delay(1000);

                    FadeOut();

                    await Task.Delay(800);

                    Option_1_Visible = false;
                    Option_2_Visible = false;
                    Option_4_Visible = false;
                }

                else if (_optionTapped == EOptions.Option_2)
                {
                    Option_2_Color = Color.FromHex("#66B266");

                    await Task.Delay(1000);

                    FadeOut();

                    await Task.Delay(800);

                    Option_1_Visible = false;
                    Option_3_Visible = false;
                    Option_4_Visible = false;
                }

                else if (_optionTapped == EOptions.Option_3)
                {
                    Option_3_Color = Color.FromHex("#66B266");

                    await Task.Delay(1000);

                    FadeOut();

                    await Task.Delay(800);

                    Option_1_Visible = false;
                    Option_2_Visible = false;
                    Option_4_Visible = false;
                }
                else
                {
                    Option_4_Color = Color.FromHex("#66B266");

                    await Task.Delay(1000);

                    FadeOut();

                    await Task.Delay(800);

                    Option_1_Visible = false;
                    Option_2_Visible = false;
                    Option_3_Visible = false;
                }
            }
            else
            {
                if (_optionTapped == EOptions.Option_1)
                    Option_1_Color = Color.FromHex("#FF7F7F");
                else if (_optionTapped == EOptions.Option_2)
                    Option_2_Color = Color.FromHex("#FF7F7F");
                else if (_optionTapped == EOptions.Option_3)
                    Option_3_Color = Color.FromHex("#FF7F7F");
                else
                    Option_4_Color = Color.FromHex("#FF7F7F");

                if (Answer == EOptions.Option_1)
                {
                    Option_1_Color = Color.FromHex("#66B266");

                    await Task.Delay(1000);

                    FadeOut();

                    await Task.Delay(800);

                    Option_2_Visible = false;
                    Option_3_Visible = false;
                    Option_4_Visible = false;
                }
                else if (Answer == EOptions.Option_2)
                {
                    Option_2_Color = Color.FromHex("#66B266");

                    await Task.Delay(1000);

                    FadeOut();

                    await Task.Delay(800);

                    Option_1_Visible = false;
                    Option_3_Visible = false;
                    Option_4_Visible = false;

                }
                else if (Answer == EOptions.Option_3)
                {
                    Option_3_Color = Color.FromHex("#66B266");

                    await Task.Delay(1000);

                    FadeOut();

                    await Task.Delay(800);

                    Option_1_Visible = false;
                    Option_2_Visible = false;
                    Option_4_Visible = false;
                }
                else
                {
                    Option_4_Color = Color.FromHex("#66B266");

                    await Task.Delay(1000);

                    FadeOut();

                    await Task.Delay(800);

                    Option_1_Visible = false;
                    Option_2_Visible = false;
                    Option_3_Visible = false;
                }
            }

            Session.QueriesAnswered.Add(_currentQuestionNumber);
            JustificationVisible = true;
            FadeIn(Answer);
        }

        private async void GoToNextQuestion()
        {
            if (_currentQuestionNumber == 3)
            {
                await _navigationService.NavigateAsync("FinishPage");
            }
            else
            {
                NavigationParameters navParam = new NavigationParameters();
                navParam.Add("QuestionNumber", _currentQuestionNumber + 1);
                await _navigationService.NavigateAsync("QueryPage", navParam);
            }
        }
        #endregion


        #region properties
        private string _question;
        public string Question
        {
            get { return _question; }
            set { SetProperty(ref _question, value); }
        }

        private string _option1;
        public string Option_1
        {
            get { return _option1; }
            set { SetProperty(ref _option1, value); }
        }

        private Color _option1Color = Color.White;
        public Color Option_1_Color
        {
            get { return _option1Color; }
            set { SetProperty(ref _option1Color, value); }
        }

        private bool _option1Visible;
        public bool Option_1_Visible
        {
            get { return _option1Visible; }
            set { SetProperty(ref _option1Visible, value); }
        }

        private string _option2;
        public string Option_2
        {
            get { return _option2; }
            set { SetProperty(ref _option2, value); }
        }

        private Color _option2Color = Color.White;
        public Color Option_2_Color
        {
            get { return _option2Color; }
            set { SetProperty(ref _option2Color, value); }
        }

        private bool _option2Visible;
        public bool Option_2_Visible
        {
            get { return _option2Visible; }
            set { SetProperty(ref _option2Visible, value); }
        }

        private string _option3;
        public string Option_3
        {
            get { return _option3; }
            set { SetProperty(ref _option3, value); }
        }

        private Color _option3Color = Color.White;
        public Color Option_3_Color
        {
            get { return _option3Color; }
            set { SetProperty(ref _option3Color, value); }
        }

        private bool _option3Visible;
        public bool Option_3_Visible
        {
            get { return _option3Visible; }
            set { SetProperty(ref _option3Visible, value); }
        }

        private string _option4;
        public string Option_4
        {
            get { return _option4; }
            set { SetProperty(ref _option4, value); }
        }

        private Color _option4Color = Color.White;
        public Color Option_4_Color
        {
            get { return _option4Color; }
            set { SetProperty(ref _option4Color, value); }
        }

        private bool _option4Visible;
        public bool Option_4_Visible
        {
            get { return _option4Visible; }
            set { SetProperty(ref _option4Visible, value); }
        }

        private EOptions _answer;
        public EOptions Answer
        {
            get { return _answer; }
            set { SetProperty(ref _answer, value); }
        }

        private string _justification;
        public string Justification
        {
            get { return _justification; }
            set { SetProperty(ref _justification, value); }
        }

        private bool _justificationVisible;
        public bool JustificationVisible
        {
            get { return _justificationVisible; }
            set { SetProperty(ref _justificationVisible, value); }
        }

        private int _justificationOpacity = 0;
        public int JustificationOpacity
        {
            get { return _justificationOpacity; }
            set { SetProperty(ref _justificationOpacity, value); }
        }
        #endregion
    }
}
