using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    [SerializeField] InputField inputField1, inputField2, ravaTotal, maidaTotal;
    [SerializeField] Text textView;
    private int current;
    private TouchScreenKeyboard keyboard;
    float ans;

    public void OpenKeyboard()
    {

      //keyboard = TouchScreenKeyboard.Open(inputField1.text, TouchScreenKeyboardType.Default);
        //TouchScreenKeyboard.Open(inputField1.text, TouchScreenKeyboardType.Default);
    }
    public void Add()
    {
        /*
        int num1 = int.Parse(inputField1.text);
        int num2 = int.Parse(inputField2.text);
        int ans = num1 + num2;
        textView.text = "Ans = " + ans;
        */

        

    }
    private void Update()
    {
        /*if (inputField1.isFocused)
        {
           keyboard = TouchScreenKeyboard.Open(inputField1.text, TouchScreenKeyboardType.Default);
        }*/
    }

    public void Total()
    {
        float rava = float.Parse(inputField1.text);
        float maida = float.Parse(inputField2.text);
        float rava_Total = rava * 44;
        float maida_Total = maida * 40;
        ravaTotal.text = rava_Total.ToString();
        maidaTotal.text = maida_Total.ToString();


    }
    

    /*public void Store(int value)
    {
        if (inputField1.text != "")
        {
            inputField1.text = inputField1.text + value;
            current = int.Parse(inputField1.text);
           
        }
        else
        {
            inputField1.text = value.ToString();
            current = value;
        }
    
    }
*/    
}
