using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool hasEndGame = false;

    public Rotator rotator;
    public Spawner spawn;

    public void endGame()
    {
        if (hasEndGame)
        {
            return;
        }

        rotator.enabled = false;
        spawn.enabled = false;

        hasEndGame = true;

    }
}
