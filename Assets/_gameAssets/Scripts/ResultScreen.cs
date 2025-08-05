using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static QuizClasses;

public class ResultScreen : MonoBehaviour
{
    public GameObject givenAnswersText;

    public GameObject questionPrefab;
    public Transform questionsContainer;
    public ScrollRectAutoSize scrollRectAutoSize;

    void setUpCards()
    {
        foreach (PickedQuizQuestions question in _pickedQuestions)
        {
            GameObject newQuestion = Instantiate(questionPrefab, questionsContainer);
            ResultQuestionCard questionCard = newQuestion.GetComponent<ResultQuestionCard>();
            questionCard.SetUp(question.question, question.answer, question.givenAnswer, question.isCorrect);
        }
        scrollRectAutoSize.ChangeSize();
        Debug.Log("Questions Placed");
    }

    public Text correctAnswersText, incorrectAnswersText;
    public Text title;

    QuizData _quizData;
    List<PickedQuizQuestions> _pickedQuestions = new List<PickedQuizQuestions>();
    public void AddQuestion(PickedQuizQuestions question) => _pickedQuestions.Add(question);
    public class PickedQuizQuestions
    {
        public string question;
        public string answer;
        public string givenAnswer;
        public bool isCorrect;

        public PickedQuizQuestions(string question, string answer, string givenAnswer, bool isCorrect)
        {
            this.question = question;
            this.answer = answer;
            this.givenAnswer = givenAnswer;
            this.isCorrect = isCorrect;
        }
    }

    public void ShowResults(int correctAnswers, int incorrectAnswers)
    {
        foreach (Transform child in questionsContainer.transform) Destroy(child.gameObject);
        if (correctAnswers < 7)
        {
            title.text = "QUIZ FAILED";
        }
        else
        {
            title.text = "QUIZ COMPLETED";
            TotalQuizes.instance.AddCompletedQuiz();
        }
        correctAnswersText.text = $"Correct answers: {correctAnswers}";
        incorrectAnswersText.text = $"Incorrect answers: {incorrectAnswers}";
        Debug.Log($"Count: {_pickedQuestions.Count}");
        setUpCards();
        givenAnswersText.SetActive(false);
    }

    void OnDisable()
    {
        foreach (Transform child in questionsContainer.transform) Destroy(child.gameObject);
        _pickedQuestions = new List<PickedQuizQuestions>();
    }
}
