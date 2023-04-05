using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventObject : MonoBehaviour
{
    public Event eventTemplate;
    
    public Transform queueStart;
    public float queueGapSize;
    public Queue<Attendent> attendentsInQueue = new Queue<Attendent>();
    List<Transform> queuePositions = new List<Transform>();
    Vector3 queueEndPosition;

    void Awake(){
        queueEndPosition = queueStart.position;
        queuePositions.Add(queueStart);
    }

    public Vector3 getNextQueuePosition(){

        Vector3 queuePosition = Vector3.zero;
        //If queue is currently full, add a new queue point
        if (attendentsInQueue.Count >= queuePositions.Count)
        {
            queuePosition = SpawnNewQueuePoint().position;
        }
        else //Get the last position in the queue
        {
            if (queuePositions.Count == 1)
            {
                queuePosition = queuePositions[0].transform.position;
            } else
            {
                queuePosition = queuePositions[attendentsInQueue.Count-1].transform.position;
            }
        }


        return queuePosition;
    }

    public Transform SpawnNewQueuePoint(){
        GameObject newPoint = new GameObject("Queue Position" + queuePositions.Count);
        queuePositions.Add(newPoint.transform);
        newPoint.transform.parent = this.gameObject.transform;
        newPoint.transform.rotation = queueStart.transform.rotation;
        newPoint.transform.localPosition = queueStart.localPosition + new Vector3(0,0,queueGapSize*queuePositions.Count-1);
        return newPoint.transform;
    }
}
