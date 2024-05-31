using UnityEngine;
using UnityEngine.UI;

public class MobileKeyboardHandler : MonoBehaviour
{
    public InputField inputField; // Reference to the Input Field
    private TouchScreenKeyboard keyboard;

    void Start()
    {
        if (inputField == null)
        {
            inputField = GetComponent<InputField>();
        }
    }

    void Update()
    {
        // Check if the input field is focused and the keyboard is not already open
        if (inputField.isFocused && keyboard == null)
        {
            // Open the on-screen keyboard
            keyboard = TouchScreenKeyboard.Open(inputField.text, TouchScreenKeyboardType.Default);
        }

        // If the keyboard is active, update the input field text
        if (keyboard != null && keyboard.active)
        {
            inputField.text = keyboard.text;

            // Check if the keyboard is done and dismiss it
            if (keyboard.status == TouchScreenKeyboard.Status.Done)
            {
                keyboard = null;
                inputField.DeactivateInputField();
            }
        }
    }
}

