using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpeed : MonoBehaviour
{
    public float MoveSpeed = 5f;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.down, Time.deltaTime*MoveSpeed);
    }
}
