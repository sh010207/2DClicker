﻿using UnityEngine;

public class GoodsManager : MonoBehaviour
{
    public Gold gold;
    public ClickCount clickCount;
    public int playerGold;
    private static GoodsManager instance;
    public int playerClickCount;
    public int bonusCount;
    public int targetBonusCount;

    public static GoodsManager Instance
    {
        get
        {
            if(instance == null)
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
        ClickToGold();
    }

    public void ClickCountSave()
    {
        PlayerPrefs.SetInt("ClickCount", playerClickCount);
    }

    public void ClickCountLoad()
    {
        if (PlayerPrefs.HasKey("ClickCount"))
        {
            playerClickCount = PlayerPrefs.GetInt("ClickCount");
        }
    }

    public void ClickToGold()
    {
        if(bonusCount == targetBonusCount)
        {
            gold.Add(1000);
            gold.Set(); 
            bonusCount = 0;
        }
    }
    
}
