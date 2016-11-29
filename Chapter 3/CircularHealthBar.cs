using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CircularHealthBar : MonoBehaviour {

    private Image healthbarFilling;

    public int maxHealth = 100;

    private int health;

    void Start() {
        healthbarFilling = GetComponent<Image>();
        health = maxHealth;
    }

    public void addHealth(int value) {
        health += value;
        if (health > maxHealth)
            health = maxHealth;
        updateHealth();
    }

    //Returns true if the user dies
    public bool removeHealth(int value) {
        health -= value;
        if (health <= 0) {
            health = 0;
            updateHealth();
            return true;
        }
        updateHealth();
        return false;
    }

    private void updateHealth() {
        healthbarFilling.fillAmount = health / maxHealth;
    }
}
