using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    private enum Positions {left,middleleft, middleright, right }
    private static GameManager _instance;
    private int HighScore;
    [SerializeField] int points = 0;
    public Text scoreTx;
    public Transform[] spawners;
    public GameObject tiles;
    public float bpm;
    private float lastTime, deltaTime, timer;

    int[] test2 = new int[4];

    List<int> MyList = new List<int>();
    int answer = 0;
    int incrementor = 0;

    public GameObject panelformemory;


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
        int rand = Random.Range(0, 4);
        
        deltaTime = GetComponent<AudioSource>().time - lastTime;
        timer += deltaTime;

        ///calculate the bpm of the song and generate tiles 
        if (timer >= (60f / bpm))
        {
            //Create the tile 

            MyList.Add(rand);

            foreach (var item in MyList)
            {
              //Debug.Log("this is the list + "+  MyList.ElementAt(0));
              //Debug.Log("this is the list + " + MyList.ElementAt(1));
              //Debug.Log("this is the list + " + MyList.ElementAt(2));
              //Debug.Log("this is the list + " + MyList.ElementAt(3));
            }


            var x = Instantiate(tiles, spawners[rand]);
            timer -= (60f / bpm);

            


        }
        ///instantiate tiles for as long as the song goes. 
        lastTime = GetComponent<AudioSource>().time;


    }


    public void StopTime()
    {

        
        panelformemory.SetActive(true);
        Time.timeScale = 0;


        if (incrementor == 4) {

            Time.timeScale = 1;
            Debug.Log("Game is finished ");
        }



    }

    public void button1() {

         answer = 0;

        if (MyList.ElementAt(0) == answer)
        {

            Debug.Log("good answer ");
            incrementor++;

        }

        else if (MyList.ElementAt(0) != answer)
        {

            Debug.Log("incorect  answer ");
            incrementor++;

        }


    }


    public void button2()
    {

         answer = 1;

        if (MyList.ElementAt(1) == answer)
        {

            Debug.Log("good answer ");
            incrementor++;

        }

        else if (MyList.ElementAt(1) != answer)
        {

            Debug.Log("incorect  answer ");
            incrementor++;

        }

    }

    public void button3()
    {

         answer = 2;

        if (MyList.ElementAt(2) == answer)
        {

            Debug.Log("good answer ");
            incrementor++;

        }

        else if (MyList.ElementAt(2) != answer)
        {

            Debug.Log("incorect  answer ");
            incrementor++;

        }

    }



    public void button4()
    {
         answer = 3;


        if (MyList.ElementAt(3) == answer)
        {

            Debug.Log("good answer ");
            incrementor++;

        }

        else if (MyList.ElementAt(3) != answer)
        {

            Debug.Log("incorect  answer ");
            incrementor++;

        }

    }






}
