using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitZone : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
    Destroy(other);
   }
}
