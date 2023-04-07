using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Name Bank", fileName = "New Name Bank")]
public class NameBank : ScriptableObject
{
    public string[] FirstNames;
    public string[] LastNames;
}
