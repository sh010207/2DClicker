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
        GoodsManager.Instance.clickCount.Add(1);
        GoodsManager.Instance.clickCount.Set();
        GoodsManager.Instance.bonusCount++;
        GoodsManager.Instance.gold.Add(2);
        GoodsManager.Instance.gold.Set();
    }

    IEnumerator AutoClick(float coolTime)
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
