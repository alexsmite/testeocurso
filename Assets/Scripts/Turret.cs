using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject BulletPrefab;

    void Start()
    {
        ShootBullet();
    }

    void Update()
    {
        
    }
    private void ShootBullet()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }
}
