using UnityEngine;
using static QuizClasses;
using static QuizQuestions;

public class AllQuestionsScreenHandler : MonoBehaviour
{
    public GameObject questionPrefab;
    public Transform questionsContainer;
    public QuizQuestions quizQuestions;

    public ScrollRectAutoSize scrollRectAutoSize;

    QuizData _quizData;

    bool _arePlaced = false;

    void OnEnable()
    {
        if(_arePlaced) return;
        _arePlaced = true;
        _quizData = quizQuestions.chickenEggQuiz;
        foreach (Question question in _quizData.Questions)
        {
            GameObject newQuestion = Instantiate(questionPrefab, questionsContainer);
            QuestionCard questionCard = newQuestion.GetComponent<QuestionCard>();
            questionCard.SetUp(question.QuestionText, question.Answer);
        }
        scrollRectAutoSize.ChangeSize();

        Debug.Log("Questions Placed");
    }
}