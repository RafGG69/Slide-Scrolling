using UnityEngine;

public class spikescript : MonoBehaviour
{

    public spikegenerator spikegenerator;
    
    void Update()
    {
        if (PlayerScript.instance.isalive == true)
        transform.Translate(Vector2.left * spikegenerator.currentspeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            spikegenerator.generatespike();

        }
         if (collision.gameObject.CompareTag("end"))
        {
            Destroy(gameObject);

        }
    }
}
