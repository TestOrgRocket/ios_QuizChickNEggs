using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCard : MonoBehaviour
{
    public string question;
    public string answer;
    public Sprite questionBg, answerBg;

    public Text questionCardText,answerText;

    public bool flipped = false;

    Button _cardButton;

    public void SetUp(string questionText, string answerString)
    {
        question = questionText;
        answer = answerString;
        flipped = false;
        _cardButton = GetComponent<Button>();
        _cardButton.onClick.RemoveAllListeners();
        _cardButton.onClick.AddListener(FlipCard);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        questionCardText.text = question;
        answerText.text = answer;

        questionCardText.gameObject.SetActive(true);
        answerText.gameObject.SetActive(false);

        GetComponent<Image>().sprite = questionBg;
    }

    public void FlipCard()
    {
        flipped = !flipped;
        _cardButton.interactable = false;
        transform.DORotate(new Vector3(0, flipped ? 180 : 0, 0), 0.5f).OnComplete(() =>
        { _cardButton.interactable = true; });
        StartCoroutine(HalfWayActions());
    }

    IEnumerator HalfWayActions()
    {
        yield return new WaitForSeconds(0.25f);
        questionCardText.gameObject.SetActive(!flipped);
        answerText.gameObject.SetActive(flipped);
        GetComponent<Image>().sprite = flipped ? answerBg : questionBg;
    }
}
