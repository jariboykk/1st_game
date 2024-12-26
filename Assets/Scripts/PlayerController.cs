using UnityEngine;
using TMPro; // TextMeshProを使用するために追加

public class PlayerController : MonoBehaviour
{
    public string playerName = "Hero";
    public int maxHealth = 100;
    public int currentHealth;

    public TextMeshProUGUI healthText; // UIテキストを参照

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthUI();
        Debug.Log(playerName + " takes " + damage + " damage. Current Health: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(playerName + " has been defeated!");
        // ゲームオーバー処理などをここに追加
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Player Health: " + currentHealth;
        }
    }
}
