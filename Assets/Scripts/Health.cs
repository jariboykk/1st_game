using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int maxHP = 100; // 最大HP
    private int currentHP;     // 現在のHP

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        Debug.Log(gameObject.name + "のHP: " + currentHP + "/" + maxHP);
    }

    // ダメージを受けるメソッド
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);
        Debug.Log(gameObject.name + "が" + damage + "ダメージを受けた。現在のHP: " + currentHP + "/" + maxHP);

        if (currentHP <= 0)
        {
            Die();
        }
    }

    // 死亡処理
    private void Die()
    {
        Debug.Log(gameObject.name + "は倒れた。");
        // ここに死亡時の処理を追加（例：オブジェクトの破壊）
        Destroy(gameObject);
    }

    // HPを回復するメソッド（オプション）
    public void Heal(int amount)
    {
        currentHP += amount;
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);
        Debug.Log(gameObject.name + "が" + amount + "HP回復した。現在のHP: " + currentHP + "/" + maxHP);
    }

    // 現在のHPを取得するメソッド（オプション）
    public int GetCurrentHP()
    {
        return currentHP;
    }

    // 最大HPを取得するメソッド（オプション）
    public int GetMaxHP()
    {
        return maxHP;
    }
}
