/*
 * Created By: Samantha Parton
 * Date Created: 10/06/2021
 * 
 * Last Modified By: Samantha Parton
 * Last Modified Date: 10/06/2021
 * 
 * Description: Mover script for the enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    /***Variables***/

    public float MaxSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MaxSpeed * Time.deltaTime;
    } // end update
}
