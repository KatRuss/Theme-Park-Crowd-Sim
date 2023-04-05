using UnityEngine;

[CreateAssetMenu(fileName = "New Activity", menuName = "Theme Park/Activity", order = 0)]
public class Activity : Event
{
    [Header("Activity Attributes")]
    [Range(0, 100)] public int priceDeviation;
}
