using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;

    private float elapsedTime;
    
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime; // count elapsed time
        int minutes = Mathf.FloorToInt(elapsedTime / 60); // minutes function
        int seconds = Mathf.FloorToInt(elapsedTime % 60); // seconds function
        
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // timer formatting
    }
}
