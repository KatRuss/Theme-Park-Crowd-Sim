using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractionManager : MonoBehaviour
{

    EventObject EO;
    public Attraction attractionTemplate;

    private void Start() {
        EO = GetComponent<EventObject>();
        StartCoroutine("eventUpdate");
    }

    IEnumerator eventUpdate(){
        while (true)
        {
            Debug.Log("update");
            foreach (var attendent in EO.attendentsInQueue) //Get people to move up in the queue
            {
                attendent.positionInQueue -= attractionTemplate.attendentsPerRide;
                attendent.setNewDestination();
            }

            yield return new WaitForSeconds(attractionTemplate.rideLength);

            //People in ride leave the ride
        }
    }
}
