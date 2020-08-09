using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickup : MonoBehaviour
{

    public Text CountText;
    public GameObject WinMenuUI;

     public GameObject EggExplosion;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText ();
        EggExplosion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      private void OnTriggerEnter(Collider other) //Picks up items labled with tag 'Pick Up'
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive (false);
                EggExplosion.SetActive(true);

                FindObjectOfType<AudioManager>().Play("EggPickup");

                count = count + 1;
                SetCountText ();
            }
        }

        void SetCountText ()
        {
            CountText.text = "Count: " + count.ToString ();
            if (count >= 10)
            {
                WinMenuUI.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true; 
            }

        }


    
}
