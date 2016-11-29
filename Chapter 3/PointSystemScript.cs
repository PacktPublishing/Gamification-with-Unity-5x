using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class PointSystemScript : MonoBehaviour {

    private Text uiText;

    private long points = 0;

    public long getPoints() {
        return points;
    }

    void Start() {
        uiText = this.GetComponent<Text>();
        updatePointsSystem();
    }

    public void addPoints(int ammount) {
        this.points += ammount;
        updatePointsSystem();
    }

    private void updatePointsSystem() {
        uiText.text = "<color=blue>Score</color>: " + points;
    }
}

