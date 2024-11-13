using TMPro;
using UnityEngine;

public class UIClick : MonoBehaviour
{
    public TextMeshProUGUI clickCountText;
    public TextMeshProUGUI goldText;

    public TextMeshProUGUI clickPowerLvText;
    public TextMeshProUGUI availableGoldText;
    public TextMeshProUGUI goldPowerLvText;

    public UpgradeSystem upgradeSystem;


    private void Update()
    {
        clickCountText.text = $"{GoodsManager.Instance.playerClickCount}";
        goldText.text = $"{GoodsManager.Instance.playerGold}G";

        clickPowerLvText.text = $"ClickPower\nLv{GameManager.Instance.Player.stat.ClickPowerLevel}";
        goldPowerLvText.text = $"GoldPower\nLV{GameManager.Instance.Player.stat.GoldLevel}";
        availableGoldText.text = $"Upgrade\n{upgradeSystem.availableGold}G";
    }
}
