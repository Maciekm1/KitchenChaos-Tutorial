using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour
{

    public event Action OnInteractAction;
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        return playerInputActions.Player.Move.ReadValue<Vector2>().normalized;
    }
}
