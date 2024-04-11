using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public float initialTime; // 18000 is 30 minutes in seconds 

    public GameObject gameOverScreen;

    private float currentTime;
    private bool isCountingDown = true;

    void Start() {
        currentTime = initialTime;
        UpdateText();
        StartCoroutine(Countdown());
        gameOverScreen.SetActive(false);
    }

    IEnumerator Countdown() {
        while (isCountingDown) {
            if (currentTime > 0) {
                currentTime -= Time.deltaTime;
                UpdateText();
            }
            else {
                isCountingDown = false;
                OnTimerEnd(); // triggers the gameover screen
            }

            yield return null; // wait for the next frame
        }
    }

    private void UpdateText() {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        textMeshPro.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // put what we want to happen in here
    private void OnTimerEnd() {
        gameOverScreen.SetActive(true);
        Debug.Log("Timer has reached zero.");
    }
}
