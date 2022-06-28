using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTurret : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float cadence;
    public float timeToNextBullet;

    void Start()
    {
        timeToNextBullet = cadence;
    }

    void Update()
    {
        timeToNextBullet -= Time.deltaTime;
        if (timeToNextBullet <= 0)
        {
            Shoot();
            timeToNextBullet = cadence;
        }
        
    }

    private void Shoot()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }
}
