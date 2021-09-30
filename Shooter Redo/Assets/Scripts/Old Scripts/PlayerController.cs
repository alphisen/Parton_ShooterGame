/*
 * Created By: Samantha Parton
 * Date Created: 9/29/2021
 * 
 * Last Modified By: Samantha Parton
 * Last Modified Date: 9/29/2021
 * 
 * Description: controls a player object to move and shoot, etc
 * */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool MouseLook = true;
    public string HorzAxis = "Horizontal";
    public string VertAxis = "Vertical";
    public string FireAxis = "Fire1";
    public float MaxSpeed = 5f;

    private Rigidbody ThisBody = null;

    void Awake()
    {
        ThisBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float Horz = Input.GetAxis(HorzAxis);
        float Vert = Input.GetAxis(VertAxis);
        Vector3 MoveDirection = new Vector3(Horz, 0.0f, Vert);
        ThisBody.AddForce(MoveDirection.normalized * MaxSpeed);
        ThisBody.velocity = new Vector3
        (Mathf.Clamp(ThisBody.velocity.x, -MaxSpeed,
        MaxSpeed),
        Mathf.Clamp(ThisBody.velocity.y, -MaxSpeed,
        MaxSpeed),
        Mathf.Clamp(ThisBody.velocity.z, -MaxSpeed,
        MaxSpeed));

        if (MouseLook)
        {
            Vector3 MousePosWorld =
            Camera.main.ScreenToWorldPoint(new
            Vector3(Input.mousePosition.x,
            Input.mousePosition.y, 0.0f));
            MousePosWorld = new Vector3(MousePosWorld.x,
            0.0f, MousePosWorld.z);
            Vector3 LookDirection = MousePosWorld -
            transform.position;
            transform.localRotation = Quaternion.LookRotation
    
        (LookDirection.normalized, Vector3.up);

        }// end if

    } // end fixed update

}