using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    // 현재 플레이어 레벨, 클릭파워, 골드 파워
    private int currentPlayerLevel;
    private int currentPlayerClickPower;
    private int currentPlayerGoldPower;

    // 버튼 클릭 시 파워들이 증가 (1씩)
    private int clickPowerIncrease;
    private int goldPowerIncrease;

    // 버튼 클릭 시 레벨 증가
    private int clickPowerLevel = 1;
    private int goldPowerLevel = 1;

    // 레벨이 증가하면 쓰여지는 골드가 증가
    private int goldUp = 100;
    public int availableGold = 100;

    private void Start()
    {
        SetClickPowerLevel();

        currentPlayerClickPower = 1;
        currentPlayerGoldPower = 2;

        ClickStatSet();
        ClickGoldSet();
    }

    public void SetClickPowerLevel()
    {
        GameManager.Instance.Player.stat.ClickPowerLevel = clickPowerLevel;
    }

    public void ClickStatSet()
    {
        GameManager.Instance.Player.stat.ClickPower = currentPlayerClickPower;
    }

    public  void ClickGoldSet()
    {
        GameManager.Instance.Player.stat.Gold = currentPlayerGoldPower;   
    }

    public void OnUpgradeButton()
    {
        if(GoodsManager.Instance.playerGold <= availableGold)
        {
            Debug.Log("돈이 없습니다!");
        }
        else
        {
            GoodsManager.Instance.playerGold -= availableGold;
            availableGold += goldUp * clickPowerLevel;
            clickPowerLevel++;
            SetClickPowerLevel();

            currentPlayerGoldPower += 1;
            ClickGoldSet();

            clickPowerIncrease++;
            currentPlayerClickPower += clickPowerIncrease;
            ClickStatSet();
        }
    }
}