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

        public Action FadeOut { get; set; }
        public Action FadeIn { get; set; }

        private EOptions _optionTapped;

        public QueryPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Question1();

            Title = "Questão 1";

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

        }

        #region functions
        public void Question1()
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

        private async void CheckAnswer()
        {
            if (_optionTapped == Answer)
            {
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
            FadeIn();
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
