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
        }
    }
}
