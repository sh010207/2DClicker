using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.DeviceSimulation;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public Action click;
    private IEnumerator coroutine;
    private float coolTime = 10f;

    private void Awake()
    {
        click += OnMouseDown;
    }
    private void Start()
    {
        StartAutoClick(); 
    }

    private void OnMouseDown()
    {

        GoodsManager.Instance.clickCount
            .Add(GameManager.Instance.Player.stat.ClickPower);

        GoodsManager.Instance.clickCount.Set();

        //GoodsManager.Instance.rewardClickCount++;

        GoodsManager.Instance.gold
            .Add(GameManager.Instance.Player.stat.Gold);
        GoodsManager.Instance.gold.Set();
    }

    IEnumerator AutoClick()
    {
        while (coolTime > 0)
        {
            Debug.Log($"coolTime:{coolTime}");
            click();
            coolTime--;
            yield return new WaitForSeconds(1f);
        }

        Invoke(nameof(StartAutoClick),10f);
    }

    private void StartAutoClick()
    {
        StartCoroutine("AutoClick", 10f);
    }
}
