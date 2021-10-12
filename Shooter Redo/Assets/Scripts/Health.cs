/*
 * Created By: Samantha Parton
 * Date Created: 9/30/2021
 * 
 * Last Modified By: Samantha Parton
 * Last Modified Date: 9/30/2021
 * 
 * Description: Creates a reusable health component
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /***Variables***/
    public bool DestroyOnDeath = true;
    public GameObject DeathParticlesPrefab = null;
    [SerializeField] private float _HealthPoints = 100f;

    public float HealthPoints
    {
        get { return _HealthPoints; }
        set
        {
            _HealthPoints = value;
            if (HealthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);

                if (DeathParticlesPrefab != null)
                {
                    Instantiate(DeathParticlesPrefab, transform.position, transform.rotation);
                }

                if (DestroyOnDeath)
                {
                   
                    Destroy(gameObject);
                  //  Thread.Sleep(7000);
                  //  Application.Quit();
                }

            } //end if health = 0

        } //end setter

    } //end public float HealthPoints



    // Start is called before the first frame update
    void Start()
    {
        
    }


}
