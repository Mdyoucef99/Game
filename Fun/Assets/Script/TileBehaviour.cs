using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehaviour : MonoBehaviour
{
   public  GameManager code;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BehaviourTile()
    {

        code.AddPoints();
        Destroy(gameObject);
        Debug.Log("destroyed self");
    }

   

}
