using UnityEngine;

public class Bike : PlayerAbility
{
    private float jumpSpeed = 7f;
    private float moveSpeed = 12f;
    private Rigidbody2D player;

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movment();
        ClampPlayer();
    
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    public override void Jump()
    {
        player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        Debug.Log("jump with Bike");
    }
    public override void movment()
    {
        player.velocity = new Vector2(moveSpeed,player.velocity.y);
    }
}
