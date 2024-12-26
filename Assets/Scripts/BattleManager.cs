using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager Instance;

    public PlayerController player;
    public EnemyController enemy;

    void Awake()
    {
        // シングルトンパターンの実装
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // プレイヤーと敵が正しくアタッチされているか確認
        if (player == null || enemy == null)
        {
            Debug.LogError("Player or Enemy is not assigned in the BattleManager.");
        }
    }

    void Update()
    {
        // 既存の入力処理は不要（カード使用に移行）
    }

    public void PlayerUseCard(Card card)
    {
        if (card.damage > 0)
        {
            enemy.TakeDamage(card.damage);
            Debug.Log(player.playerName + " uses " + card.cardName + " dealing " + card.damage + " damage to " + enemy.enemyName + ".");
        }
        // 他のカード効果をここに追加
    }
}
