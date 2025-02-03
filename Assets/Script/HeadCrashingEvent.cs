using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCrashingEvent : MonoBehaviour
{
    private float reloadTime = 1.5f;
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Surface")
       {
            Invoke("ReloadScene", reloadTime); 
       }
   }

   void ReloadScene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
