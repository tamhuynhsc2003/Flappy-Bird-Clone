using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudControl : MonoBehaviour
{
    private SpriteRenderer sp;
    public int skinList;
    public Sprite newSprite1;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite oldSprite;

    void Start()
    {
        sp= GetComponent<SpriteRenderer>();
        skinList = 0;

    }

    public void ChangeBg()
    {
        if (skinList == 0 && sp != null)
        {
            sp.sprite = newSprite1;
            skinList = 1;
        }
        else if (skinList == 1)
        {
            sp.sprite = newSprite2;
            skinList = 2;
        }
        else if (skinList == 2)
        {
            sp.sprite = newSprite3;
            skinList = 3;
        }
        else if (skinList == 3)
        {
            sp.sprite = oldSprite;
            skinList = 0;
        }
    }
}
