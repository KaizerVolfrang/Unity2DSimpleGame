using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarManager : MonoBehaviour
{
    [SerializeField] private Bar health;
    [SerializeField] private Bar happy;
    [SerializeField] private Bar food;
    [SerializeField] private Bar stroll;

    [SerializeField] private float maxTime = 5;
    private float currentTime;

    void Start()
    {
        currentTime = maxTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        Debug.Log(currentTime);

        if (currentTime <= 0)
        {
            GetTired();
            currentTime = maxTime;
        }
    }

    public bool IsSad()
    {
        return happy.GetValueBar() < 0.3f;
    }

    public void BeHappy()
    {
        happy.AddValueBar(0.3f);
    }

    public void Heal()
    {
        health.AddValueBar(0.5f);
    }

    public void HaveLunch()
    {
        happy.AddValueBar(0.05f);
        food.AddValueBar(0.25f);
    }

    private void GetTired()
    {
        health.AddValueBar(-0.05f);
        happy.AddValueBar(-0.1f);
        food.AddValueBar(-0.15f);
        stroll.AddValueBar(-0.05f);
    }



}
