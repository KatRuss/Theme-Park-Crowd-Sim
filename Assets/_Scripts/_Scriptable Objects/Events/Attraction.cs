using UnityEngine;

[CreateAssetMenu (fileName = "New Attraction", menuName = "Theme Park/Attraction", order = 0)]
public class Attraction : Event
{
    [Header("Attraction Attributes")]
    public int attendentsPerRide;
    public int lineCapaticy;
    public int rideLength;

    [Header("Express Attributes")]
    public bool usesExpressSystem;
    public int expressMinutes;

    [Header("Deviations")]
    [Range(0, 100)] public int rideLengthDeviation;
    [Range(0, 100)] public int lineCapacityDeviation;
    [Range(0, 100)] public int expressSecondsDeviation;
}
