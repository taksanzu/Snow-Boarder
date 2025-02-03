using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCrashingEvent : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Surface")
       {
           SceneManager.LoadScene(0);
       }
   }
}
