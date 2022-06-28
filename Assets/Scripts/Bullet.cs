using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage = 10;
    public float bulletSpeed = 5f;
    public Vector3 bulletDirection;
    public float bulletLifeTime;
    private Vector3 _actualScale;

    private void Start()
    {
        _actualScale = transform.localScale;
    }

    void Update()
    {
        transform.position += bulletSpeed * bulletDirection * Time.deltaTime;
        DestroyBullet();
        IncreaseSize();
    }

    void DestroyBullet()
    {
        bulletLifeTime -= Time.deltaTime;
        if (bulletLifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
       
    void IncreaseSize()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           _actualScale *= 2;
            transform.localScale = _actualScale;
        }
    }    
}
