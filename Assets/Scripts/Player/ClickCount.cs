using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickCount : MonoBehaviour
{
    public TextMeshProUGUI clickCount;

    public TextMeshProUGUI currentConut;

    private void Update()
    {
        clickCount.text = $"{GameManager.Instance.Player.count}";
        ClickCountSave();
    }

    public void ClickCountSave()
    {
        PlayerPrefs.SetInt("ClickCount", int.Parse(clickCount.text));
    }

    public void ClickCountLoad()
    {
        if(PlayerPrefs.HasKey("ClickCount"))
        {
            currentConut.text = PlayerPrefs.GetInt("ClickCount").ToString();
        }
    }
}
