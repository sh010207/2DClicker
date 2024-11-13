using UnityEngine;
using UnityEngine.Pool;

public class Effect : MonoBehaviour
{
    public IObjectPool<Effect> effectPool { get; set; }
    private void Update()
    {
        if(effectPool.CountInactive > EffectManager.instance.defaultCapacity)
        {
            effectPool.Release(this);
        }
    }
}