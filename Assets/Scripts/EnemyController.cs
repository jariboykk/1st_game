using UnityEngine;
using TMPro; // TextMeshProを使用するために追加

public class EnemyController : MonoBehaviour
{
    public string enemyName = "Goblin";
    public int maxHealth = 50;
    public int currentHealth;
    public int attackDamage = 10;

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
        Debug.Log(enemyName + " takes " + damage + " damage. Current Health: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(enemyName + " has been defeated!");
        // 敵の削除や報酬の付与などをここに追加
        Destroy(gameObject);
    }

    public void Attack(PlayerController player)
    {
        player.TakeDamage(attackDamage);
        Debug.Log(enemyName + " attacks " + player.playerName + " for " + attackDamage + " damage.");
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Enemy Health: " + currentHealth;
        }
    }
}
