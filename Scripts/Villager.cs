using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : MonoBehaviour
{
    public GameObject SCstone ;
    StoneScrpts SC;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            
            Hit();
        }
    }


    public void Hit()
    {

        SC = SCstone.GetComponent<StoneScrpts>();         //StoneCont kod sayfas�ndaki kodlara ula�mak i�in
        SC.CanAzalt();

    }
}
