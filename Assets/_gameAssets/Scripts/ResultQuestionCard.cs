using UnityEngine;
using UnityEngine.UI;

public class ResultQuestionCard : MonoBehaviour
{
    public Text questionText, answerText, playerAnswerText;
    public Image cardImage;
    public Sprite incorrectSprite, correctSprite;

    public void SetUp(string question, string answer, string playerAnswer, bool isCorrect) {
        questionText.text = question;
        answerText.text = $"Correct answer: {answer}";
        playerAnswerText.text = $"Your answer: {playerAnswer}";
        cardImage.sprite = isCorrect ? correctSprite : incorrectSprite;
    }
}