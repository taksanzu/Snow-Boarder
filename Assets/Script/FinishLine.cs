using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishLineParticles;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishLineParticles.Play();
            Invoke("ReLoadScene", 1f);
        }
    }

    void ReLoadScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
