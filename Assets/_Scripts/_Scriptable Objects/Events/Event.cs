using UnityEngine;

public class Event : ScriptableObject
{
    [Header("Base Attributes")]
    new public string name;
    public int maxCapacity;
    public int price;
    public int popularityMod;
}
