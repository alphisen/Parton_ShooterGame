/*
 * Created By: Samantha Parton
 * Date Created: 10/06/2021
 * 
 * Last Modified By: Samantha Parton
 * Last Modified Date: 10/06/2021
 * 
 * Description: script that makes enemy damage player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{
    //Damage per second
    public float DamageRate = 10f;
    void OnTriggerStay(Collider Col)
    {
        Health H = Col.gameObject.GetComponent<Health>();
        if (H == null)
        {
            return;
        }
        H.HealthPoints -= DamageRate * Time.deltaTime;
    }
}
