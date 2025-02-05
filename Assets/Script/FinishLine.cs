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
    void Start(){
        audioSource = GetComponent<AudioSource>();
        playerController = FindObjectOfType<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishLineParticles.Play();
            audioSource.Play();
            playerController.DisableMovement();
            Invoke("ReLoadScene", 1f);
        }
    }

    void ReLoadScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
