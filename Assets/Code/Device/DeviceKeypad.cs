using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeviceKeypad : MonoBehaviour
{
    [SerializeField]
    string code;
    string currentCode;
    [SerializeField]
    int maxLength = 4;
    AudioSource audioSource;
    [SerializeField]
    AudioClip beep;
    [SerializeField]
    AudioClip error;
    [SerializeField]
    AudioClip correct;
    [SerializeField]
    UnityEvent OnCodeCorrect;
    public event Action OnCodeCorrectEvent;
    public void ClearCode()
    {
        currentCode = "";
    }
    public void CheckCode(){
        if(currentCode == code){
            OnCodeCorrect?.Invoke();
            OnCodeCorrectEvent?.Invoke();
            PlaySound(SoundType.Correct);
        }else{
            PlaySound(SoundType.Error);
        }
        ClearCode();
    }
    public void AddCode(string c){
        currentCode += c;
        if(maxLength > 0 && currentCode.Length >= maxLength)
            CheckCode();
        else
            PlaySound(SoundType.Beep);
    }
    void PlaySound(SoundType type){
        switch(type){
            case SoundType.Beep:
                audioSource.PlayOneShot(beep);
                break;
            case SoundType.Error:
                audioSource.PlayOneShot(error);
                break;
            case SoundType.Correct:
                audioSource.PlayOneShot(correct);
                break;
        }
    }

    void Awake(){
        audioSource = GetComponent<AudioSource>();
        if(audioSource == null){
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
    enum SoundType{
        Beep,
        Error,
        Correct
    }
}
