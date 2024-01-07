using UnityEngine;

public class spikegenerator : MonoBehaviour
{
    public GameObject spike;
    public float minspeed;
    public float maxspeed;
    public float currentspeed;
    public void Awake()
    {
        currentspeed = minspeed;
        generatespike();
    }
    
    public void randomspike()
    {
        float randomwait = Random.Range(0.1f,1.2f);
        Invoke("generatesipke",randomwait);
    }
    
    public void generatespike()
    {
        GameObject spikeInst = Instantiate(spike, transform.position,transform.rotation);
        spikeInst.GetComponent<spikescript>().spikegenerator = this;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
