using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float cadence;
    private float _rateOfFire = 0.5f;
    private int _magazine = 0;

    void Start()
    {
        _rateOfFire = cadence;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            LoadMagazine(1);

        if (Input.GetKeyDown(KeyCode.J))
            LoadMagazine(2);

        if (Input.GetKeyDown(KeyCode.K))
            LoadMagazine(3);

        if (Input.GetKeyDown(KeyCode.L))
            LoadMagazine(4);

        if (_magazine > 0)
        {
            if (_rateOfFire <= 0)
            {
                Shoot();
                _magazine -= 1;
                _rateOfFire = cadence;
            }
            else
            {
                _rateOfFire -= Time.deltaTime;
            }
        }
    }
    private void LoadMagazine(int count)
    {
        _magazine = count;
    }    
    private void Shoot()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }
}
