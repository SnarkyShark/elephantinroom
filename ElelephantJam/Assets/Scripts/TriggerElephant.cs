using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerElephant : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDeactivate;
    public GameObject selfObjectDeactivate;

    void OnTriggerEnter(Collider other) {
      if(other.CompareTag("Player")) {
        objectToActivate.SetActive(true);
        selfObjectDeactivate.SetActive(false);
        objectToDeactivate.SetActive(false);
      }
    }
}
