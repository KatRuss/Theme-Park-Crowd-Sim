using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttendentManager : MonoBehaviour
{

    public Transform spawnZone;
    public int secondDelay;
    public GameObject attendentTemplate;
    public int attendentMax;
    List<Attendent> attendents = new List<Attendent>();
    public GameObject[] Attractions;
    public GameObject[] Activities;


    // Start is called before the first frame update
    void Start()
    {
        createEventsList();
        StartCoroutine("spawnAttendent");
    }


    void createEventsList(){
        Attractions = GameObject.FindGameObjectsWithTag("Attraction");
        Activities = GameObject.FindGameObjectsWithTag("Activity");
    }

    IEnumerator spawnAttendent(){

        while (attendents.Count < attendentMax)
        {
            GameObject attendent = Instantiate(attendentTemplate);
            attendents.Add(attendent.GetComponent<Attendent>());
            attendent.transform.position = spawnZone.position;
            attendent.GetComponent<AttendentNavigator>().attractionsAvaliable = Attractions;
            attendent.GetComponent<AttendentNavigator>().activitiesAvaliable = Activities;
            yield return new WaitForSeconds(secondDelay); 
        }
    }
 
}
