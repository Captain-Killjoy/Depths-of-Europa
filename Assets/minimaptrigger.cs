using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minimaptrigger : MonoBehaviour
{

    public GameObject minimapblock;
    public GameObject pinger;
    public Text changeCount;
    public int count;
  

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "Player"))
        {
            minimapblock.SetActive (false);

        }
    }


}