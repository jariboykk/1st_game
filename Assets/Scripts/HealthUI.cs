using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public Health playerHealth; // プレイヤーのHealthスクリプト
    public Health enemyHealth;  // 敵のHealthスクリプト

    public TextMeshProUGUI playerHPText; // プレイヤーのHPを表示するText
    public TextMeshProUGUI enemyHPText;  // 敵のHPを表示するText

    // Update is called once per frame
    void Update()
    {
        if (playerHealth != null && playerHPText != null)
        {
            playerHPText.text = "Player HP: " + playerHealth.GetCurrentHP() + "/" + playerHealth.GetMaxHP();
        }

        if (enemyHealth != null && enemyHPText != null)
        {
            enemyHPText.text = "Enemy HP: " + enemyHealth.GetCurrentHP() + "/" + enemyHealth.GetMaxHP();
        }
    }
}
