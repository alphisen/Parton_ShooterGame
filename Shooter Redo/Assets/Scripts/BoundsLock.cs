/*
 * Created By: Samantha Parton
 * Date Created: 9/29/2021
 * 
 * Last Modified By: Samantha Parton
 * Last Modified Date: 9/29/2021
 * 
 * Description: Creates a border that the player can't pass
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsLock : MonoBehaviour
{
    public Rect levelBounds; //the x, y points and w, h of the bounding rectangle

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, levelBounds.xMin,
            levelBounds.xMax), transform.position.y, Mathf.Clamp(transform.position.z, levelBounds.yMin,
            levelBounds.yMax));
    }

    private void OnDrawGizmosSelected()
    {
        const int cubeDepth = 1;
        Vector3 boundsCenter = new Vector3(levelBounds.xMin + levelBounds.width * 0.5f, 0,
            levelBounds.yMin + levelBounds.height * 0.5f);
        Vector3 boundsHeight = new Vector3(levelBounds.width, cubeDepth, levelBounds.height);

        Gizmos.DrawWireCube(boundsCenter, boundsHeight);


    }
}
