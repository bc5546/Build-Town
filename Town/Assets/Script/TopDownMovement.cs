using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    private Vector2 movementDirection=Vector2.zero;
    [SerializeField] private GameObject characterNameSquare;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        characterNameSquare = GameObject.Find("Canvas/CharacterNameSquare");
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        movementDirection = vector;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;

        Camera.main.transform.position = this.transform.position + new Vector3(0, 0, -10);
        characterNameSquare.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 1.7f, 0));
    }
}
