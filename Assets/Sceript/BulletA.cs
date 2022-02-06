using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletA : BulletBase
{

    void Start()
    {
        damage = 10;
        speed = 3;
        Invoke("Destroy", 1f);
    }
    

    void Update()
    {
        MoveToUp(speed);
    }


}
