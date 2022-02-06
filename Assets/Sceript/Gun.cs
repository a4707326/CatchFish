using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //public GameObject a;
    // Start is called before the first frame update

    private Transform firePosition;
    private float fireCd = 0.2f;
    [SerializeField]
    private float fireCdTimer = 0f;
    public BulletBase Bullet;

    

    void Awake()
    {
        firePosition = transform.Find("FirePosition").GetComponent<Transform>();

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        LookAtMouse();
        CanFire();

    }

    void LookAtMouse()
    {
        Vector2 different = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = different - new Vector2(transform.position.z, transform.position.y);
        //transform.up = new Vector3(different.x, different.y, 0) - transform.position;
    }

    void Fire()
    {
        //Bullet.Damage = 10;
        //Bullet.Chips = 5;
        //Bullet.Speed = 5;
        //Bullet.Init(5,10,5);
        Instantiate(Bullet, firePosition.position,transform.rotation);
        fireCdTimer = 0;
    }
    void CanFire()
    {
        fireCdTimer += Time.deltaTime;
        if (fireCdTimer > fireCd && Input.GetMouseButton(0))
        {
            Fire();
        }
    }

}
