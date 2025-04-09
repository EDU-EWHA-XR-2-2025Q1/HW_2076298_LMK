using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject LampObject;

    // Start is called before the first frame update
    void Start()
    {
        LampObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)) {
            LampObject.SetActive(!LampObject.activeSelf);
        }
    }
}
