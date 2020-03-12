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
    float spawnTime = 5.0f;


    float i = 0;




    // Start is called before the first frame update
    void Start()
    {
     
    }

     void Awake()
    {
      

       // InvokeRepeating("Spawn", 3.0f, 3.0f);

    }



    // Update is called once per frame
    void Update()
    {

        if (Time.time > i)
        {
            i += 0.8f;
            Spawn();

        }


    }



    public void AddPoints()
    {
        points += 1;
        Debug.Log(points);
        scoreTx.text = points.ToString();

    }


    private void Spawn()
    {
        Instantiate(tiles, spawners[Random.Range(0, 3)]);

    }





}
