using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventList", menuName = "Theme Park Crowd Sim/EventList", order = 0)]
public class EventList : ScriptableObject {
    public List<Event> events;
}