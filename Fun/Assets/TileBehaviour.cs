using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TileBehaviour : MonoBehaviour
{
    public Text scoretxt;
    public GameObject tile;
    public  int scoreint = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }


    public void Incrementor()
    {
        
        Debug.Log("pressed!!");
        Destroy(tile);
      



    }

}
