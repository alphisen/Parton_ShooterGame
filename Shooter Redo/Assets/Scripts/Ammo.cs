/*
 * Created By: Samantha Parton
 * Date Created: 10/06/2021
 * 
 * Last Modified By: Samantha Parton
 * Last Modified Date: 10/06/2021
 * 
 * Description: controlls ammo damage
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float Damage = 100f;
    public float LifeTime = 2f;
    void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", LifeTime);
    }
    void OnTriggerEnter(Collider Col)
    {
        Health H = Col.gameObject.GetComponent<Health>();
        if (H == null)
        {
            return;
        }
        H.HealthPoints -= Damage;
        Die();
    }
    void Die()
    {
        gameObject.SetActive(false);
    }
}
