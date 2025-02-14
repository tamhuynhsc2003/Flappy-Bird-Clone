using UnityEngine;

public class SpikeBase : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameHandler GH;
    public AudioSource ScoreSound;
    public float speed = 0.2f;
    void Start()
    {                          
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    { 
        Vector2 target = new Vector2(-8, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.deltaTime);
        rb.MovePosition(newPos);
        if (GH.GameOverMenu.activeSelf == true)
        {
            if (this.transform.position.y > -10)
            {
                gameObject.transform.Rotate(0, 0, 0);
                gameObject.SetActive(false);
                GH.StopAllCoroutines();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ScoreCount")
        {
            ScoreSound.Play();
            ScoreManager.instance.AddScore();
            //if (GH.score == 0 || GH.score == 1)
            //{
            //    nameText.text = "Thạch Hầu";
            //}
            //else if (GH.score == 10)
            //{
            //    nameText.text = "Bật Mã Ôn";
            //}
            //else if (GH.score == 20)
            //{
            //    nameText.text = "Mĩ Hầu Vương";
            //}
            //else if (GH.score == 30)
            //{
            //    nameText.text = "Tôn Ngộ Không";
            //}
            //else if (GH.score == 40)
            //{
            //    nameText.text = "Tôn Hành Giả";
            //}
            //else if (GH.score == 50)
            //{
            //    nameText.text = "Tề Thiên Đại Thánh";
            //}
            //else if (GH.score == 81)
            //{
            //    nameText.text = "Đấu Chiến Thắng Phật";
            //}
        }
        if (other.tag == "Finish")
        {
            gameObject.transform.Rotate(0, 0, 0);
            gameObject.SetActive(false);
        }
    }
}
