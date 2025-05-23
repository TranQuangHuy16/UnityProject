using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in real-time seconds.")]
    public float dayDurationInSeconds = 120f; // Default: 2 minutes per full rotation

    // Update is called once per frame
    void Update()
    {
        // Calculate how many degrees to rotate this frame
        float degreesPerSecond = 360f / dayDurationInSeconds;
        float rotationThisFrame = degreesPerSecond * Time.deltaTime;

        // Apply rotation to simulate the sun moving
        transform.Rotate(Vector3.right, rotationThisFrame);
    }
}
