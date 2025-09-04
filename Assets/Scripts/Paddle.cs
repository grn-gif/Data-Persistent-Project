using UnityEngine;

public class Paddle : MonoBehaviour//Our Game Script
{
    public float Speed = 2.0f;
    private float MaxMovement = 1.89f;
    
// Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        Vector3 pos = transform.position;
        pos.x += input * Speed * Time.deltaTime;

        if (pos.x > MaxMovement)
            pos.x = MaxMovement;
        else if (pos.x < -MaxMovement)
            pos.x = -MaxMovement;

        transform.position = pos;
    }
}
