using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    private enum Positions {left,middleleft, middleright, right }
    public List<int> memo= new List<int>();
    private static GameManager _instance;
    private int HighScore;
    [SerializeField] int points = 0;
    public Text scoreTx;
    public Transform[] spawners;
    public GameObject tiles;
    public float bpm;
    private float lastTime, deltaTime, timer;

    int[] test2 = new int[4];

   

    public static GameManager Instance 
    {

        get
        {
            //create logic to create the instance 
            if (_instance == null) 
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();

            }
            return _instance;

        }
    
    }

    private void Awake()
    {
        _instance = this;

    }


    void Start()
    {
        points = 0;

    }

    void Update()
    {
        Spawn();

    }

    public void AddPoints()
    {
        points += 1;
        Debug.Log(points);
        scoreTx.text = points.ToString();

    }


    private void Spawn()
    {
        ///ok so this work,  gotta change the tempo of the song 
        

        deltaTime = GetComponent<AudioSource>().time - lastTime;
        timer += deltaTime;
        ///calculate the bpm of the song and generate tiles 
        if (timer >= (60f / bpm))
        {
            int rand = Random.Range(0, 4);
            //Create the tile 
            var x = Instantiate(tiles, spawners[rand]);
            timer -= (60f / bpm);

            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = rand; 
                Debug.Log(test2[i]);
                rand = Random.Range(0, 4);

            }
            


        }

        ///instantiate tiles for as long as the song goes. 
        lastTime = GetComponent<AudioSource>().time;
        

    }
    

}
