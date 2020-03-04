﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int Health = 100;

    public void ApplyDamage(int amount)
    {
        Health -= amount;

        if (Health <= 0)
            KillCharacter();
    }

    public virtual void KillCharacter()
    {
    }
}
