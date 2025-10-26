using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    //Non ci serve Start, quindi possiamo toglierlo

    [SerializeField] GameObject[] waypoints;
    int indiceWaypointCorrente = 0;

    [SerializeField] float speed = 1f;
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[indiceWaypointCorrente].transform.position) < .1f)  //Verifico la distanza tra i waypoint, se si toccano passo al successivo
        {
            indiceWaypointCorrente++;  //Mi muovo al waypoint successivo
            if (indiceWaypointCorrente >= waypoints.Length) // Se stiamo all'ultimo waypoint, dobbiamo ritornare al primo
            {
                indiceWaypointCorrente = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[indiceWaypointCorrente].transform.position, speed*Time.deltaTime);   //si riferisce al transform del pavimento a cui è collegato lo script
        // Time.deltaTime è l'intervallo in secondi da l'ultimo frame a quello corrente.
    }
}
