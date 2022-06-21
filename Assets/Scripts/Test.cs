using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int playerHealth = 100;
    int actualHealth = 1;
    public float playerSpeed = 5f;
    public Vector3 movPlayer;
    public Vector3 scalePlayer;

    void Start()
    {
        actualHealth = playerHealth;
        transform.localScale = scalePlayer;
    }

    void Update()
    {
        PlayerMovement();
        HealPlayer();
        HurtPlayer();
        Debug.Log("actualHealth: " + actualHealth);
    }

    void PlayerMovement()
    {
        transform.Translate(playerSpeed * Time.deltaTime * movPlayer);
    }

    void HealPlayer()
    {
        actualHealth++;
    }

    void HurtPlayer()
    {
        actualHealth--;
    }
}
