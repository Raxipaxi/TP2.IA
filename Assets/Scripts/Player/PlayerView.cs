﻿using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private Animator _anim;

    public const string PUSH_BUTTON_ANIMATION = "ButtonPush";

    void Awake()
    {
        BakeReferences();
    }
    public void BakeReferences ()
    { 
        _anim = GetComponent<Animator>(); 
    }   
    public void SetWalkAnimation(float velocity)
    {
        _anim.SetFloat(PlayerAnimationConstants.PLAYER_VELOCITY_ANIMATION_HASH, velocity);
    }
    public void RingBell()
    {
        _anim.Play(PlayerAnimationConstants.PLAYER_PUNCH_BELL_ANIMATION_HASH);
    }
    public void CallHerd()
    {
        _anim.Play(PlayerAnimationConstants.PLAYER_ATTRACT_HERD_ANIMATION_HASH);
    }
    public void Death()
    {
        _anim.Play(PlayerAnimationConstants.PLAYER_DEATH_ANIMATION_HASH);
    }
    public void PushButton()
    {
        _anim.Play(PlayerAnimationConstants.PLAYER_BUTTON_PUSH_ANIMATION_HASH);
    }
}
