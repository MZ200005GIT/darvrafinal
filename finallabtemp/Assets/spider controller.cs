using UnityEngine;

public class spidercontroller : MonoBehaviour
{
    //private new Collider collider;
    [SerializeField]
    private AudioSource audio;

    [SerializeField]
    private Animation anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        audio.Play();
        anim.Play();
    }
}
