using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public Health targetHealth; // ダメージを与える対象のHealthスクリプト
    public int damageAmount = 25; // 与えるダメージ量

    // Update is called once per frame
    void Update()
    {
        // スペースキーが押されたらダメージを与える
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (targetHealth != null)
            {
                targetHealth.TakeDamage(damageAmount);
            }
            else
            {
                Debug.LogWarning("ターゲットのHealthが設定されていません。");
            }
        }
    }
}
