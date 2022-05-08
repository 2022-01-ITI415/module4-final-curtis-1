using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollection : MonoBehaviour
{
    public int NumberOfBalls { get; private set; }
    public UnityEvent<PlayerCollection> OnBallCollected;
    public void BallCollected()
    {
        NumberOfBalls++;
        OnBallCollected.Invoke(this);
    }
}
