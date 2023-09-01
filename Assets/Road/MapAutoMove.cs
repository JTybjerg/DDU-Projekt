using UnityEngine;
using System.Collections;

public class AutoMove : MonoBehaviour
{

    public float speed = 5f;

void Update()
{
    transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
}
}