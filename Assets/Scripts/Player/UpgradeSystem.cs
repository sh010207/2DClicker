using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    // ���� �÷��̾� ����, Ŭ���Ŀ�, ��� �Ŀ�
    private int currentPlayerLevel;
    private int currentPlayerClickPower;
    private int currentPlayerGoldPower;

    // ��ư Ŭ�� �� �Ŀ����� ���� (1��)
    private int clickPowerIncrease;
    private int goldPowerIncrease;

    // ��ư Ŭ�� �� ���� ����
    private int clickPowerLevel = 1;
    private int goldPowerLevel = 1;

    // ������ �����ϸ� �������� ��尡 ����
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
            Debug.Log("���� �����ϴ�!");
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