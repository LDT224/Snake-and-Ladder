using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class DiceController : MonoBehaviour
{
    [SerializeField] Sprite[] dice;
    [SerializeField] Animator diceAnim;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {
        diceAnim.SetBool("Rolling", true);
        int ran = Random.Range(1, 7);
        Debug.Log(ran);
        gameObject.GetComponent<SpriteRenderer>().sprite = dice[ran-1];

        diceAnim.SetBool("Rolling", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
