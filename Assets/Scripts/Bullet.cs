using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage = 10;
    public float bulletSpeed = 5f;
    public Vector3 bulletDirection;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += bulletSpeed * bulletDirection * Time.deltaTime;
    }
}
