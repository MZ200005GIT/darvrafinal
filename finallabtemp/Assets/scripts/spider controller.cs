using System.Collections;
using UnityEngine;

public class spidercontroller : MonoBehaviour
{
    //private new Collider collider;
    [SerializeField]
    private AudioSource audio;
    [SerializeField]
    private AudioClip clip;

    [SerializeField]
    private Animation anim;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        audio.PlayOneShot(clip);
        anim.Play();
        StartCoroutine(Wait());
        
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(11f);
        Destroy(gameObject);
    }
}
