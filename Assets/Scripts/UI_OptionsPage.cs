using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.UI;

public class UI_OptionsPage : MonoBehaviour
{
    public RectTransform uiElement; // Reference to your UI element
    public Canvas canvas;

    public bool option1;

    public void EnableOptionsPage()
    {
        uiElement.localScale = Vector3.zero;
        canvas.enabled = true;

        uiElement.DOScale(Vector3.one, 1f).SetEase(Ease.OutBounce);

    }

    // Method to be called at the end of the tween
    void Options()
    {
        Debug.Log("Tween complete! You can call your method here.");
        
        // Call your additional method or perform any other actions here
    }

    void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            // Do something when the Toggle is turned on
            Debug.Log("Toggle is ON");
        }
        else
        {
            // Do something when the Toggle is turned off
            Debug.Log("Toggle is OFF");
        }
    }
}
