using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UI_Credits : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public Canvas canvas;
    public UI_OptionsPage optionsPage;
    public Button backButton;

    private void Start()
    {
        canvas.enabled = false;
        canvasGroup.alpha = 0f;
        backButton.onClick.AddListener(DisableCreditsPage);
    }

    public void EnableCreditsPage()
    {
        canvas.enabled = true;
        canvasGroup.DOFade(1f, 2f).SetEase(Ease.InOutQuad);
    }     

    public void DisableCreditsPage() 
    {        
        canvasGroup.alpha = 0f;
        canvas.enabled = false;
        optionsPage.EnableOptionsPage();
    }

    private void OnDisable()
    {
        backButton.onClick.RemoveListener(DisableCreditsPage);
    }
}
