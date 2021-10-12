using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{

    public GameObject Sound = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            
            Destroy(gameObject);
        }
    }

}
