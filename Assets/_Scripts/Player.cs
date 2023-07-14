using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private void Update()
    {
        Vector2 inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Vector3 movementVector = new Vector3(inputVector.x, 0, inputVector.y);

        transform.position += movementVector * Time.deltaTime * moveSpeed;
    }
}
