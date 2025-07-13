using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerAudio audio;
    [SerializeField] private Animator animator;
    [SerializeField] private BarManager bars;

    private void Update()
    {
        if (bars.IsSad())
        {
            Sadden();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Eat();
    }

    private void Eat()
    {
        animator.Play("Eat");
        bars.HaveLunch();
        audio.TripleBarking();
    }

    public void GetCaress()
    {
        animator.Play("Caress");
        bars.BeHappy();
        audio.OneBarking();
    }

    private void Sadden()
    {
        animator.Play("Sad");
        audio.Breath();
    }
}
