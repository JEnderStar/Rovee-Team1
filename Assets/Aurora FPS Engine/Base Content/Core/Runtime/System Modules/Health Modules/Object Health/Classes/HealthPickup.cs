using AuroraFPSRuntime.SystemModules.HealthModules;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : ObjectHealth
{
    public float amount = 50;

    private void OnTriggerEnter(Collider other)
    {
        ObjectHealth health = other.GetComponent<ObjectHealth>();
        if (health)
        {
            health.Heal(amount);
            Destroy(gameObject);
        }
    }
}
