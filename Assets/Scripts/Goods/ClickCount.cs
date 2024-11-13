using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickCount : MonoBehaviour , IUpgradeTool
{
    private int clickCount;

    public void Add(int click)
    {
        clickCount += click;
    }

    public void Set()
    {
        GoodsManager.Instance.playerClickCount = clickCount;
    }
}
