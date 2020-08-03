using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHandler : MonoBehaviour
{

    public GameObject player;
    public GameObject manager;
    private GameObject item;
    public GameObject camera;
    private bool pickUp = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hitPlay;

        if (Physics.Raycast(camera.transform.position, camera.transform.TransformDirection(Vector3.forward), out hitPlay, 5f) & Input.GetKey("f"))
        {
            item = hitPlay.collider.gameObject;
            manager.GetComponent<gameManager>().addItemInventory(item.GetComponent<ItemBaseScript>().inventoryIcon);
            Destroy(item.gameObject);
        }

    }
}