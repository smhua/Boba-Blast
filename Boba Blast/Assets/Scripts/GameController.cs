using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{


    public static GameController instance;

    private static float health = 8;
    private static float maxHealth = 8;
    private static float moveSpeed = 5f;
    private static float fireRate = 0.5f;
    private static float bulletSize = 0.5f;

    public Text healthText;

    public static float Health
    {
        get => health;
        set => health = value;
    }

    public static float MaxHealth
    {
        get => maxHealth;
        set => maxHealth = value;

    }

    public static float MoveSpeed
    {
        get => moveSpeed;
        set => moveSpeed = value;

    }

    public static float FireRate
    {
        get => fireRate;
        set => fireRate = value;

    }

    public static float BulletSize
    {
        get => bulletSize;
        set => bulletSize = value;
    }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }

    public static void DamagePlayer(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            KillPlayer();
        }
    }

    public static void HealPlayer(float healAmount)
    {
        health = Mathf.Min(maxHealth, health + healAmount);
    }

    public static void MoveSpeedChange(float speed)
    {
        moveSpeed += speed;
    }

    public static void AttackSpeedChange(float rate)
    {
        fireRate += rate;
    }

    public static void BulletSizeChange(float size)
    {
        bulletSize += size;
    }

    private static void KillPlayer()
    {

    }
}
