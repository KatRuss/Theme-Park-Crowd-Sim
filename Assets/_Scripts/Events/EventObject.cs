using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventObject : MonoBehaviour
{   
    [SerializeField] Transform exitPoint;
    [SerializeField] Transform queueStart;
    [SerializeField] float queueGapSize;
    public Queue<AttendentNavigator> attendentsInQueue = new Queue<AttendentNavigator>();
    List<Transform> queuePositions = new List<Transform>();
    Vector3 queueEndPosition;

    void Awake(){
        queueEndPosition = queueStart.position;
        queuePositions.Add(queueStart);
    }

    public Vector3 enterIntoQueue()
    {
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

    public Vector3 getPositionInQueue(int index)
    {
        return queuePositions[index].position;
    }

    public Vector3 getAttractionPosition(){
        return transform.position;
    }

    public Vector3 getExitPoint(){
        return exitPoint.position;
    }

    Transform SpawnNewQueuePoint(){
        GameObject newPoint = new GameObject("Queue Position" + queuePositions.Count);
        queuePositions.Add(newPoint.transform);
        newPoint.transform.parent = this.gameObject.transform;
        newPoint.transform.rotation = queueStart.transform.rotation;
        newPoint.transform.localPosition = queueStart.localPosition + new Vector3(0,0,queueGapSize*queuePositions.Count-1);
        return newPoint.transform;
    }
}
