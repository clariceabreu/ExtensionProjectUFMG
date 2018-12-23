using System;
using System.Collections.Generic;

namespace QuizBio.Models
{
    public class QueriesList
    {
        public static List<Query> QList = new List<Query>();

        public static void InitializeList()
        {
            string question = "Qual dos seguintes animais é do filo dos cordados?";
            EOptions answer = EOptions.Option_2;
            string justification = "Os cordados são animais cuja principal característica é a presença de notocorda, que consiste em uma estrutura localizada entre o tubo digestivo e a medula espinal. Dos animais citados apenas a baleia possui notocorda.";
            string option_1 = "Borboleta";
            string option_2 = "Baleia";
            string option_3 = "Aranha";
            string option_4 = "Polvo";

            Query query_1 = new Query(question, answer, justification, option_1, option_2, option_3, option_4);
            QList.Add(query_1);

            question = "Na espécie humana podemos distinguir quatro tipos sanguíneos diferentes: A, B, AB e O. Imagine que uma pessoa possui tipo sanguíneo O. Marque a alternativa que indica as características desse tipo sanguíneo.";
            answer = EOptions.Option_4;
            justification = "O sangue tipo O não apresenta aglutinogênios em suas hemácias, entretanto possui aglutininas anti-A e anti-B em seu plasma. Isso faz com que uma pessoa do tipo O só possa receber sangue desse mesmo tipo sanguíneo.";
            option_1 = "Possui aglutinogênios A e aglutinina anti-B";
            option_2 = "Possui aglutinogênio B e aglutinina anti-A";
            option_3 = "Possui aglutinogênio AB e não possui aglutininas";
            option_4 = "Não possui aglutinogênio e possui aglutininas anti-A e anti-B";

            Query query_2 = new Query(question, answer, justification, option_1, option_2, option_3, option_4);
            QList.Add(query_2);
        }
    }
}
