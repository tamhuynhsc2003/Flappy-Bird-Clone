using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Transform SpikePF;
    public Vector2 spawnPoint;
    public Vector2 spawnPoint2;
    public float delay = 2.5f;
    //public float score = 0f;
    //public float highscore = 0f;
    //public float step = 0f;
    public float getThroughSpace;
    public bool turnFX = false;
    //public Text scoreText;
    //public Text highscoreText;
    //public Text stepText;
    public Text overText;
    public Text diffText;
    public Text fpsText;
    public GameObject GameOverMenu;
    public GameObject detailedMenu;
    public GameObject hitbox;
    GameObject pillarTransform;
    GameObject pillarTransform2;
    public AudioClip[] listBGM;
    public AudioSource BGM;
    public int pickedSound = 1;

    //public float currentFPS;
    //public FrameRateManager fpsManager;

    public void StartGame()
    {
        StartCoroutine(SpawnPillar());
        ScoreManager.instance.OnReloadClicked();
    }

    IEnumerator SpawnPillar()
    {
        yield return new WaitForSeconds(delay);
        getThroughSpace = Random.Range(5.5f, 6.5f);
        spawnPoint = new Vector2(3f, Random.Range(-1.5f, -5.5f));
        spawnPoint2 = new Vector2(3f, spawnPoint.y + getThroughSpace);

        pillarTransform = ObjectPoolManager.instance.GetPooledObject();
        pillarTransform.transform.rotation = Quaternion.identity;
        pillarTransform.SetActive(true);
        pillarTransform2 = ObjectPoolManager.instance.GetPooledObject();
        pillarTransform2.transform.rotation = Quaternion.Euler(180, 0, 0);
        pillarTransform2.SetActive(true);
        pillarTransform.transform.position = spawnPoint;
        pillarTransform2.transform.position = spawnPoint2;
        StartCoroutine(SpawnPillar());
    }

    public void turnOnFX()
    {
        if (turnFX == true)
        {
            turnFX = false;
        }
        else
        {
            turnFX = true;
        }   
    }
    public void turnOnDetailed()
    {
        if (detailedMenu.activeSelf == true)
        {
            detailedMenu.SetActive(false);
        }
        else
        {
            detailedMenu.SetActive(true);
        }
    }
    public void turnOnHitbox()
    {
        if (hitbox.activeSelf == true)
        {
            hitbox.SetActive(false);
        }
        else
        {
            hitbox.SetActive(true);
        }
    }
    public void DiffControl()
    {
        if (delay == 2f)
        {
            delay = 1.5f;
            diffText.text = "Hard";
        }
        else
        {
            delay = 2f;
            diffText.text = "Easy";
        }
    }

    public void toggleMusic()
    {
        BGM.mute = !BGM.mute;
    }
    public void ChangeMusic()
    {
        if(pickedSound == 1)
        {
            BGM.clip = listBGM[0];
            BGM.Play();
            pickedSound = 2;
        }else if(pickedSound == 2)
        {
            BGM.clip=listBGM[1];
            BGM.Play();
            pickedSound = 3;
        }
        else if (pickedSound == 3)
        {
            BGM.clip = listBGM[2];
            BGM.Play();
            pickedSound = 1;
        }
    }
}
