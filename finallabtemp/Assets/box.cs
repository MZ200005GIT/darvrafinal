using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class box : MonoBehaviour
{
    [SerializeField]
    private GameObject attachpoint;
    private bool attachable;

    private XRGrabInteractable grabInteractable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    public void OnGrab()
    {
        Debug.Log("grab");
    }


    public void OnRelease()
    {
        
        Debug.Log("release");

    }
}
