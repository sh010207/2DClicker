using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ClickCount countUI;
    public PlayerController controller;
    public int count;

    private void Start()
    {
        GameManager.Instance.Player = this;
        controller = gameObject.GetComponent<PlayerController>();
        countUI = GetComponent<ClickCount>();
    }
}
