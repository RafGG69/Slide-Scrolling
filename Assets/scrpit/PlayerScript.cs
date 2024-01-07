using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PlayerScript : MonoBehaviour
{
    
    public static PlayerScript instance;
    public GameObject popup;
    public float jumpforce;
    float score;
    public TextMeshProUGUI displayscore;
    
    
    Rigidbody2D rb;
    public Text scoretext;

    [SerializeField]
    bool isgrounded = false;
 
   public bool isalive = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
        instance = this;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isgrounded == true)
            {
                rb.AddForce(Vector2.up * jumpforce);
                isgrounded = false;
            }
        }
        if (isalive)
        {
            score += Time.deltaTime *2;
            scoretext.text = "score : " + score.ToString("F2");
        }
        Time.timeScale = 1;
        
        showscore();

    }

    void showscore ()
    {
        if (isalive == false)
        {
            Debug.Log("dead");
            displayscore.text = score.ToString("F2");
        }
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isgrounded == false)
            {
                isgrounded = true;
            }
        }

        if (collision.gameObject.CompareTag("spike"))
        {
            // Destroy(gameObject);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            isalive = false;
            Time.timeScale = 0;
            popup.SetActive(true);
        }

    }
}
