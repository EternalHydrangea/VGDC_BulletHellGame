using UnityEngine;
using UnityEngine.UI; // Required for UI Text
using UnityEngine.SceneManagement; // Required for scene management
using System.Collections; // Required for TimeSpan (optional, for advanced formatting)
using TMPro;
using System.Timers; // If using TextMeshPro instead of standard UI Text
using System.Collections.Generic;


public class countdown : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI timerText; // Reference to the UI Text component
    public float countdownTime = 60f; // Total countdown time in seconds

    void Update()
    {
        countdownTime -= Time.deltaTime; // Decrease the countdown time
        timerText.text = countdownTime.ToString(); // Update the UI Text with the remaining time formatted to 2 decimal places
    
    if (countdownTime <= 0)
        {
            countdownTime = 0;
            SceneManager.LoadSceneAsync("Ending");
        }
    }

    
}