/*
 * Created By: Samantha Parton
 * Date Created: 9/29/2021
 * 
 * Last Modified By: Samantha Parton
 * Last Modified Date: 9/29/2021
 * 
 * Description: gets horiz and ver values
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler: MonoBehaviour
{

    public Vector2 InputVector { get; private set; }

    public Vector3 MousePosition { get; private set; }

    void Update()
    {

        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        InputVector = new Vector2(h, v);

        MousePosition = Input.mousePosition;

    }

}
