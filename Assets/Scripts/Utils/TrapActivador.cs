using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActivador : MonoBehaviour
{
    public GameObject trap1;
    public GameObject trap2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trap1.SetActive(true);
            trap2.SetActive(true);
        }
    }
}
