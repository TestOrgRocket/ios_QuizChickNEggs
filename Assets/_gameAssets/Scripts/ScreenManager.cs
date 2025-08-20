using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.Advertisement.IosSupport;
public class ScreenManager : MonoBehaviour
{
    public GameObject Menu, Game, Result, allQuestions;
    public string privacyLink;
    void Start()
    {

        StartCoroutine(delayActions());
        IEnumerator delayActions()
        {
            yield return new WaitForSeconds(0.5f);
            if (ATTrackingStatusBinding.GetAuthorizationTrackingStatus() == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED)
            {
                ATTrackingStatusBinding.RequestAuthorizationTracking();
            }
        }
    }
    public void CloseAll()
    {
        Menu.SetActive(false);
        Game.SetActive(false);
        Result.SetActive(false);
        allQuestions.SetActive(false);
    }
    public void OpenAllQuestions()
    {
        CloseAll();
        allQuestions.SetActive(true);
    }
    public void OpenMenu()
    {
        CloseAll();
        Menu.SetActive(true);
    }
    public void OpenGame()
    {
        CloseAll();
        Game.SetActive(true);
    }
    public void OpenResult()
    {
        CloseAll();
        Result.SetActive(true);
    }
    public void OpenPrivacy()
    {
        Application.OpenURL(privacyLink);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
