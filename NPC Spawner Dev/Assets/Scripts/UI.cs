using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI beggarText;
    public TextMeshProUGUI farmerText;
    public TextMeshProUGUI shopownerText;
    public TextMeshProUGUI warriorText;
    public TextMeshProUGUI wizardText;
    public TextMeshProUGUI RonText;
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateUI();
        }
    }
    public void UpdateUI()
    {
        beggarText.text = "Do you have some change to spare?";
        farmerText.text = "You reap what you sow!";
        shopownerText.text = "Do you wish to purchase something?";
        warriorText.text = "I'll smash it with a hammer!!";
        wizardText.text = "I cast random bullcrap. GO!!!";
        RonText.text = "I am so tired.";
    }
}
