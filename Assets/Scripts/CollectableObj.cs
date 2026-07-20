using Unity.VisualScripting;
using UnityEngine;

public class CollectableObj : MonoBehaviour
{
    public AudioSource sound;
    public GM gm;
    public GameObject sparks;
    public bool rune;
    public int scoreValue;
    public float rotateSpeed;
    public float yMax; //.5
    public float yMin; //.3
    public float speed;
    public float bobRange = .2f;
    public float startY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GM>();
        startY = transform.position.y;
        //sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        float time = Mathf.PingPong(Time.time * speed, 1);
        float y = Mathf.Lerp(startY + bobRange, startY - bobRange, time);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        
        //transform.position = Vector3.Lerp(new Vector3(transform.position.x, yMax, transform.position.z),
                                          //new Vector3(transform.position.x, yMin, transform.position.z),
                                          //time);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.LogError("TREASURE FOUND!");
            sound.Play();
            if (rune)
            {
                gm.totalRunes++;
                this.gameObject.GetComponent<MeshRenderer>().enabled = false;
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                sparks.SetActive(false);
            } else
            {
                gm.totalStars++;
                this.gameObject.GetComponent<MeshRenderer>().enabled = false;
                this.gameObject.GetComponent<MeshCollider>().enabled = false;
            }
                
            //gm.gameObject.GetComponent<Spawner>().spawnCount--;

            //this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            //this.gameObject.GetComponent<MeshCollider>().enabled = false;
            //StartCoroutine(WaitAndDestroy());
        }
    }


    }
