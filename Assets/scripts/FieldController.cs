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
        Play selectedPlay = GameController.Instance.GetSelectedPlay();
    }
}
