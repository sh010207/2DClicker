using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GoodsManager : MonoBehaviour
{
    public Gold gold;
    public ClickCount clickCount;

    private static GoodsManager instance;

    public List<RewardData> rewards = new List<RewardData>();

    // 현재 플레이어의 ClikCount, Gold
    public int playerClickCount;
    public int playerGold;

    public static GoodsManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GoodsManager();
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != null)
                Destroy(gameObject);
        }
    }
    private void Update()
    {
        ClickCountSave();
        ClearGold();
    }

    public void ClickCountSave()
    {
        PlayerPrefs.SetInt("ClickCount", playerClickCount);
    }

    public void ClearGold()
    {
        for (int i = 0; i < rewards.Count; i++)
        {
            if (rewards[i].TargetCount <= playerClickCount)
            {
                gold.Add(1000);
                gold.Set();
                rewards.Remove(rewards[i]);
            }
        }    
    }
}
