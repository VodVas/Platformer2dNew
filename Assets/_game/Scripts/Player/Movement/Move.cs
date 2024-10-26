using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void DoMove(float speed)
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        Vector2 move = new Vector2(moveX * speed, _rigidbody.linearVelocity.y);

        _rigidbody.linearVelocity = move;

        if (moveX != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveX), 1, 1);
        }
    }
}