using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MapController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < gameObject.transform.childCount; i++)
        {
            if(i % 2 == 0)
            {
                gameObject.transform.GetChild(i).GetComponent<SpriteRenderer>().color = new Color32(184,233,134,255);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
