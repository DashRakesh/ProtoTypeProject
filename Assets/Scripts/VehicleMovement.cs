using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{

    public float steerSpeed = 1f;
    Rigidbody vehiclerb;

    MeshCollider VehiclebodyCollider;
   // public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        vehiclerb = this.GetComponent<Rigidbody>();
        VehiclebodyCollider = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
       // MoveForward();
      //  MoveSideWay();
      
    }
    void MoveForward()
    {
        transform.Translate(0, 0, steerSpeed);
    }
  
   void MoveSideWay()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(10f, 0f, 0f) * Time.deltaTime, Space.World);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(-10f, 0f, 0f) * Time.deltaTime, Space.World);
        }
    }

    private void FixedUpdate()
    {
        MoveForward();
        MoveSideWay();
    }
     void OnCollisionEnter(Collision other)
    {
      if(other.gameObject.name== "Barrel_02")
        {
            Die();
        }
    }

    void Die()
    {
       // if (VehiclebodyCollider.(LayerMask.GetMask("Enimes"))){ }
        FindObjectOfType<GameSeassion>().ProcessPlayerDeath();
    }

}
