using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private PlayerInput playerInput;

    private bool isWalking;
    private void Update()
    {
        Vector2 inputVector = playerInput.GetMovementVectorNormalized();
        Vector3 movementVector = new Vector3(inputVector.x, 0, inputVector.y);

        transform.position += movementVector * Time.deltaTime * moveSpeed;

        isWalking = movementVector != Vector3.zero;

        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, movementVector, Time.deltaTime * rotateSpeed);
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
