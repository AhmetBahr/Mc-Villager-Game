using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScrpts : MonoBehaviour
{
    public int stoneHealth = 5;

    public Transform stoneTrasnform;
    public Transform goldTrasform;
    public Transform CoinPosi;
    public GameObject stone;
    public GameObject Gold;
    public GameObject Coin;


    public int GoldCount = 100;
    public int StoneCount = 10;


    void Start()
    {
        stone = this.gameObject;
    }


    void Update()
    {
        if (stoneHealth <= 0)//Can� bitti�inde yok etmek i�in
        {
            DestroyStone();
        }

       
        
            if (Input.GetMouseButtonDown(0))
            {
               
                CanAzalt();
            }
        

    }

    public void CanAzalt()
    {
        stoneHealth--;
        Instantiates();
        //Debug.Log(GoldCount + " " + StoneCount);

    }

    public void DestroyStone()
    {
        Destroy(stone);

    }

    public void Instantiates() //Nesneleri belirlenen pozisyonda spawnlamak i�in 
    {
        Instantiate(stoneTrasnform, stone.transform.position, Quaternion.identity);
        Instantiate(stoneTrasnform, stone.transform.position, Quaternion.identity);
        Instantiate(goldTrasform, stone.transform.position, Quaternion.identity);
     
        StartCoroutine(Spawn());

    }



    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2);


        Instantiate(CoinPosi, stone.transform.position, Quaternion.identity);
    }
}
