using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextSpeech;
using System;
using TMPro;

public class SpeechController : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;

    private void Start()
    {
        SpeechToText.Instance.onResultCallback = OnSpeechResult;
    }

    private void OnSpeechResult(string result)
    {
       inputField.text = result;
    }

    public void StartSpeechRecognition()
    {
        SpeechToText.Instance.StartRecording();
    }

    public void StartTextRecognitaion(string text)
    {
        TextToSpeech.Instance.StartSpeak(text);
    }
}
