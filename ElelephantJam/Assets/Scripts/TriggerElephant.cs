using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerElephant : MonoBehaviour
{
    public GameObject objectToActivate;


    void OnTriggerEnter(Collider other) {
      if(other.CompareTag("Player")) {
        objectToActivate.SetActive(true);
      }
    }
}
