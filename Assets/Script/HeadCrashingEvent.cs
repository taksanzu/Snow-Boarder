using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCrashingEvent : MonoBehaviour
{
    private float reloadTime = 1.5f;
    [SerializeField] ParticleSystem headCrashEffect;
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Surface")
       {
            headCrashEffect.transform.position = transform.position;
            headCrashEffect.Play();
            Invoke("ReloadScene", reloadTime); 
       }
   }

   void ReloadScene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
