using System;
using UnityEngine;
using UnityEngine.Pool;

public class EffectManager : MonoBehaviour
{
    public GameObject effect;
    private float spawnTime;
    public float defaultTime = 0.05f;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && spawnTime >= defaultTime)
        {
            EffectCreat();
            spawnTime = 0;
        }
        spawnTime += Time.deltaTime;
    }

    void EffectCreat()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Instantiate(effect,mousePos,Quaternion.identity);
    }
}
