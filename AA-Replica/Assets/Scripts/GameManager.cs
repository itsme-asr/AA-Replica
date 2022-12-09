using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private bool hasEndGame = false;

    public Rotator rotator;
    public Spawner spawn;
    public Animator anim;

    public void endGame()
    {
        if (hasEndGame)
        {
            return;
        }

        rotator.enabled = false;
        spawn.enabled = false;
        anim.SetTrigger("EndGame");

        hasEndGame = true;

    }

    public void restatLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
