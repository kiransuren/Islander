using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject inventory;
    private Vector4 colorReset = new Vector4(255f, 255f, 255f, 1f);
    private ArrayList Inventory = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        Inventory.LastIndexOf("empty");
        for(int i=0; i < 6; i++)
        {
            Inventory.Add("empty");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int addItemInventory(Sprite itemSprite)
    {
        for(int i=0; i<6; i++)
        {
            if ((string) Inventory[i] == "empty")
            {
                Debug.Log(i);
                inventory.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = itemSprite;
                inventory.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = colorReset;
                Inventory[i] = "used";
                return 1;
            }
        }

        return 0;
        
    }
}
