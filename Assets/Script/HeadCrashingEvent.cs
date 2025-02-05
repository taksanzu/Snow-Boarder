using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCrashingEvent : MonoBehaviour
{
    private float reloadTime = 1.5f;
    [SerializeField] ParticleSystem headCrashEffect;
    AudioSource audioSource;
    bool soundPlayed = false;

    PlayerController playerController;
    void Start(){
        audioSource = GetComponent<AudioSource>();
        playerController = FindObjectOfType<PlayerController>();
    }
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Surface" && !soundPlayed)
       {
            headCrashEffect.Play();
            audioSource.Play();
            playerController.DisableMovement();
            soundPlayed = true;
            Invoke("ReloadScene", reloadTime); 
       }
   }

   void ReloadScene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
