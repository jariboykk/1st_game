using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab; // CardPanelのPrefabを参照
    public Transform handTransform; // カードを配置する親オブジェクト（手札）

    void Start()
    {
        // プレイヤー用攻撃カードの作成
        Card attackCard = new Card
        {
            cardName = "Attack",
            description = "Deal 10 damage to enemy.",
            cost = 1,
            damage = 10
        };

        // カードのインスタンスを生成
        GameObject cardInstance = Instantiate(cardPrefab, handTransform);
        CardDisplay cardDisplay = cardInstance.GetComponent<CardDisplay>();
        cardDisplay.cardData = attackCard;

        // CardDisplayのUIを更新
        cardDisplay.cardNameText.text = attackCard.cardName;
        cardDisplay.cardDescriptionText.text = attackCard.description;
        cardDisplay.cardCostText.text = attackCard.cost.ToString();
    }
}
