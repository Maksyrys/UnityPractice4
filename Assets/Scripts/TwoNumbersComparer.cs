using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private TMP_InputField _firsNumber;
    [SerializeField] private TMP_InputField _secondNumber;
    [SerializeField] private TextMeshProUGUI _resultField;

    public void ThoNumbersComparer()
    {
        int firstNumber = Convert.ToInt32(_firsNumber.text);
        int secondNumber = Convert.ToInt32(_secondNumber.text);
        if(firstNumber < secondNumber)
        {
            string result = "Первое число меньше второго";
            _resultField.text = result;
        }
        else if(firstNumber == secondNumber)
        {
            string result = "Числа равны";
            _resultField.text = result;
        }
        else
        {
            string result = "Первое число больше второго";
            _resultField.text = result;
        }
    }
}
