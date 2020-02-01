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




    // Start is called before the first frame update
    void Start()
    {
     
        
    }

     void Awake()
    {
        Instantiate(tiles, spawners[Random.Range(0, 3)]);
    }



    // Update is called once per frame
    void Update()
    {

      //  Invoke("Spawn", 3);//intantiate a all tiles after 3 seconds 

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
