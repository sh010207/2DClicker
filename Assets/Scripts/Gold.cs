using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IUpgradeTool
{
    void Set();
    void Add(int idex);
}

public class Gold : MonoBehaviour , IUpgradeTool
{
    private int gold;

    public void Set()
    {
        GoodsManager.Instance.playerGold = gold;
    }

    public void Add(int pay)
    {
        gold += pay;
    }
}
