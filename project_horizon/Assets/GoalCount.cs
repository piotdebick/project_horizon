using UnityEngine;
using System.Collections;

public class GoalCount : MonoBehaviour {
    GameObject[] totalGoals;
    int goalReached, i;
	// Use this for initialization
	void Start () {
        totalGoals = GameObject.FindGameObjectsWithTag("Goal");
        goalReached = ;
	}
	
	// Update is called once per frame
	void Update () {

        for(i = 0;i < totalGoals.Length; i++)
        {

        }

	    if(goalReached >= totalGoals.Length){

        }
	}
}
