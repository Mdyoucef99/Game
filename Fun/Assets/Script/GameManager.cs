using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject panelformemory;
    private static GameManager _instance;


    public int Points;
    public Transform[] spawners;
    public GameObject tiles;
    public float bpm;
    private float lastTime, deltaTime, timer;

    List<int> MyList = new List<int>();


    int answer = 0;
    int incrementor = 0;

    public GameObject Endgamepanel;





    public Text scoreTx;
    public Text highScore;



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
        
        Debug.Log(incrementor);
        scoreTx.text = Points.ToString();

        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();


    }

    void Update()
    {
        Spawn();
        HighScoreCalculator();
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

            var x = Instantiate(tiles, spawners[rand]);
            timer -= (60f / bpm);

        }

        ///instantiate tiles for as long as the song goes. 
        lastTime = GetComponent<AudioSource>().time;

        if (GetComponent<AudioSource>().isPlaying == false) {

            StopTime();

        }

    }

    public void StopTime()
    {
        panelformemory.SetActive(true);
        Time.timeScale = 0;

        if (incrementor == 4) {

            Endgamepanel.SetActive(true);

        }

    }

    public void button1() {

         answer = 0;

        if (MyList.ElementAt(incrementor) == answer)
        {

            Debug.Log("good answer ");
            incrementor++;

        }

        else if (MyList.ElementAt(incrementor) != answer)
        {

            Debug.Log("incorect  answer ");
            incrementor++;

        }

        Debug.Log(incrementor);

    }

    public void button2()
    {
         answer = 1;

        if (MyList.ElementAt(incrementor) == answer)
        {

            Debug.Log("good answer ");
            incrementor++;

        }

        else if (MyList.ElementAt(incrementor) != answer)
        {

            Debug.Log("incorect  answer ");
            incrementor++;

        }

        Debug.Log(incrementor);

    }

    public void button3()
    {
         answer = 2;

        if (MyList.ElementAt(incrementor) == answer)
        {

            Debug.Log("good answer ");
            incrementor++;

        }



        else if (MyList.ElementAt(incrementor) != answer)
        {

            Debug.Log("incorect  answer ");
            incrementor++;

        }

        Debug.Log(incrementor);

    }


    public void button4()
    {
         answer = 3;

        if (MyList.ElementAt(incrementor) == answer)
        {

            Debug.Log("good answer ");
            incrementor++;

        }

        else if (MyList.ElementAt(incrementor) != answer)
        {

            Debug.Log("incorect  answer ");
            incrementor++;

        }

        Debug.Log(incrementor);

    }


    public int  PointsCalculator() {

       return Points++;
    }

    public void HighScoreCalculator() {

        if (Points > PlayerPrefs.GetInt("HighScore", 0)) {

            PlayerPrefs.SetInt("HighScore", Points);
            highScore.text = Points.ToString();

        }
        

    }





}
