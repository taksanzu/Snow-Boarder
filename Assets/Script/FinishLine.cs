using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishLineParticles;
    AudioSource audioSource;
    PlayerController playerController;
    bool soundPlayed = false;
    void Start(){
        audioSource = GetComponent<AudioSource>();
        playerController = FindObjectOfType<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !soundPlayed)
        {
            finishLineParticles.Play();
            audioSource.Play();
            playerController.DisableMovement();
            soundPlayed = true;
            Invoke("ReLoadScene", 1f);
        }
    }

    void ReLoadScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
