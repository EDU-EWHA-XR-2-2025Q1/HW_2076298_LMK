using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Container : MonoBehaviour
{
    public GameObject Item;
    public Transform TargetAnchor;

    int cloneCount = 10;
    public int columns = 5; 
    public float spacing = 0.05f; 
    float frontOffset = 0.05f; 

    private bool cloned = false;

    public void Clone_Items()
    {
        if (cloned) return;
        Item.SetActive(false);
        
        for(int i = 0; i < cloneCount; i++)
        {
            Clone_Item(i);
        }

        cloned = true;
    }

    void Clone_Item(int id)
    {
        GameObject Clone = Instantiate(Item); // 복제
        Clone.name = "Clone-" + string.Format("{0:D4}", id);
        Clone.SetActive(true);

        int row = id / columns;
        int col = id % columns;

        Vector3 offset = new Vector3(col * spacing, 0f, row * spacing + frontOffset);
        Clone.transform.position = TargetAnchor.position + TargetAnchor.TransformDirection(offset);
        Clone.transform.rotation = TargetAnchor.rotation;
        Clone.transform.SetParent(TargetAnchor);
    }
}
