using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeElapsed = 0f;
    public TMP_Text timerText;
    public bool isCountingUp = true;

    void Update()
    {
        if (isCountingUp)
        {
            timeElapsed += Time.deltaTime;
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeElapsed / 60);
        int seconds = Mathf.FloorToInt(timeElapsed % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }
}