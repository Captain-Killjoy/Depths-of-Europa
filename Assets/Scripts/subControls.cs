using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class subControls : MonoBehaviour
{
    public Text changeCount;
    public int count;
    public Rigidbody rb;


    //Controls
    public float speed = 1f;
    public float torque;
    //private Transform selfTransform; 
	//float pitch;
	//public float pitchMax= 1f; 
    //public float turnRate = 1f;
    //public float decreaseRate = 1f;
    // Start is called before the first frame update
   public float moveSpeed = 1;
   public float rotateSpeed = 12;
   public GameObject pinger;
   public GameObject leavefield;

    AudioSource audioradar;

    void Start()
    {
  	    //selfTransform = transform;
        rb = GetComponent<Rigidbody>();   
        audioradar = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
    }
   void FixedUpdate () {
       
       float moveVector = Input.GetAxis("Vertical");
       float rotateVector = Input.GetAxis("Horizontal");

       this.transform.Translate(0f, -moveVector * moveSpeed * Time.deltaTime, 0f);
       this.transform.Rotate(0f, 0f, -rotateVector * (rotateSpeed * 10) * Time.deltaTime);

    
   }


    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "checkpoint"))
        {
            audioradar.Play();
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
        if (other.gameObject.CompareTag ( "nme"))
        {
        SceneManager.LoadScene(3);
        Debug.Log("Triggered");             
        }
    }

    void SetCountText ()
    {
        changeCount.text = "Areas Explored: " + count.ToString ();
        if (count >= 9)
        {
            changeCount.text = "Return to \n surface to \n transmit data!";
            pinger.SetActive (true);
            leavefield.SetActive (true);
        }
        
    }
}   


