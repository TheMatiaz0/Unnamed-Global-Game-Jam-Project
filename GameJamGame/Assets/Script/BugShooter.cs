﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Cyberevolver;
using Cyberevolver.Unity;

public class BugShooter : ActiveElement
{
   

    [SerializeField]
    [Range(0.2f, 10)]
    private float bulletSpeed = 1;
    [SerializeField]
    [Range(0.1f, 10)]
    private float shootSpeed = 1;
    [SerializeField]
    private Bullet bulletPrefab = null;
    [SerializeField]
    private Transform shootPoint;
    [Auto]
    public SpriteRenderer Renderer { get; private set; }
    [Auto]
    public Animator Animator { get; private set; }
    public void Shoot(Direction dir)
    {
        var bullet= Instantiate(bulletPrefab, this.shootPoint.transform.position, Quaternion.identity);
        bullet.Dir = dir;
        bullet.Speed = bulletSpeed;
    }
    protected override void Start()
    {
        base.Start();
        StartCoroutine(Shooting());
    }
    private IEnumerator Shooting()
    {
        while(true)
        {
            yield return Async.Wait(TimeSpan.FromSeconds(1f/shootSpeed));
            Animator.SetTrigger("shoot");
            Shoot((Direction)(Vector2)(this.transform.position - PlayerController.Instance.transform.position));
        }
    }
    protected override void OnKill()
    {
        Animator.SetTrigger("isDead");
    }
    protected override void OnColidWithPlayer(PlayerController player)
    {
        PlayerController.Instance.Kill();
    }
}