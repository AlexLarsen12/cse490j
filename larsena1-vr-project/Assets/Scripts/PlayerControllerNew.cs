using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerNew : MonoBehaviour {
    
    public float speed = 5;

    public Rigidbody rigid;
    
    
    // Update is called once per frame
    void Update() {
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.W)) {
            rigid.MovePosition(transform.position + this.transform.forward * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.S)) {
            rigid.MovePosition(transform.position + -this.transform.forward * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.A)) {
            rigid.MovePosition(transform.position + -this.transform.right * speed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.D)) {
            rigid.MovePosition(transform.position + this.transform.right * speed * Time.deltaTime);
        }
    }
}
