using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class GoalBehavior : MonoBehaviour {


    GameObject[] totalGoals;
    GameObject player;
    [SerializeField] private Material m_NormalMaterial;
    [SerializeField] private Material m_OverMaterial;
    [SerializeField] private VRInteractiveItem m_InteractiveItem;
    [SerializeField] private Renderer m_Renderer;
    int i;


    private void Awake()
    {
    }


    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
    }

    //Handle the Over event
    private void HandleOver()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        totalGoals = GameObject.FindGameObjectsWithTag("Goal");
        Debug.Log("Show fucking state");
        player.GetComponent<GoalCount>().goalReached = 0;
        for(i = 0; i < totalGoals.Length; i++)
        {
            if (totalGoals[i].gameObject != null)
            {
                totalGoals[i].gameObject.GetComponent<MeshRenderer>().material = m_OverMaterial;
                totalGoals[i].GetComponent<GoalInteraction>().Reset();
            }
        }
    }
}
