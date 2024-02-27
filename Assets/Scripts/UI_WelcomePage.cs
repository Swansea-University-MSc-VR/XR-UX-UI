using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static UnityEngine.Rendering.DebugUI;

public class UI_WelcomePage : MonoBehaviour
{
    public RectTransform uiElement; // Reference to your UI element
    public UI_OptionsPage uI_OptionsPage;
    
 
    public void MoveMenu()
    {
        // Calculate the normalized Y offset based on screen height
        float normalizedOffset = 1.5f; // Adjust this value based on how much you want the panel to move up (0.2 means 20% of the screen height)
        float offsetY = normalizedOffset * Screen.height;

        // Tween the panel to move up and out of the screen
        float moveDuration = 1f;

        Tween moveOffscreen = uiElement.DOAnchorPosY(offsetY, moveDuration).SetEase(Ease.OutQuad);

        moveOffscreen.OnComplete(() =>
        {
            // Do something when the panel is offscreen
        });


        moveOffscreen.onComplete += NextCanvas;
    }


    // Method to be called at the end of the tween
    void NextCanvas()
    {
        Debug.Log("Tween complete! You can call your method here.");
        uI_OptionsPage.EnableOptionsPage();
        // Call your additional method or perform any other actions here
    }


    //public void BasicMove()
    //{
    //    // Tween the panel to move up and out of the screen
    //    float moveDuration = 1f;
    //    float offsetY = 300f; // Adjust this value based on how much you want the panel to move up

    //    uiElement.DOAnchorPosY(offsetY, moveDuration).SetEase(Ease.OutQuad);
    //}
}
