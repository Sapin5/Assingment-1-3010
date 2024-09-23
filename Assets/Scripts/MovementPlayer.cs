using UnityEngine;

public class MovementPlayer : MonoBehaviour
{   

    public float fallSpeed;
    public Rigidbody2D physicsBody;
    public bool touchingGround;

    private void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(PlayerHP.singleton.Currenthp() >= 1){
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10, 0, 0 );
            if(Input.GetKeyDown(KeyCode.UpArrow) && touchingGround)
            {
                physicsBody.AddForce(Vector2.up * fallSpeed, ForceMode2D.Impulse);
                touchingGround = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        touchingGround = true;
    }


}
