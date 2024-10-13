using UnityEngine;

public class TopDownLook : MonoBehaviour
{
    private TopDownController controller;
    private SpriteRenderer characterSprite1;
    private SpriteRenderer characterSprite2;
    private Vector2 lookDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        characterSprite1 = transform.Find("Penguin").GetComponent<SpriteRenderer>();
        characterSprite2 = transform.Find("Knight").GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        ApplyLook(lookDirection);
    }

    private void Start()
    {
        controller.OnLookEvent += Look;
    }

    private void Look(Vector2 vector)
    {
        lookDirection = vector;
    }

    private void ApplyLook(Vector2 direction)
    {
        if (direction.x < 0) 
        {
            characterSprite1.flipX = true;
            characterSprite2.flipX = true;
        }
        else
        {
            characterSprite1.flipX = false;
            characterSprite2.flipX = false;
        }
    }
}