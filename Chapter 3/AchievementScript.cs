using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AchievementScript : MonoBehaviour {

    private Sprite lockedSprite;
    public Sprite unlockedSprite;

    private Image uiImage;

	// Use this for initialization
	void Start () {
        uiImage = GetComponent<Image>();
        lockedSprite = uiImage.sprite;
	}
	
	public void unlockAchievement() {
        uiImage.sprite = unlockedSprite;
    }

    public void lockAchievement() {
        uiImage.sprite = lockedSprite;
    }
}
