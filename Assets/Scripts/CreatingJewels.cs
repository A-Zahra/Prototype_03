using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingJewels : MonoBehaviour
{
    public GameObject jewel;
    public GameObject container;
    public Material[] test = new Material [8];
    public GameObject []containers = new GameObject[16];
    private bool notStarted = false;
    public Material wrongMaterial;
    // Start is called before the first frame update
    void Start()
    {
       
       createNewJewelContainers();

    }

    // Update is called once per frame
    void Update()
    {

        if (GameStats.State == "play" && notStarted == false)
        {
            InvokeRepeating("createNewJewels", 1f, 5f);
            notStarted = true;
            //Debug.Log("once");
        }
    }
    void createNewJewels() {
        int cIndex = 0;
        for (float i = -2.83f; i < 4.83; i = i + 2)
        {
            for (float j = -2.83f; j < 4.83; j = j + 2)
            {
                GameObject theJewel = Instantiate(jewel);
                theJewel.transform.position = new Vector3(i, 15, j);
                  int index = Random.Range(0, 8);
                
                    theJewel.GetComponent<Renderer>().material = new Material(test[index]);

                theJewel.GetComponent<Falling>().speed = Random.Range(-0.07f, -0.08f);
                containers[cIndex].transform.GetChild(1).gameObject.SetActive(true);
                containers[cIndex].transform.GetChild(1).gameObject.GetComponent<CollectPoints>().isHit = false;
                containers[cIndex].transform.GetChild(1).gameObject.GetComponent<CollectPoints>().isOpen= false;

                if (containers[cIndex].transform.GetChild(1).gameObject.GetComponent<CollectPoints>().wrongHit== false)
                {
                    Renderer[] rs = containers[cIndex].GetComponentsInChildren<Renderer>();
                    rs[0].material = new Material(test[index]);
                    rs[1].material = new Material(test[index]);

                }
                else
                {

                    Renderer[] rs = containers[cIndex].GetComponentsInChildren<Renderer>();
                    rs[0].material = new Material(wrongMaterial);
                    rs[1].material = new Material(wrongMaterial);
                }
               


                cIndex++;
              //  Debug.Log(cIndex);

            }
        }
    }

    void createNewJewelContainers()
    {
        int index = 0;
        for (float i = -1.83f; i < 5.83; i = i + 2f)
        {
            for (float j = -2.93f; j < 3.13; j = j + 2f)
            {

                GameObject theJewelContainer = Instantiate(container);
                theJewelContainer.transform.position = new Vector3(i, .44f, j);
                theJewelContainer.transform.GetChild(1).gameObject.GetComponent<CollectPoints>().capId = index;
             //   Debug.Log(theJewelContainer.transform.GetChild(1).gameObject.GetComponent<CollectPoints>().capId);

                containers[index] = theJewelContainer;
                index++;
            }
        }
    }
}
