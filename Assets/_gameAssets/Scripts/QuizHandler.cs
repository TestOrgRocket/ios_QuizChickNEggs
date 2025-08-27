using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static QuizClasses;
using static ResultScreen;

public class QuizHandler : MonoBehaviour
{
    public RandomQuizImagePicking randomQuizImagePicking;
    public List<Button> quizOptions;
    public Text quizText;
    public Text quizNumberText;
    public ScreenManager screenManager;
    public ResultScreen resultScreen;
    public int quizQuestions = 10;

    private List<Question> _selectedQuestions = new List<Question>();
    private int _currentQuestionIndex = 0;
    private int _correctAnswers = 0;

    int _currentQuizNumber;
    string _currentQuizQuestion;

    int _correctAnswersCount = 0;
    int _incorrectAnswersCount = 0;

    void OnEnable()
    {
        redImage.SetActive(false);
        greenImage.SetActive(false);
        ResetGame();
    }

    void ResetGame()
    {
        _currentQuestionIndex = -1;
        _correctAnswersCount = 0;
        _incorrectAnswersCount = 0;
        SelectQuestions();
        NextQuestion();
    }

    void NextQuestion()
    {
        _currentQuestionIndex++;
        if (_currentQuestionIndex >= quizQuestions)
        {
            EndQuiz();
            return;
        }
        quizNumberText.text = $"Question {_currentQuestionIndex + 1} of {quizQuestions}";
        randomQuizImagePicking.PickRandomQuizImage();
        showCurrentQuestion();
    }

    void EndQuiz()
    {
        Debug.Log($"Quiz ended! Correct answers: {_correctAnswersCount}, Incorrect answers: {_incorrectAnswersCount}");
        resultScreen.ShowResults(_correctAnswersCount, _incorrectAnswersCount);
        screenManager.OpenResult();
    }

    void SelectQuestions()
    {
        List<Question> questions = new List<Question>();
        QuizData existingQuestions = GetComponent<QuizQuestions>().chickenEggQuiz;

        for (int i = 0; i < quizQuestions; i++)
        {
            questions.Add(existingQuestions.Questions[Random.Range(0, existingQuestions.Questions.Length)]);
        }

        _selectedQuestions = questions.ToList();
    }

    void showCurrentQuestion()
    {
        List<Tween> toExecute = new List<Tween>();
        quizText.text = "";
        string questionText = _selectedQuestions[_currentQuestionIndex].QuestionText;
        Tween t = quizText.DOText(questionText, 3f);
        toExecute.Add(t);
        List<string> options = _selectedQuestions[_currentQuestionIndex].Options.ToList();
        StartCoroutine(optionsCycle(options, _selectedQuestions[_currentQuestionIndex].Answer));
        // foreach (Button button in quizOptions)
        // {
        //     int randomIndex = Random.Range(0, options.Count);
        //     button.GetComponentInChildren<Text>().text = "";
        //     string optionText = options[randomIndex];
        //     Tween t2 = button.GetComponentInChildren<Text>().DOText(optionText, 5f);
        //     toExecute.Add(t2);
        //     if (options[randomIndex] == _selectedQuestions[_currentQuestionIndex].Answer)
        //     {
        //         button.onClick.RemoveAllListeners();
        //         button.onClick.AddListener(() =>
        //         {
        //             AddQuestionToEnd(button.GetComponentInChildren<Text>().text, true);
        //             correctAnswer();
        //         });
        //     }
        //     else
        //     {
        //         button.onClick.RemoveAllListeners();
        //         button.onClick.AddListener(() =>
        //         {
        //             AddQuestionToEnd(button.GetComponentInChildren<Text>().text, false);
        //             incorrectAnswer();
        //         });
        //     }
        //     options.RemoveAt(randomIndex);
        // }
        foreach (Tween tween in toExecute)
        {
            tween.Play();
        }
    }

    bool _buttonPressed = false;
    IEnumerator optionsCycle(List<string> options, string correctAnswerString)
    {
        do
        {
            yield return null;
            int currentQuestion = _currentQuestionIndex;
            buttonsDisable();
            _buttonPressed = false;
            string randomOption = options[Random.Range(0, options.Count)];
            Button randomButton = getRandomButton();
            randomButton.gameObject.SetActive(true);
            randomButton.GetComponentInChildren<Text>().text = "";
            randomButton.GetComponentInChildren<Text>().DOText(randomOption, 1.5f);
            if (randomOption == correctAnswerString)
            {
                randomButton.onClick.RemoveAllListeners();
                randomButton.onClick.AddListener(() =>
                {
                    AddQuestionToEnd(randomOption, true);
                    correctAnswer();
                });
            }
            else
            {
                randomButton.onClick.RemoveAllListeners();
                randomButton.onClick.AddListener(() =>
                {
                    AddQuestionToEnd(randomOption, false);
                    incorrectAnswer();
                });
            }
            yield return new WaitForSeconds(3f);
        } while (_buttonPressed == false);

        Button getRandomButton()
        {
            return quizOptions[Random.Range(0, quizOptions.Count)];
        }
        void buttonsDisable()
        {
            foreach (Button b in quizOptions)
            {
                b.gameObject.SetActive(false);
            }
        }
    }

    public void AddQuestionToEnd(string thisOption, bool isCorrect)
    {
        resultScreen.AddQuestion(new PickedQuizQuestions(
            quizText.text,
            _selectedQuestions[_currentQuestionIndex].Answer,
            thisOption,
            isCorrect
        ));
    }

    public void correctAnswer()
    {
        _buttonPressed = true;
        _correctAnswersCount++;
        VibrationSettings.Vibrate();
        StopAllCoroutines();
        StartCoroutine(FlashGreenImage());
        NextQuestion();
    }

    public void incorrectAnswer()
    {
        _buttonPressed = true;
        _incorrectAnswersCount++;
        VibrationSettings.Vibrate();
        StopAllCoroutines();
        StartCoroutine(FlashRedImage());
        NextQuestion();
    }
    public GameObject redImage, greenImage;
    IEnumerator FlashRedImage()
    {
        redImage.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        redImage.SetActive(false);
    }
    IEnumerator FlashGreenImage()
    {
        greenImage.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        greenImage.SetActive(false);
    }
}
