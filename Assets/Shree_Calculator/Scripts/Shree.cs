using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shree : MonoBehaviour
{
    [Header("Product Field")]
    [SerializeField] InputField ravaField;
    [SerializeField] InputField maidaField;
    [SerializeField] InputField shewayaField;
    [SerializeField] InputField papadField;

    [Header("Amount Field")]
    [SerializeField] InputField ravaAmount;
    [SerializeField] InputField maidaAmount;
    [SerializeField] InputField shewayaAmount;
    [SerializeField] InputField papadAmount;

    [Header("Total Field")]
    [SerializeField] InputField ravaTotal;
    [SerializeField] InputField maidaTotal;
    [SerializeField] InputField shewayaTotal;
    [SerializeField] InputField papadTotal;

    [Header("All product Total")]
    [SerializeField] InputField allTotal;

    private TouchScreenKeyboard keyboard;

    private float ravaPrice ;
    private float maidaPrice;
    private float shewayaPrice;
    private float papadPrice ;


    private void Start()
    {
        /*
        ravaField.text = "0";
        maidaField.text = "0";
        shewayaField.text = "0";
        papadField.text = "0";
        */
        ravaPrice = 44;
        maidaPrice = 40;
        shewayaPrice = 15;
        papadPrice = 135;

        ravaAmount.text = "44";
        maidaAmount.text = "40";
        shewayaAmount.text = "15";
        papadAmount.text = "135";
        
    }

    public void Clear()
    {
        ravaPrice = 44;
        maidaPrice = 40;
        shewayaPrice = 15;
        papadPrice = 135;

        ravaAmount.text = "44";
        maidaAmount.text = "40";
        shewayaAmount.text = "15";
        papadAmount.text = "135";

        ravaField.text = "";
        maidaField.text = "";
        shewayaField.text = "";
        papadField.text = "";

        ravaTotal.text = "";
        maidaTotal.text = "";
        shewayaTotal.text = "";
        papadTotal.text = "";

        allTotal.text = "";
    }

   

    public void Total()
    {
/*
        float rava = float.Parse(ravaField.text);
        float maida = float.Parse(maidaField.text);
        float shewaya = float.Parse(shewayaField.text);
        float papad = float.Parse(papadField.text); */

        ravaPrice = float.Parse(ravaAmount.text);
        maidaPrice = float.Parse(maidaAmount.text);
        shewayaPrice = float.Parse(shewayaAmount.text);
        papadPrice = float.Parse(papadAmount.text);

        float rava = ParseField(ravaField);
        float maida = ParseField(maidaField);
        float shewaya = ParseField(shewayaField);
        float papad = ParseField(papadField);


        float rava_Total = rava * ravaPrice;
        float maida_Total = maida * maidaPrice;
        float shewaya_Total = shewaya * shewayaPrice;
        float papad_Total = papad * papadPrice;

        ravaTotal.text = rava_Total.ToString();
        maidaTotal.text = maida_Total.ToString();
        shewayaTotal.text = shewaya_Total.ToString();
        papadTotal.text = papad_Total.ToString();

        

        float all_Total = rava_Total + maida_Total + shewaya_Total + papad_Total;
        allTotal.text = all_Total.ToString();

    }

    private float ParseField(InputField field)
    {
        float value;
        if (float.TryParse(field.text, out value))
        {
            return value;
        }
        else
        {
            field.text = "0";
            return 0;
        }
    }
}
