using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToCanvas : MonoBehaviour
{

    #region Belirlenen nesneyi takip için

    [SerializeField] public Transform Object;
    [SerializeField] public Vector3 offset;

    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
        Destroy(gameObject, 3.5f);
    }

    private void Update()
    {
        Object.DOMove(new Vector3(2, 10f, 0), 3f);
    }


 

    #endregion

}
