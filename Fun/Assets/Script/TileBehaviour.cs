using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class TileBehaviour : MonoBehaviour
{
   public GameManager code;

   [SerializeField] float speed=500;

    


    // Start is called before the first frame update

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

    }

    public void BehaviourTile()
    {
        code.points++;
        Debug.Log(code.points);
        Destroy(gameObject);

    }

 
   
}
