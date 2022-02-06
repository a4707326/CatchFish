using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletBase : MonoBehaviour
{

    
    protected float speed;    // ³t«×
    protected float damage;    // ¶Ë®`
    protected float chips;    // µo®gÄw½X


    //public float Speed
    //{
    //    set => speed = value;
    //}

    //public float Damage
    //{
    //    set => damage = value;
    //}

    //public float Chips
    //{
    //    set => chips = value;
    //}

    public virtual void MoveToUp(float speed)
    {
        //transform.Translate(transform.up * Time.deltaTime * speed);
        transform.Translate(0 , 1 * Time.fixedDeltaTime * speed, 0);
    }

    public virtual void Attack(GameObject target)
    {
    }
    //public virtual void Init(float speed, float damage, float chips)
    //{
    //    this.speed = speed;
    //    this.damage = damage;
    //    this.chips = chips;
    //}
    protected void Destroy()
    {
        Destroy(gameObject);
    }


}
