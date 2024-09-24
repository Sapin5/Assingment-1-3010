using UnityEngine;

public class PlayerHP : MonoBehaviour
{
// Exlposion gameobjegt
    public GameObject explosionGo;
    
    //Player HP
    private int hp = 10;

    // Allows other Scripts to access HP
    public static PlayerHP singleton;

    private HealthManager healthManager;

    //Sets singleton to this game object
    void Awake(){
        singleton = this;
        healthManager = gameObject.GetComponent<HealthManager>();
    }

    // On collsion with Enemy loses HP
    private void OnCollisionEnter2D(Collision2D collision){
        // Checks if object collided with was an enemy
        if(collision.gameObject.CompareTag("Enemy")|| 
            collision.gameObject.CompareTag("Bullet")){
            // Reduces HP
            hp-=1;
            healthManager.TakeDamage(1);
        }  
        boom();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        // Checks if object collided with was an enemy
        if(collision.gameObject.CompareTag("Enemy")|| 
            collision.gameObject.CompareTag("Bullet")){
            healthManager.TakeDamage(1);
            // Reduces HP
            hp-=1;
        }
        boom();
    }

    public void boom(){
        if(hp == 0 && MovementPlayer.touchingGround){
            // Creates new explosion object
            GetComponent<Collider2D>().enabled = false;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            Instantiate(explosionGo, transform.position, transform.rotation);
        }else{
            GetComponent<Collider2D>().enabled = true;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }

    public int Currenthp(){
        return hp;
    }

    public void updateHP(int health){
        hp = health;
        healthManager.TakeDamage(-10);
        boom();
    }
}
