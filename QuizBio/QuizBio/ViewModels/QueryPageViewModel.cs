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

                if (questionNumber == 1)
                {
                    Title = "Questão 1";
                    Question_1();
                    _currentQuestionNumber = 1;
                }
                else if (questionNumber == 2)
                {
                    Title = "Questão 2";
                    Question_2();
                    _currentQuestionNumber = 2;
                }
                else if (questionNumber == 3)
                {
                    Title = "Questão 3";
                    Question_3();
                    _currentQuestionNumber = 3;
                }
                else if (questionNumber == 4)
                {
                    Title = "Questão 4";
                    Question_4();
                    _currentQuestionNumber = 4;
                }
                else if (questionNumber == 5)
                {
                    Title = "Questão 5";
                    Question_5();
                    _currentQuestionNumber = 5;
                }
                else if (questionNumber == 6)
                {
                    Title = "Questão 6";
                    Question_6();
                    _currentQuestionNumber = 6;
                }
                else if (questionNumber == 7)
                {
                    Title = "Questão 7";
                    Question_7();
                    _currentQuestionNumber = 7;
                }
                else if (questionNumber == 8)
                {
                    Title = "Questão 8";
                    Question_8();
                    _currentQuestionNumber = 8;
                }
                else if (questionNumber == 9)
                {
                    Title = "Questão 9";
                    Question_9();
                    _currentQuestionNumber = 9;
                }
                else if (questionNumber == 10)
                {
                    Title = "Questão 10";
                    Question_10();
                    _currentQuestionNumber = 10;
                }
            }
        }

        #region Set Questions
        public void Question_1()
        {
            QueriesList.InitializeList();

            Question = QueriesList.QList[0].Question;
            Answer = QueriesList.QList[0].Answer;
            Justification = QueriesList.QList[0].Justification;
            Option_1 = QueriesList.QList[0].Option_1;
            Option_2 = QueriesList.QList[0].Option_2;
            Option_3 = QueriesList.QList[0].Option_3;
            Option_4 = QueriesList.QList[0].Option_4;
        }

        private void Question_2()
        {
            Question = QueriesList.QList[1].Question;
            Answer = QueriesList.QList[1].Answer;
            Justification = QueriesList.QList[1].Justification;
            Option_1 = QueriesList.QList[1].Option_1;
            Option_2 = QueriesList.QList[1].Option_2;
            Option_3 = QueriesList.QList[1].Option_3;
            Option_4 = QueriesList.QList[1].Option_4;
        }

        private void Question_3()
        {
            Question = QueriesList.QList[2].Question;
            Answer = QueriesList.QList[2].Answer;
            Justification = QueriesList.QList[2].Justification;
            Option_1 = QueriesList.QList[2].Option_1;
            Option_2 = QueriesList.QList[2].Option_2;
            Option_3 = QueriesList.QList[2].Option_3;
            Option_4 = QueriesList.QList[2].Option_4;
        }

        private void Question_4()
        {
            Question = QueriesList.QList[3].Question;
            Answer = QueriesList.QList[3].Answer;
            Justification = QueriesList.QList[31].Justification;
            Option_1 = QueriesList.QList[3].Option_1;
            Option_2 = QueriesList.QList[3].Option_2;
            Option_3 = QueriesList.QList[3].Option_3;
            Option_4 = QueriesList.QList[3].Option_4;
        }

        private void Question_5()
        {
            Question = QueriesList.QList[4].Question;
            Answer = QueriesList.QList[4].Answer;
            Justification = QueriesList.QList[4].Justification;
            Option_1 = QueriesList.QList[4].Option_1;
            Option_2 = QueriesList.QList[4].Option_2;
            Option_3 = QueriesList.QList[4].Option_3;
            Option_4 = QueriesList.QList[4].Option_4;
        }

        private void Question_6()
        {
            Question = QueriesList.QList[5].Question;
            Answer = QueriesList.QList[5].Answer;
            Justification = QueriesList.QList[5].Justification;
            Option_1 = QueriesList.QList[5].Option_1;
            Option_2 = QueriesList.QList[5].Option_2;
            Option_3 = QueriesList.QList[5].Option_3;
            Option_4 = QueriesList.QList[5].Option_4;
        }

        private void Question_7()
        {
            Question = QueriesList.QList[6].Question;
            Answer = QueriesList.QList[6].Answer;
            Justification = QueriesList.QList[6].Justification;
            Option_1 = QueriesList.QList[6].Option_1;
            Option_2 = QueriesList.QList[6].Option_2;
            Option_3 = QueriesList.QList[6].Option_3;
            Option_4 = QueriesList.QList[6].Option_4;
        }

        private void Question_8()
        {
            Question = QueriesList.QList[7].Question;
            Answer = QueriesList.QList[7].Answer;
            Justification = QueriesList.QList[7].Justification;
            Option_1 = QueriesList.QList[7].Option_1;
            Option_2 = QueriesList.QList[7].Option_2;
            Option_3 = QueriesList.QList[7].Option_3;
            Option_4 = QueriesList.QList[7].Option_4;
        }

        private void Question_9()
        {
            Question = QueriesList.QList[8].Question;
            Answer = QueriesList.QList[8].Answer;
            Justification = QueriesList.QList[8].Justification;
            Option_1 = QueriesList.QList[8].Option_1;
            Option_2 = QueriesList.QList[8].Option_2;
            Option_3 = QueriesList.QList[8].Option_3;
            Option_4 = QueriesList.QList[8].Option_4;
        }

        private void Question_10()
        {
            Question = QueriesList.QList[9].Question;
            Answer = QueriesList.QList[9].Answer;
            Justification = QueriesList.QList[9].Justification;
            Option_1 = QueriesList.QList[9].Option_1;
            Option_2 = QueriesList.QList[9].Option_2;
            Option_3 = QueriesList.QList[9].Option_3;
            Option_4 = QueriesList.QList[9].Option_4;
        }
        #endregion

        private async void CheckAnswer()
        {
            if (_optionTapped == Answer)
            {
                Session.hitsCount++;

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

            JustificationVisible = true;
            FadeIn(Answer);
        }

        private async void GoToNextQuestion()
        {
            if (_currentQuestionNumber == 2)
            {

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

        private bool _option1Visible = true;
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

        private bool _option2Visible = true;
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

        private bool _option3Visible = true;
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

        private bool _option4Visible = true;
        public bool Option_4_Visible
        {
            get { return _option4Visible; }
            set { SetProperty(ref _option4Visible, value); }
        }
        #endregion
    }
}
