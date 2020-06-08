using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    void Start ()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    
    public void PlayGame () //This function loads the game
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
 }

public void QuitGame () //This function quits the game
 {
  Debug.Log ("QUIT!");
  Application.Quit();
 }


}
