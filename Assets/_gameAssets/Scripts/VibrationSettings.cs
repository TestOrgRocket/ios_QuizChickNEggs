using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CandyCoded.HapticFeedback;

public class VibrationSettings : MonoBehaviour
{
    Button _vibroButton;
    [SerializeField] Sprite OffState, OnState;

    public static bool IsVibro = false;

    private void Awake() {
        _vibroButton = GetComponent<Button>();
        IsVibro = PlayerPrefs.GetInt("vibro",0) == 1;
        _vibroButton.image.sprite = IsVibro ? OnState : OffState;
        _vibroButton.onClick.AddListener(() => {
            IsVibro = !IsVibro;
            PlayerPrefs.SetInt("vibro",IsVibro ? 1 : 0);
            PlayerPrefs.Save();
            _vibroButton.image.sprite = IsVibro ? OnState : OffState;
            if(IsVibro){
                // Vibration.Vibrate();
                HapticFeedback.MediumFeedback();
            }
        });
    }

    public static void Vibrate(){
        if(!IsVibro)return;
        // Vibration.Vibrate();
        HapticFeedback.MediumFeedback();
        Debug.Log("Vibrations");
    }
}
