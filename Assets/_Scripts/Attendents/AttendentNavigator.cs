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

    public bool isInQueue = false;
    public int positionInQueue = -1;
    public bool isInsideEvent = false;

    EventObject currentEvent;

    // Start is called before the first frame update
    void Start()
    {
        setNewDestination();
    }
    
    public void setNewDestination()
    {

        Vector3 newPosition = Vector3.zero;

        if (!isInQueue && !isInsideEvent) //If doing nothing, find something to do.
        {
            if (decideEventType(attendent.getAttraToActPref()))
            {
                //Deciding an Activity
                newPosition = enterIntoQueue(activitiesAvaliable);
                isInQueue = true;
            } 
            else
            {
                //Deciding an Attraction
                newPosition = enterIntoQueue(attractionsAvaliable);
                isInQueue = true;
            }
        } 
        else if (isInQueue) //If in queue and called, update queue position
        {
            if (positionInQueue <= 0) //Get in the event
            {
                isInQueue = false;
                isInsideEvent = true;
                newPosition = currentEvent.getAttractionPosition();
            }
            else
            {
                newPosition = currentEvent.getPositionInQueue(positionInQueue-1);
            }
        } 
        else if (isInsideEvent) // If inside event and called, should leave event
        {


            //isInsideEvent = false;
        } 

        if (newPosition != Vector3.zero)
        {
            agent.SetDestination(newPosition);
        }
    }





    //False = Attraction, True = Activity
    bool decideEventType(float AttractionToActivityPref){

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



    // Vector3 updateQueuePosition()
    // {
        
    //     return ;
    // }

    Vector3 enterIntoQueue(GameObject[] eventList)
    {

        //Find the chosen event
        int eventIndex = Random.Range(0,eventList.Length);
        GameObject chosenEvent = eventList[eventIndex];

        //Check if it is avaliable and running


        //Check if within budget/time left in park 


        //Get into the queue
        currentEvent = chosenEvent.GetComponent<EventObject>();
        currentEvent.attendentsInQueue.Enqueue(this);
        positionInQueue = currentEvent.attendentsInQueue.Count;
        return currentEvent.enterIntoQueue();
    }
}
