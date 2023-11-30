using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private List<GameObject> checkPoints;
    [SerializeField] private Vector3 vectorPoint;
    [SerializeField] private float dead;
    [SerializeField] private int deathAdded = 1;



    void Update()
    {

        if (player.transform.position.y < -dead)
        {
            player.transform.position = vectorPoint;
            //asdf.currentDeaths += deathAdded;
            //sdf.deaths.text = asdf.currentDeaths.ToString();      couldnt get the text to work
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        vectorPoint = player.transform.position;
    }
}


