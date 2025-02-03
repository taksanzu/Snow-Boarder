using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCrashingEvent : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Surface")
       {
           Debug.Log("Player has crashed his head!");
       }
   }
}
