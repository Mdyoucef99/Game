using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        code.AddPoints();
        Destroy(gameObject);
       
    }

    void OnCollisionEnter2d(Collision collision) {

        if (collision.gameObject.CompareTag("DeathZone"))
        {
            Debug.Log("Deathzone entered");
        }

    }





}
