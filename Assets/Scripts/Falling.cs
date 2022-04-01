using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       /* speed = -0.1f;*/
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameStats.State == "play")
        {
            transform.position = transform.position + new Vector3(0, speed, 0);
            if (transform.position.y < 1)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {

      //  Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Container" ) {
            GameObject cap = other.gameObject.transform.parent.gameObject.transform.GetChild(1).gameObject;
            if (cap.GetComponent<CollectPoints>().isOpen == true)
            {
               //  Debug.Log(other.gameObject.tag);
               // Debug.Log(cap.GetComponent<CollectPoints>().capId);
                cap.GetComponent<CollectPoints>().isHit = true;
                //Debug.Log("MATCH");
                GameStats.Points++;
                //Debug.Log(GameStats.Points);
            }


        }
        //  GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        // GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
    }
}
