using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    [SerializeField] public Sprite[] frameArray;
    public int currentFrame;
    public float timer;
    public float framerate = 0.1f;
    public SpriteRenderer sp;
    public int skinSlot;

    public Sprite[] birdArray;

    // Start is called before the first frame update
    void Awake()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        skinSlot = 1;
    }
    public void Start()
    {
        birdArray = Resources.LoadAll<Sprite>("flying-creature-cycle-skin");
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= framerate)
        {
            timer -= framerate;
            currentFrame = (currentFrame + 1) % frameArray.Length;
            sp.sprite = frameArray[currentFrame];
        }
    }

    public void ChangeSkin()
    {
        if (skinSlot == 0)
        {
            frameArray[0] = Resources.Load<Sprite>("flappy_dragon_1");
            frameArray[1] = Resources.Load<Sprite>("flappy_dragon_2");
            frameArray[2] = Resources.Load<Sprite>("flappy_dragon_3");
            skinSlot = 1;
        }
        else if (skinSlot == 1)
        {
            frameArray[0] = Resources.Load<Sprite>("Tail1");
            frameArray[1] = Resources.Load<Sprite>("Tail2");
            frameArray[2] = Resources.Load<Sprite>("Tail3");
            skinSlot = 2;
        }
        else if(skinSlot == 2)
        {
            frameArray[0] = Resources.Load<Sprite>("Sword1");
            frameArray[1] = Resources.Load<Sprite>("Sword2");
            frameArray[2] = Resources.Load<Sprite>("Sword3");
            skinSlot = 3;
        }
        else if (skinSlot == 3)
        {
            frameArray[0] = Resources.Load<Sprite>("DragonTile0");
            frameArray[1] = Resources.Load<Sprite>("DragonTile1");
            frameArray[2] = Resources.Load<Sprite>("DragonTile2");
            skinSlot = 4;
        }
        else if (skinSlot == 4)
        {
            frameArray[0] = Resources.Load<Sprite>("rocket1");
            frameArray[1] = Resources.Load<Sprite>("rocket2");
            frameArray[2] = Resources.Load<Sprite>("rocket3");
            skinSlot = 5;
        }
        else if (skinSlot == 5)
        {
            frameArray[0] = Resources.Load<Sprite>("stelle_flappy");
            frameArray[1] = Resources.Load<Sprite>("stelle_flappy");
            frameArray[2] = Resources.Load<Sprite>("stelle_flappy");
            skinSlot = 6;
        }
        else if (skinSlot == 6)
        {
            frameArray[0] = Resources.Load<Sprite>("Yellowbird-downflap");
            frameArray[1] = Resources.Load<Sprite>("Yellowbird-midflap");
            frameArray[2] = Resources.Load<Sprite>("Yellowbird-upflap");
            skinSlot = 7;
        }
        else if (skinSlot == 7)
        {
            frameArray[0] = Resources.Load<Sprite>("bird1");
            frameArray[1] = Resources.Load<Sprite>("bird2");
            frameArray[2] = Resources.Load<Sprite>("bird3");
            skinSlot = 8;
        }
        else if (skinSlot == 8)
        {
            frameArray[0] = birdArray[0];
            frameArray[1] = birdArray[1];
            frameArray[2] = birdArray[6];
            skinSlot = 0;
        }
    }
}