using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private int gemsCollected;
    [SerializeField] private int gemsAdded;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            gemsCollected += gemsAdded;
            Debug.Log("gems collected: " + gemsCollected);
        }
    }
}

