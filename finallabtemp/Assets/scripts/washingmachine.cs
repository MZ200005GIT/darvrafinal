using UnityEngine;

public class washingmachine : MonoBehaviour
{
    [SerializeField]
    private AudioSource audio;
    [SerializeField]
    private AudioClip clip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnPress()
    {
        audio.PlayOneShot(clip);
    }
}
