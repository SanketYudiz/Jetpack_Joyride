using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static AnimationController instance;
    public Animator animator;
    public Player player;

    private void Start()
    {
        instance = this;
        //animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        Zapper.deadAnimation += DeadAnimation;
    }

    private void OnDisable()
    {
        Zapper.deadAnimation -= DeadAnimation;
    }

    public void jumpAnimation()
    {
        animator.SetTrigger("Jump");
    }

    public void DeadAnimation()
    {
        animator.SetTrigger("Dead");
        player.enabled = false;
    }
}
