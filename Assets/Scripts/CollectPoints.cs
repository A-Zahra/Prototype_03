using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPoints : MonoBehaviour
{

    public GameObject colorIndicatorObj;
    public bool isHit;
    public bool isOpen;
    public int capId;
    public bool wrongHit;
    public Material wrongMaterial;
    public AudioClip correctClip;
    public AudioClip wrongClip;
    private AudioSource clips;
    
    //private AudioSource wrongAudio;
    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
        isOpen = false;
        wrongHit = false;
        clips = gameObject.GetComponent<AudioSource>();

     
    }

    // Update is called once per frame
    void FixedUpdate()
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
                    if(raycastHit.transform.gameObject.tag == "cap")
                    {

                        colorIndicatorObj = GameObject.FindGameObjectWithTag("colorIndicator");
                        Material correctMaterialColor = colorIndicatorObj.GetComponent<ColorIndicator>().currentMaterial;
                        //  Debug.Log(correctMaterialColor.name);
                        // Debug.Log(raycastHit.transform.gameObject.GetComponent<Renderer>().material.name);
                        if(raycastHit.transform.gameObject.GetComponent<Renderer>().material.name.Contains(correctMaterialColor.name))
                        {
                            clips.clip = correctClip;
                            clips.Play();

                            if (raycastHit.transform.gameObject.GetComponent<CollectPoints>().isHit == false) {
                                raycastHit.transform.gameObject.GetComponent<CollectPoints>().isOpen= true;

                            }
                            raycastHit.transform.gameObject.SetActive(false);

                        }
                        else if(raycastHit.transform.gameObject.GetComponent<CollectPoints>().wrongHit ==false)
                        {
                            clips.clip = wrongClip;
                            clips.Play();

                            GameStats.wrongCapTouched += 1;
                            Debug.Log("here");
                            Debug.Log(GameStats.wrongCapTouched);
                            raycastHit.transform.gameObject.GetComponent<CollectPoints>().wrongHit = true;
                            GameObject containerParent = raycastHit.transform.gameObject.transform.parent.gameObject;
                            
                            Renderer[] rs = containerParent.GetComponentsInChildren<Renderer>();
                            rs[0].material = new Material(wrongMaterial);
                            rs[1].material = new Material(wrongMaterial);
                        }

                    }

                }
            }
        }
    }
}
