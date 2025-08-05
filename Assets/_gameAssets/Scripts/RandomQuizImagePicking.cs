using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuizImagePicking : MonoBehaviour
{
    public List<Sprite> quizImages;
    public Image quizImage;

    public void PickRandomQuizImage()
    {
        quizImage.sprite = quizImages[Random.Range(0, quizImages.Count)];
    }
}
