using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttendentNavigator : MonoBehaviour
{

    public GameObject[] attractionsAvaliable;
    public GameObject[] activitiesAvaliable;
    public NavMeshAgent agent;
    public Attendent attendent;

    // Start is called before the first frame update
    void Start()
    {
        setNewDestination();
    }
    
    void setNewDestination()
    {

        if (decideEventTarget(attendent.getAttraToActPref()))
        {
            //Deciding an Activity
            int activity = Random.Range(0,activitiesAvaliable.Length);
            agent.SetDestination(activitiesAvaliable[activity].GetComponent<EventObject>().getNextQueuePosition());
            activitiesAvaliable[activity].GetComponent<EventObject>().attendentsInQueue.Enqueue(this.attendent);
        } 
        else
        {
            //Deciding an Attraction
            int attraction = Random.Range(0,attractionsAvaliable.Length);
            agent.SetDestination(attractionsAvaliable[attraction].GetComponent<EventObject>().getNextQueuePosition());
            attractionsAvaliable[attraction].GetComponent<EventObject>().attendentsInQueue.Enqueue(this.attendent);
        }
    }

    //False = Attraction, True = Activity
    bool decideEventTarget(float AttractionToActivityPref){

        if (AttractionToActivityPref == 1) //Max Activity
        {
            return true;    
        } 
        else if (AttractionToActivityPref == 0) //Max Attraction
        {
            return false;
        }
        else
        {
            float roll = Random.Range(0f,1f);
            if (roll >= AttractionToActivityPref)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
    }

}
