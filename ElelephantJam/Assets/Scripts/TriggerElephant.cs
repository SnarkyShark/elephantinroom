using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerElephant : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDeactivate;

    void OnTriggerEnter(Collider other) {
      if(other.CompareTag("Player")) {
        objectToActivate.SetActive(true);
        objectToDeactivate.SetActive(false);
      }
    }
}
