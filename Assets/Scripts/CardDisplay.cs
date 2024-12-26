using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CardDisplay : MonoBehaviour, IPointerClickHandler
{
    public Card cardData;

    // UI要素への参照
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI cardDescriptionText;
    public TextMeshProUGUI cardCostText;

    // ダブルクリックを検出するための変数
    private float lastClickTime = 0f;
    private float doubleClickThreshold = 0.3f; // ダブルクリックと認識する間隔

    void Start()
    {
        if (cardData != null)
        {
            cardNameText.text = cardData.cardName;
            cardDescriptionText.text = cardData.description;
            cardCostText.text = cardData.cost.ToString();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Time.time - lastClickTime < doubleClickThreshold)
        {
            // ダブルクリックと認識
            UseCard();
        }
        lastClickTime = Time.time;
    }

    void UseCard()
    {
        Debug.Log("カード「" + cardData.cardName + "」が使用されました。");
        // BattleManagerにカードを使用する処理を通知
        BattleManager.Instance.PlayerUseCard(cardData);
    }
}
