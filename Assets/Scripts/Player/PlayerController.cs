using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    private Camera cam;
    public float maxDistance = 15f;
    private Vector3 mousePos;
    private Animator animator;

    private void Start()
    {
        cam = Camera.main;
        animator = GetComponentInChildren<Animator>();
    }

    public void OnClik(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            mousePos = Input.mousePosition;
            mousePos = cam.ScreenToWorldPoint(mousePos);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, transform.forward, maxDistance);
            if (hit)
            {
                GameManager.Instance.Player.count++;
            }
        }
    }


}
