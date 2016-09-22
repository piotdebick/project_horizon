using UnityEngine;
using System.Collections;

public class GoalCount : MonoBehaviour {
    GameObject[] totalGoals;
    GameObject MazeSpawner;
    bool[] counted;
    public int goalReached, goalLeft;
    int i;
    bool hasBeenReached;
	// Use this for initialization
	void Start ()
    {
        MazeSpawner = GameObject.FindGameObjectWithTag("MazeSpawner");
        totalGoals = GameObject.FindGameObjectsWithTag("Goal");
        if (totalGoals[i] != null)
        {
            goalReached = 0;
            goalLeft = totalGoals.Length;
        }
	}

    // Update is called once per frame
    void Update()
    {

        for (i = 0; i < goalLeft; i++)
        {
            if (totalGoals[i] != null)
            {
                hasBeenReached = totalGoals[i].gameObject.GetComponent<GoalInteraction>().reached;
                if (hasBeenReached == true)
                {
                    goalReached++;
                    totalGoals[i].gameObject.GetComponent<GoalInteraction>().reached = false;
                }
            }


            if (goalReached >= totalGoals.Length)
            {
                for (i = 0; i < totalGoals.Length; i++)
                    Destroy(totalGoals[i]);
                Destroy(MazeSpawner);
                GameObject newMazeSpawner = Instantiate(Resources.Load("MazeSpawner")) as GameObject;
                MazeSpawner = newMazeSpawner;
                goalReached = 0;
            }
            totalGoals = GameObject.FindGameObjectsWithTag("Goal");
            goalLeft = totalGoals.Length;
        }
    }

    void Reset()
    {
        for (i = 0; i < goalLeft; i++)
        {
            goalReached = 0;
        }
    }
}
