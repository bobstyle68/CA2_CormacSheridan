using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int zombieAmount = 0;

    public GameObject zombie1, zombie2, zombie3, zombie4, zombie5, zombie6, zombie7, zombie8, zombie9, zombie10, zombie11, zombie12, zombie13, zombie14;
    void Awake()
    {

        if (zombie1 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie2 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie3 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie4 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie5 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie6 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie7 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie8 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie9 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie10 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie11 != null)
        {
            zombieAmount = zombieAmount + 1;
        }

        if (zombie12 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie13 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        if (zombie14 != null)
        {
            zombieAmount = zombieAmount + 1;
        }
        //do not remove
        DontDestroyOnLoad(this);
    }

    private void Update()
    {

        
    }

    public void RecordZombieHealth()
    {

        zombieAmount = zombieAmount - 1;
    }
}
