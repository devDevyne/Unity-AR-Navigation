using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSetWaypointPosition : MonoBehaviour
{
    // Lat and Lon values for the desired position 
    public float latitude;
    public float longitude;

    // Conversion scale factors to adjust the position in Unity
    public float latitudeScale = 1f;
    public float longitudeScale = 1f;
    public float height = 0f;

    void Start()
    {
        // Convert lat and lon to Unity coordinates
        float unityX = longitude * longitudeScale;
        float unityZ = latitude * latitudeScale;

        //Set the game object's position
        transform.position = new Vector3(unityX, height, unityZ);
    }
}
