using UnityEngine;
using System.Collections;

public class LivesCounterScript : MonoBehaviour {

    public GameObject[] hearts;
    private int lives;

    void Start() {
        lives = hearts.Length;
    }

    public void addLife() {
        if (lives < hearts.Length) {
            lives++;
            updateLivesCounter();
        }
    }

    public bool loseLife() {
        lives--;
        if (lives > 0) {
            updateLivesCounter();
            return false;
        }
        lives = 0;
        updateLivesCounter();
        return true;
    }

    private void updateLivesCounter() {
        for (int i = 0; i < hearts.Length; i++) {
            if (i < lives) {
                hearts[i].SetActive(true);
            }
            else {
                hearts[i].SetActive(false);
            }
        }
    }
}