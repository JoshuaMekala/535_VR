using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerToSphereSurface : MonoBehaviour
{

    public Transform tracker;
    public Transform sphereCenter;
    public float sphereRadius = 2.0f;
    public float azimuthOffset = 0.3f;
    public float thetaOffset = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = tracker.position - sphereCenter.position;
        Vector3 surfacePostition = (direction.normalized * sphereRadius);

        // Convert from Cartesian to Spherical
        float radius = Mathf.Sqrt((surfacePostition.x * surfacePostition.x) + (surfacePostition.y * surfacePostition.y) + (surfacePostition.z * surfacePostition.z));
        float theta = Mathf.Atan2(surfacePostition.z, surfacePostition.x);  // Azimuthal angle
        float phi = Mathf.Acos(surfacePostition.y / radius);   // Polar angle

        theta = -1 * (theta + (thetaOffset * (radius / sphereRadius)));  // right and left are inverted. Try and fix this.
        phi = phi + (azimuthOffset * (radius / sphereRadius));   // slight offset in phi observed, offset based on percentage of radius
  
        // Convert back to cartesian with fixed radius
        float x = radius * Mathf.Sin(phi) * Mathf.Cos(theta);
        float y = radius * Mathf.Cos(phi);
        float z = radius * Mathf.Sin(phi) * Mathf.Sin(theta);

        transform.position = new Vector3(x, y, z) + sphereCenter.position;

    }
}
