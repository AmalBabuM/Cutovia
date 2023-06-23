using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float gravity = 9.81f;
    private float verticalVelocity = 0f;

    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        movement = transform.TransformDirection(movement);
        movement *= moveSpeed;

        if (controller.isGrounded)
        {
            verticalVelocity = 0f;

            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity += Mathf.Sqrt(2f * gravity);
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        movement.y = verticalVelocity;

        controller.Move(movement * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Level1"))
        {
            TopGameManager.Instance.Level[0].SetActive(true);
        }
        else if (other.gameObject.CompareTag("Level2"))
        {
            TopGameManager.Instance.Level[1].SetActive(true);
        }
        else if(other.gameObject.CompareTag("Level6"))
        {
            TopGameManager.Instance.Level[2].SetActive(true);
        }
    }
    private void ActivateChildObject(GameObject parentObject)
    {
        foreach (Transform child in parentObject.transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}

    
