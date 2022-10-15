using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoTweenDestroyer : MonoBehaviour
{
    public Ease ease;


    void Start()
    {
        DOTween.Init();
        //Nesnenin görünmez hale gelmesi 
       transform.DOScale(0.35f, 3f).SetEase(ease).From();

        DestroyObject();
    }


    void DestroyObject()
    {//Nesneyi yok etmek için
        Destroy(gameObject, 3f);
    }
}
