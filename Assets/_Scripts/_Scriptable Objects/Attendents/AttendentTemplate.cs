using UnityEngine;

[CreateAssetMenu(fileName = "New Attendent Template", menuName = "Theme Park/Attendent Template", order = 0)]
public class AttendentTemplate : ScriptableObject
{

    [Header("Template Attributes")]
    public string TemplateName;
    public NameBank namebank;

    [Header("Activity Preferencce Attributes")]
    [Range(0,1)] public float AttractionToActivityPref;

    [Header("Balk Time Attributes")]
    public int bulkMinutesMax;
    public int bulkMinutesGeneral;

    [Header("Express Ticket Attributes")]
    [Range(0, 1)] public float ExpressTicketWillingness;

    [Header("Budget Attributes")]
    public int budget;

    [Header("Time Attributes")]
    public int desiredMinutesSpent;

    [Header("Deviators")]
    [Range(0, 1)] public float AttractionToActivityDeviator;
    [Range(0, 1)] public float bulkMinutesMaxDeviator;
    [Range(0, 1)] public float bulkMinutesGeneralDeviator;
    [Range(0, 1)] public float budgetDeviator;
    [Range(0, 1)] public float desiredTimeSpentDeviator;
    [Range(0, 1)] public float expressTicketWillingDeviator;

}
