using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    // get input from player
    // apply movement to sprite 

    private void Update() // 
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");//Left right (trái phải)
        
        float vertical = Input.GetAxisRaw("Vertical");//Up Down (lên xuống) 

        Vector3 direction = new Vector3(horizontal, vertical);
        transform.position += direction * speed * Time.deltaTime;
    }

}
