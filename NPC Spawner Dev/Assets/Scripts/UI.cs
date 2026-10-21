using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public TextMeshProUGUI beggarText;
    public TextMeshProUGUI farmerText;
    public TextMeshProUGUI shopownerText;
    public TextMeshProUGUI warriorText;
    public TextMeshProUGUI wizardText;
    public TextMeshProUGUI RonText;
    
    public void Start()
    {
        HideUI();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowUI();
            UpdateUI();
        }
    }

    public void ShowUI()
    {
        canvasGroup.alpha = 1;          
        canvasGroup.blocksRaycasts = true; 
        canvasGroup.interactable = true;
    }

    public void HideUI()
    {
        canvasGroup.alpha = 0;           
        canvasGroup.blocksRaycasts = false; 
        canvasGroup.interactable = false;
    }

    public void UpdateUI()
    {
        beggarText.text = "Beggar:\nDo you have some change to spare?";
        farmerText.text = "Farmer:\nYou reap what you sow!";
        shopownerText.text = "Shopowner\nDo you wish to purchase something?";
        warriorText.text = "Warrior:\nI'll smash it with a hammer!!";
        wizardText.text = "Wizzard:\nI cast random bullcrap. GO!!!";
        RonText.text = "ron:\nI am so tired.";
    }
}
