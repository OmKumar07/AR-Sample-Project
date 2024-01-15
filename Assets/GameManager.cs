using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject dragon;
    private List<GameObject> ActiveDragons = new List<GameObject>();
    public void spawn()
    {
        GameObject drag = Instantiate(dragon, transform.right, transform.rotation, transform);
        ActiveDragons.Add(drag);
        if(transform.childCount>1)
        {
            Destroy(ActiveDragons[0]);
            ActiveDragons.RemoveAt(0);
        }
    }
}

