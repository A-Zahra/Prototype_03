using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoints : MonoBehaviour
{

    public GameObject colorIndicatorObj;
    public bool isHit;
    public bool isOpen;
    public int capId;
   
    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
        isOpen = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 50f))
            {
                if (raycastHit.transform != null)
                {
                    //Our custom method. 
                    // clickHandler(raycastHit.transform.gameObject);
                    // raycastHit.transform.gameObject.GetComponent<Renderer>().material.color = Color.black;
                    //Debug.Log(raycastHit.transform.gameObject.tag);
                    if(raycastHit.transform.gameObject.tag == "cap")
                    {
                        //if material 

                        colorIndicatorObj = GameObject.FindGameObjectWithTag("colorIndicator");
                        Material correctMaterialColor = colorIndicatorObj.GetComponent<ColorIndicator>().currentMaterial;
                      //  Debug.Log(correctMaterialColor.name);
                      // Debug.Log(raycastHit.transform.gameObject.GetComponent<Renderer>().material.name);
                        if(raycastHit.transform.gameObject.GetComponent<Renderer>().material.name.Contains(correctMaterialColor.name))
                        {
                            //Debug.Log(isHit);
                            Debug.Log(raycastHit.transform.gameObject.GetComponent<CollectPoints>().capId);

                            if (raycastHit.transform.gameObject.GetComponent<CollectPoints>().isHit == false) {
                                // Debug.Log("not hit");
                                raycastHit.transform.gameObject.GetComponent<CollectPoints>().isOpen= true;
                             // Debug.Log("MATCH");
                             // GameStats.Points++;
                             //  Debug.Log(GameStats.Points);
                              

                            }
                            raycastHit.transform.gameObject.SetActive(false);

                        }
                      
                       // isHit = false;
                     

                    }

                }
            }
        }
    }
}
