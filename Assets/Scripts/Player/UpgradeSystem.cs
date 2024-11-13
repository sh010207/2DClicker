using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    private int currentPlayerLevel = 0;
    private int currentPlayerClick = 1;
    private int currentPlayerGold = 2;

    private void Start()
    {
        ClickStatSet();
        ClickGoldSet();
    }

    public void ClickStatSet()
    {
        GameManager.Instance.Player.stat.Click = currentPlayerClick;
    }

    public  void ClickGoldSet()
    {
        GameManager.Instance.Player.stat.Gold = currentPlayerGold;   
    }

    public void OnUpgradeButton()
    {
        currentPlayerClick += 1;
        ClickStatSet();
    }
}