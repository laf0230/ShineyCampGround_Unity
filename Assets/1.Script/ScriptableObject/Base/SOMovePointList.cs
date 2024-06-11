using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WayPoint List", menuName = "NPC Actions/WayPoint")]
public class SOMovePointList : ScriptableObject
{
    public List<GameObject> WayPoints = new List<GameObject>();
}
