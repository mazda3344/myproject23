

using System;
using TMPro;
using UnityEngine;

public class Random : MonoBehaviour{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Text outputText;
    private  int randomValue;
    private void Start() {
        GenerateRandomValue();
    }

    private void GenerateRandomValue(){
    
        randomValue = Random.Range(0, 101);
    }

    private static int Range(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    public void OnButton() {
        int userEnterValue = ReadFromInputField(inputField);
    }

    private int ReadFromInputField(TMP_InputField inputField)
    {
        ;
    }
}