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
    private AudioClip  shootSound = null;
    [SerializeField, RequiresAny]
    private Collider2D headCollider   = null;
    // [SerializeField]
    // private Collider2D defaultCollider = null;
    [SerializeField, Range(0.1f, 45)]
    private float      seeLenght      = 3f;
    [SerializeField, Range(0, 1000)]
    private int        bounceForce    = 350;
    [SerializeField, Min(0)]
    private int        scoreReward    = 10;
    [SerializeField, Range(0.01f, 10)] 
    private float      bulletSpeed    = 1;
    [SerializeField, Range(0.1f, 10)]
    private float      shootSpeed     = 1;
    [SerializeField]
    private Bullet     bulletPrefab   = null;
    [SerializeField]
    private Transform  shootPoint     = null;
    [SerializeField]
    private Bullet.BulletType bulletType = Bullet.BulletType.Buggy;
    [SerializeField]
    private AudioClip onPlayerJumped = null;
    [SerializeField]
    private AudioSource shooterSource = null;

    public override bool IsBad => true;

    [Auto]
    public  SpriteRenderer     Renderer { get; private set; }
    [Auto]
    public  Animator           Animator { get; private set; }



    public void Shoot(Direction dir)
    {

        shooterSource.PlayOneShot(shootSound);
        var bullet= Instantiate(bulletPrefab, this.shootPoint.transform.position, Quaternion.identity);
        bullet.Dir = dir;
        bullet.Speed = bulletSpeed;
        bullet.CurrentBulletType = bulletType;
        switch (bulletType)
        {
            case Bullet.BulletType.Buggy: 
                bullet.SpriteRenderer.color = Color.white;
                break;


            case Bullet.BulletType.Deadly:
                bullet.SpriteRenderer.color = Color.red;
                break;
        }


    }
    protected override void Start()
    {
        base.Start();
       
        StartCoroutine(Shooting());
    }
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (headCollider == null)
        {
            return;
        }


        if (headCollider.IsTouching(PlayerController.Instance.Foot) &&
collision.GetComponent<PlayerController>() &&
PlayerController.Instance.Rgb.velocity.y < 1)
        {

            WhenPlayerJumped();
        }

        else
        {
            base.OnTriggerEnter2D(collision);
        }




    }
    protected override void OnColidWithPlayer(PlayerController player)
    {
        PlayerController.Instance.PushBugs(GlitchEffect.GetRandomGlitchEffect());
        Explode();
       
    }

    private IEnumerator Shooting()
    {
        while(true)
        {
            Vector2 difference = (Vector2)(PlayerController.Instance.transform.position - this.transform.position);
            if (difference.magnitude <= seeLenght&&difference.magnitude>=3.5f)
            {
                Animator.SetTrigger("shoot");
                Shoot((Direction)difference);
                yield return Async.Wait(TimeSpan.FromSeconds(1f / shootSpeed));

            }
            else
                yield return Async.NextFrame;
           
         
           
        }
    }
 
    protected override void OnExplode()
    {
        Destroy(headCollider);
        Animator.SetTrigger("isDead");
        StopAllCoroutines();
        Invoke(() => DestroyWithEffect(), 0.22f);

    }
   
    public void WhenPlayerJumped()
    {
        shooterSource.PlayOneShot(onPlayerJumped);
        Explode();
        PlayerController.Instance.PlayJumpSound();
        PlayerController.Instance.Rgb.AddForce(Vector2.up * bounceForce);
        GameManager.Instance.AddScore(scoreReward);
    }

    

}