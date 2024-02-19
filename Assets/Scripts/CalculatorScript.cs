using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField _firsNumber;
    [SerializeField] private TMP_InputField _secondNumber;
    [SerializeField] private TextMeshProUGUI _resultField;


    public void onPressAdd()
    {
        int firstNumber = Convert.ToInt32(_firsNumber.text);
        int secondNumber = Convert.ToInt32(_secondNumber.text);
        int result = firstNumber + secondNumber;
        _resultField.text = result.ToString();
    }

    public void onPressSubtraction()
    {
        int firstNumber = Convert.ToInt32(_firsNumber.text);
        int secondNumber = Convert.ToInt32(_secondNumber.text);
        int result = firstNumber - secondNumber;
        _resultField.text = result.ToString();
    }

    public void onPressMultiplication()
    {
        int firstNumber = Convert.ToInt32(_firsNumber.text);
        int secondNumber = Convert.ToInt32(_secondNumber.text);
        int result = firstNumber * secondNumber;
        _resultField.text = result.ToString();
    }

    public void onPressSeparation()
    {
        int firstNumber = Convert.ToInt32(_firsNumber.text);
        int secondNumber = Convert.ToInt32(_secondNumber.text);
        if(secondNumber == 0)
        {
            string result = "Ошибка";
            _resultField.text = result;
        }
        else
        {
            float result = (float)firstNumber / secondNumber;
            _resultField.text = result.ToString();
        }
        
    }
}
