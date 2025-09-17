using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    const float hoursToDegrees = 360f / 12f;   // 30
    const float minutesToDegrees = 360f / 60f; // 6
    const float secondsToDegrees = 360f / 60f; // 6

    void Update()
    {
        DateTime t = DateTime.Now;

        float seconds = t.Second + t.Millisecond / 1000f;
        float minutes = t.Minute + seconds / 60f;
        float hours = (t.Hour % 12) + minutes / 60f;

        if (secondHand) secondHand.localRotation = Quaternion.Euler(seconds * secondsToDegrees, 0f, -90f);
        if (minuteHand) minuteHand.localRotation = Quaternion.Euler(minutes * minutesToDegrees, 0f, -90f);
        if (hourHand) hourHand.localRotation = Quaternion.Euler(hours * hoursToDegrees, 0f, -90f);
    }
}
