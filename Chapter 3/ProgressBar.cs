using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgressBar : MonoBehaviour {

    private Image progressbarFilling;
    private Text progressbarText;

    private int progress = 0;

    void Start() {
        progressbarFilling = GetComponent<Image>();
        progressbarText = GetComponentInChildren<Text>();
        updateProgressBar();
    }

    public void increaseProgressOf(int value) {
        progress += value;
        if (progress >= 100) {
            progress = 100;
            //Triger an action when the Progress Bar is complete
        }
        updateProgressBar();
    }

    private void updateProgressBar() {
        progressbarFilling.fillAmount = progress / 100f;
        progressbarText.text = progress + "%";
    }
}
