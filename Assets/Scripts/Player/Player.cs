using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public PlayerStat stat;
    private void Start()
    {
        GameManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        stat = GetComponent<PlayerStat>();
    }
}
