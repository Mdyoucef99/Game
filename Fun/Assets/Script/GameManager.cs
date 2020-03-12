using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private int HighScore;
    [SerializeField] int points=0;
    public Text scoreTx;
    public Transform[] spawners;
    public GameObject tiles;
    

    public float bpm;
    private float lastTime, deltaTime, timer;

    
    // float i = 0;


    void Start()
    {

     
    }


   
    void Update()
    {
        

    }



    public void AddPoints()
    {
        points += 1;
        Debug.Log(points);
        scoreTx.text = points.ToString();

    }


    private void Spawn()
    {
        int rand = Random.Range(0, 3);

        deltaTime = GetComponent<AudioSource>().time - lastTime;
        timer += deltaTime;

        if (timer >= (60f / bpm))
        {

            //Create the tile 
            var x = Instantiate(tiles, spawners[rand]);
            timer -= (60f / bpm);

        }

        lastTime = GetComponent<AudioSource>().time;

    }


}
