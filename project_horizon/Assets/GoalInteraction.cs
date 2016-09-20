using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class GoalInteraction : MonoBehaviour {

    [SerializeField] private Material m_NormalMaterial;
    [SerializeField] private Material m_OverMaterial;
    [SerializeField] private VRInteractiveItem m_InteractiveItem;
    [SerializeField] private Renderer m_Renderer;
    private void Awake()
    {
        m_Renderer.material = m_NormalMaterial;
    }


    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
    }

    //Handle the Over event
    private void HandleOver()
    {
        Debug.Log("Show over state");
        m_Renderer.material = m_OverMaterial;
        Destroy(transform.gameObject);
    }

    private void HandleOut()
    {
        Debug.Log("Show out state");
        m_Renderer.material = m_NormalMaterial;
    }

}
