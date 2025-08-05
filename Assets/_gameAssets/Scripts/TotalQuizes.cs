using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalQuizes : MonoBehaviour
{
    public Text totalQuizesText;

    public static TotalQuizes instance;

    void Awake()
    {
        StartCoroutine(UpdateQuizesText());
    }

    public void AddCompletedQuiz()
    {
        PlayerPrefs.SetInt("totalQuizes", PlayerPrefs.GetInt("totalQuizes", 0) + 1);
        PlayerPrefs.Save();
    }

    IEnumerator UpdateQuizesText()
    {
        while (gameObject.activeInHierarchy)
        {
            totalQuizesText.text = $"Total quizes completed: {PlayerPrefs.GetInt("totalQuizes", 0).ToString()}";
            yield return new WaitForSeconds(1f);
        }
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void CreateInstance()
    {
        if (instance == null)
        {
            instance = GameObject.FindObjectOfType<TotalQuizes>();
        }
    }
}
