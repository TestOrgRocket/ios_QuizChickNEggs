using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Riddle1 : MonoBehaviour
{
    public string answer;
    public List<Button> codeButtons;
    public Image inputContainer;
    public Text inputList;
    public Sprite correctSprite;
    public Sprite incorrectSprite;
    public Sprite defaultSprite;

    public List<Sprite> randomButtonSprites;

    string _input;

    void OnEnable()
    {
        foreach (Button button in codeButtons)
        {
            button.interactable = true;
        }
        _input = "";
        foreach (Button button in codeButtons)
        {
            button.onClick.RemoveAllListeners();
        }
        for (int i = 0; i < 10; i++)
        {
            int btnNum = i;
            codeButtons[i].onClick.AddListener(() =>
            {
                buttonPress(btnNum);
            });
        }
        foreach(Button randomButton in codeButtons)
        {
            randomButton.image.sprite = randomButtonSprites[Random.Range(0, randomButtonSprites.Count)];
        }
    }

    void buttonPress(int thisNumber)
    {
        Debug.Log($"thisNumber was pressed: {thisNumber}");
        _input += thisNumber.ToString();
        changeInputText();
    }

    void changeInputText()
    {
        string newText = "";
        for (int i = 0; i < 4; i++)
        {
            if (_input.Length > i)
            {
                newText += _input[i].ToString();
            }
            else
            {
                newText += "_";
            }
            if (i < 3)
            {
                newText += " ";
            }
        }
        inputList.text = newText;

        if (_input.Length == 4)
        {
            StartCoroutine(delayCheck());
        }
    }

    IEnumerator delayCheck()
    {
        bool result = _input == answer;
        foreach (Button button in codeButtons)
        {
            button.interactable = false;
        }
        yield return new WaitForSeconds(1f);
        if (result)
        {
            inputContainer.sprite = correctSprite;
        }
        else
        {
            inputContainer.sprite = incorrectSprite;
        }
        yield return new WaitForSeconds(2f);
        if (!result)
        {
            foreach (Button button in codeButtons)
            {
                button.interactable = true;
            }
            inputList.text = "_ _ _ _";
            _input = "";
            inputContainer.sprite = defaultSprite;
            changeInputText();
        }
    }
}
