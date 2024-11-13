using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Pool;

public class EffectManager : MonoBehaviour
{
    public static EffectManager instance;

    public int defaultCapacity = 10;
    public int maxPoolSize = 15;

    public GameObject effectPrefab;

    public IObjectPool<GameObject> Pool {  get; private set; }

    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            Destroy(this.gameObject);

        Init();
    }

    private void Init()
    {
        Pool = new ObjectPool<GameObject>(
            CreateEffect,
            OnGet,
            OnRelease,
            OnDestory,
            true,
            defaultCapacity,
            maxPoolSize);

        for(int i = 0; i < defaultCapacity; i++)
        {
            Effect effect = CreateEffect().GetComponent<Effect>();
            effect.effectPool   .Release(effect);
        }
    }

    private GameObject CreateEffect()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        GameObject effect = Instantiate(effectPrefab, mousePos, Quaternion.identity);
        return effect;
    }

    private void OnGet(GameObject effect)
    {
        effect.gameObject.SetActive(true);
    }

    private void OnRelease(GameObject effect)
    {
        effect.gameObject.SetActive(false);
    }

    private void OnDestory(GameObject effect)
    {
        Destroy(effect.gameObject);
    }

}
