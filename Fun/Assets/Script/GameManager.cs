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

        int rand = Random.Range(0, 4);
        

        deltaTime = GetComponent<AudioSource>().time - lastTime;
        timer += deltaTime;

        if (timer >= (60f / bpm))
        {

            //Create the tile 
            var x = Instantiate(tiles, spawners[rand]);
            timer -= (60f / bpm);


            memo.Add(rand);


            foreach (int items in memo) {

              // Debug.Log(items);

                if ((int)Positions.middleleft == items) {

                   Debug.Log("Found it ");

                
                }

            }
           
            
        }


        lastTime = GetComponent<AudioSource>().time;


    }




}
