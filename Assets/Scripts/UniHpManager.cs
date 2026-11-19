using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniHpManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp = 5;
    public Boolean tookdamage = false;
    public float timeSinceLastDamage = 0f;

    SpriteRenderer spriteRenderer;
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        timeSinceLastDamage = 1f;
        if(GetComponent<bossmover>() != null)
        {
            hp = 30;
        }
        if (GetComponent<wizkingmovement>() != null)
        {
            hp = 30;
        }
        if (GetComponent<monkeyman>() != null)
        {
            hp = 5;
        }

        if(GetComponent<SwordMasterMovement>()!= null)
        {
            hp = 30;
        }


        if (GetComponent<bigManControl>() != null)
        {
            hp = 30;
        }

        if(gameObject.name == "Circle")
        {
            hp = 50000;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
        timeSinceLastDamage += Time.deltaTime;

        if (timeSinceLastDamage > 0f && timeSinceLastDamage < 0.175f)
        {
                spriteRenderer.material.color = new Color(255f, 255f, 255f);
        }
        else
        {
            spriteRenderer.material.color = new Color(1f, 1f, 1f);
        }

        
    }
}
