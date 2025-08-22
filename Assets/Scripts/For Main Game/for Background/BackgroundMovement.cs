using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class BackgroundMovement : MonoBehaviour
{
    public float treshold = -10f;
    public float MoveSpeed = 5f;
    public float additionValue;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.down, Time.deltaTime * MoveSpeed);

        if (transform.position.y < treshold)
        {

            Vector3 pos = transform.position;

            pos.y += additionValue;

            transform.position = pos;
        }
    }
}
