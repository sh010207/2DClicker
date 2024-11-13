﻿using TMPro;
using UnityEngine;

public class UIClick : MonoBehaviour
{
    public TextMeshProUGUI clickCountText;

    public TextMeshProUGUI goldText;

    private void Update()
    {
        clickCountText.text = $"{GoodsManager.Instance.clickCount}";
        goldText.text = $"{GoodsManager.Instance.playerGold}G";
    }
}