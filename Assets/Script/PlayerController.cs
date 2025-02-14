using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sp;
    public GameHandler GH;
    public Collider2D cl;
    public int skinList = 0;
    public float jump;
    public GameObject GameOverPanel;
    public GameObject TopWall;
    public GameObject KCBHtext;
    public Vector2 Origin = new Vector2(-1, -0.7f);
    public AudioSource TouchFX;

    public Text nameText;
    public bool invicible;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        cl = GetComponent<Collider2D>();
        invicible = false;
    }

    IEnumerator AutoJump()
    {
        yield return new WaitForSeconds(0.5f);
        Jump();
        StartCoroutine(AutoJump());
    }

    public void StartAutoJump()
    {
        StartCoroutine(AutoJump());
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jump);
        //GH.step += 1;
        if (GH.turnFX == true)
        {
            TouchFX.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Spike"&& invicible == false )
        {
            GameOverPanel.SetActive(true);
            TopWall.SetActive(false);
        }
        else if (other.tag == "Wall")
        {
            GameOverPanel.SetActive(true);
            TopWall.SetActive(false);
        }
    }

    public void ChangeTag()
    {
        if (cl.tag == "Player")
        {
            cl.tag = "Spike";
            invicible = true;
            KCBHtext.SetActive(true);
        }
        else
        {
            cl.tag = "Player";
            invicible = false;
            KCBHtext.SetActive(false);
        }
    }
    public void ResetPosi()
    {
        this.transform.position = Origin;
        ScoreManager.instance.ResetScore();
    }

}
