using UnityEngine;
using System.Collections;

public class FieldController : MonoBehaviour {

    public static FieldController Instance { get { return instance; } }
    private static FieldController instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            //LoadSounds();
        }
        else if (instance != null && instance != this)
        {
            Debug.Log("Deleting singleton Dup.  Someone screwed up");
            Destroy(gameObject);
            return;
        }
    }
    //public GameObject hazard;

    //public Vector3 spawnValues;
    //public int hazardCount;
    //public float spawnWait;
    //public float startWait;
    //public float waveWait;


    //void Start()
    //{
    //    StartCoroutine(SpawnWaves());
    //}

    //IEnumerator SpawnWaves()
    //{
    //    yield return new WaitForSeconds(startWait);

    //    while (true)
    //    {
    //        for (int i = 0; i < hazardCount; i++)
    //        {
    //            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
    //            Quaternion spawnRotation = Quaternion.identity;
    //            Instantiate(hazard, spawnPosition, spawnRotation);
    //            yield return new WaitForSeconds(spawnWait);
    //        }

    //        yield return new WaitForSeconds(waveWait);
    //    }
    //}

    public void Play()
    {
        RunSelectedPlay();

    }

    private void RunSelectedPlay()
    {
        Debug.Log("Running Play.");
        //Play selectedPlay = GameController.Instance.GetSelectedPlay();

        //Route[] routes = selectedPlay.routes;
        Player[] players = instance.GetComponentsInChildren<Player>();
        foreach (Player player in players){
            Rigidbody2D rigidBody = player.GetComponent<Rigidbody2D>();
            rigidBody.velocity = new Vector2(1, 0);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
