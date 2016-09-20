using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;
using UnityEngine.UI;

public class RecticleBehavior : MonoBehaviour {

    // Use this for initialization
    GameObject GUI_recticle;
    Image recticleImage;
    [SerializeField] private Sprite m_OverImage;
    [SerializeField] private VRInteractiveItem m_InteractiveItem;


    private void Awake()
    {
        GUI_recticle = GameObject.FindGameObjectWithTag("Recticle");
        recticleImage = GUI_recticle.GetComponent<Image>();
    }


    private void OnEnable()
    {
            m_InteractiveItem.OnOver += HandleOver;
    }


    private void OnDisable()
    {
            //m_InteractiveItem.OnOver -= HandleOver;
    }

    //Handle the Over event
    private void HandleOver()
    {
        Debug.Log("Show over state");
        recticleImage.sprite = m_OverImage;
    }

}

