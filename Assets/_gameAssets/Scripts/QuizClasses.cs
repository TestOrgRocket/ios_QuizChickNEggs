using UnityEngine;
public class QuizClasses : MonoBehaviour
{
    public class Question
    {
        public string QuestionText;
        public string[] Options;
        public string Answer;
    }
    public class QuizData
    {
        public Question[] Questions;
    }
}