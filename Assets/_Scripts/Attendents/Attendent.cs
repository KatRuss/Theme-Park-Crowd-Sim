using System.Collections.Generic;
using UnityEngine;

public class Attendent : MonoBehaviour
{
    public AttendentTemplate template;

    // ++Attendent Calculated Stats++
    List<string> AttendentName = new List<string>();
    
    float AttractionToActivityPref;
    float ExpressTicketWillingness;

    int bulkMinutesGeneral;
    int bulkMinutesMax;
    int budget;

    int desiredMinutesSpent;

    private void Awake() {
        AttendentBuilder builder = new AttendentBuilder();
        builder.createAttendent(this,template);
    }
    


    //Setters
    public void addToName(string name){AttendentName.Add(name);}
    public void setAttraToActPref(float value){if (value >= 0 && value <=1){AttractionToActivityPref = value;} else {AttractionToActivityPref = 0.5f;}}
    public void setBulkGeneral(int value){if (value >= 1 && value <= bulkMinutesMax){bulkMinutesGeneral = value;} else {bulkMinutesGeneral = 60;}}
    public void setBulkMax(int value){if (value >= bulkMinutesGeneral && value <= 5000){bulkMinutesMax = value;} else {bulkMinutesMax = 240;}}
    public void setBudget(int value){if (value >= 0 && value <= 5000){budget = value;} else {budget = 500;}}
    public void setDesiredMinutesSpent(int value){if (value >= 0 && value <= 5000){desiredMinutesSpent = value;} else {desiredMinutesSpent = 500;}}
    public void setExpressTicketWillingness(float value){if (value >= 0 && value <= 1){ExpressTicketWillingness = value;} else {ExpressTicketWillingness = 0.5f;}}

    //Getters
    public float getAttraToActPref(){return AttractionToActivityPref;}

    //Modifiers

}

public class AttendentBuilder
{
    public void createAttendent(Attendent attendent, AttendentTemplate template){
        
        //TODO: Getting a name from the name bank
        //Generating Stats
        attendent.addToName("Bill");
        attendent.setAttraToActPref(createDeviatedStat(template.AttractionToActivityPref,template.AttractionToActivityDeviator));
        attendent.setBulkMax(createDeviatedStatInt(template.bulkMinutesMax,template.bulkMinutesMaxDeviator));
        attendent.setBulkGeneral(createDeviatedStatInt(template.bulkMinutesGeneral,template.bulkMinutesGeneralDeviator));
        attendent.setBudget(createDeviatedStatInt(template.budget,template.budgetDeviator));
        attendent.setDesiredMinutesSpent(createDeviatedStatInt(template.desiredMinutesSpent,template.desiredTimeSpentDeviator));
        attendent.setExpressTicketWillingness(createDeviatedStat(template.ExpressTicketWillingness,template.expressTicketWillingDeviator));


        //Generate Model


    }

    public float createDeviatedStat(float value, float deviator){
        float result = 0;
        result = value + (value * Random.Range(-deviator,deviator+1));
        return result;
    }
    public int createDeviatedStatInt(float value, float deviator){
        float result = 0;
        result = value + (value * Random.Range(-deviator,deviator+1));
        return (int)result;
    }
}
