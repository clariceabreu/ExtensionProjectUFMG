using System;
namespace QuizBio.Models
{
    public class Query
    {
        private string _question;
        public string Question
        {
            get
            {
                return _question;
            }
            set
            {
                _question = value;
            }
        }

        private EOptions _answer;
        public EOptions Answer
        {
            get
            {
                return _answer;
            }
            set
            {
                _answer = value;
            }
        }

        private string _justification;
        public string Justification
        {
            get
            {
                return _justification;
            }
            set
            {
                _justification = value;
            }
        }

        private string _option1;
        public string Option_1
        {
            get
            {
                return _option1;
            }
            set
            {
                _option1 = value;
            }
        }

        private string _option2;
        public string Option_2
        {
            get
            {
                return _option2;
            }
            set
            {
                _option2 = value;
            }
        }

        private string _option3;
        public string Option_3
        {
            get
            {
                return _option3;
            }
            set
            {
                _option3 = value;
            }
        }

        private string _option4;
        public string Option_4
        {
            get
            {
                return _option4;
            }
            set
            {
                _option4 = value;
            }
        }

        public Query()
        {
        }

        public Query(string question, EOptions answer, string justification, string option_1, string option_2, string option_3, string option_4)
        {
            Question = question;
            Answer = answer;
            Justification = justification;
            Option_1 = option_1;
            Option_2 = option_2;
            Option_3 = option_3;
            Option_4 = option_4;
        }
    }
}
