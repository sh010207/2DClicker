
using UnityEngine;

public enum RewardType
{
    Frist,
    Second,
    Third
}
[CreateAssetMenu(fileName = "RewardData", menuName ="Scriptable Object/Reward Data",order = 1)]
public class RewardData : ScriptableObject
{
    public RewardType type;

    public int TargetCount;
    public int rewardGold;
}
