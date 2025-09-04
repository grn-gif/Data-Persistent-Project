using UnityEngine;

public class DeathZone : MonoBehaviour//Our Game Script
{
    public MainManager Manager;

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Manager.GameOver();
    }
}
