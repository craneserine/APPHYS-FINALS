using UnityEngine;

public class Bomb : MonoBehaviour
{

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Collider>().enabled = false;
            GameManager.Instance.Explode();
            audioManager.PlaySFX(audioManager.bombSFX);
        }
    }

}
