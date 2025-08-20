using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float minX = -2.29f;
    public float maxX = 2.29f;
    public float yPosition = -4.3f;
    public float speed = 2f; // kecilin speed biar lebih lambat

    private void Start()
    {
        transform.position = new Vector2(0f, yPosition);
    }

    private void Update()
    {
        float move = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            move = 1f;
        }

        // gerak pakai deltaTime & speed
        Vector2 newPos = transform.position;
        newPos.x += move * speed * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);

        transform.position = new Vector2(newPos.x, yPosition);

        Debug.Log("Current Position: " + transform.position);
    }
}
