using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    // Component for physics calculations
    public Rigidbody2D projectilePrefab;

    // FireRate
    public float firerate = 0.3f;
    // Timer for firerrate
    private float currentFireTimer = 0;
    // Controls wehter or not player is firing
    private bool isFiringButtonDown = false;
    // Force applied to bullet in order to propell it forwards on spawn
    public float shootForce = 1f;
    // How long bullet stays around before being removed 
    // if it hasnt hit anything
    public float bulletDeathTimer = 1f;
    // Player game object
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        currentFireTimer = firerate;
    }

    // Update is called once per frame
    void Update()
    {
        // Equates to true when Space bar is pressed
        isFiringButtonDown = Input.GetButton("Jump");

        // Increases to allow player to fire
        currentFireTimer += Time.deltaTime;

        // If the player is holding space will run the following
        if (isFiringButtonDown && Input.GetAxis("Horizontal") == 0) {

            // every .3 seconds will allow the a bullet to be spawned
            if (currentFireTimer >= firerate) {
                // Calls function to fire bullet
                FireOneBullet();
                // Resets timer to 0 to restart cycle
                currentFireTimer = 0;
            }
        }
    }

    private void FireOneBullet() {
        // Spawns bullet
        Rigidbody2D rg = Instantiate<Rigidbody2D>(projectilePrefab, transform.position,
                                                     player.transform.rotation);
        // Applies force to bullet to proell it in a direction 
        rg.AddRelativeForce(10*shootForce * Vector2.right);
        // Removes Bulllet afeter Given amount of time
        Destroy(rg.gameObject, bulletDeathTimer+10);
    }
    
}
