using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakcgroundController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 resetPoint;

    void Start(){
        resetPoint = new Vector2(23f, this.transform.position.y);    
    }

    void Update(){
        if(transform.position.x <= -15){
            transform.position = resetPoint;
        }
    }
}
