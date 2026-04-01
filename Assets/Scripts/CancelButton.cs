using UnityEngine;
using UnityEngine.UI;

public class CancelButton : MonoBehaviour
{
    public DeathManager deathManager;
    public Text buttonText;

    public void OnButtonPressed()
    {
        bool success = deathManager.TryCancelDeathLoad();

        if (success)
            buttonText.text = "Saved!";
        else
            buttonText.text = "Too Late!";
    }
}