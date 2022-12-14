using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 1f;
    public Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.pinCount++;
            isPinned = true;

        }
        else if (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
