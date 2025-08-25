using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.Advertisement.IosSupport;
using DG.Tweening;
public class ScreenManager : MonoBehaviour
{
    public GameObject Menu, Game, Result, allQuestions, privacy;
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
        privacy.SetActive(false);
        Menu.transform.localScale = Vector3.zero;
        Game.transform.localScale = Vector3.zero;
        Result.transform.localScale = Vector3.zero;
        allQuestions.transform.localScale = Vector3.zero;
        privacy.transform.localScale = Vector3.zero;
    }
    public void OpenAllQuestions()
    {
        CloseAll();
        allQuestions.SetActive(true);
        allQuestions.transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.OutBounce);
    }
    public void OpenMenu()
    {
        CloseAll();
        Menu.SetActive(true);
        Menu.transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.OutBounce);
    }
    public void OpenGame()
    {
        CloseAll();
        Game.SetActive(true);
        Game.transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.OutBounce);
    }
    public void OpenResult()
    {
        CloseAll();
        Result.SetActive(true);
        Result.transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.OutBounce);
    }
    public void OpenPrivacy()
    {
        // Application.OpenURL(privacyLink);
        CloseAll();
        privacy.SetActive(true);
        privacy.transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.OutBounce);
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
