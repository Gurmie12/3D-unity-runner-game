using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float waitTime = 2f;

    public GameObject completeLevelUI;
   public void EndGame()
   {
       if (gameHasEnded == false)
       {
           gameHasEnded = true;
           Invoke("Restart",waitTime);
       }
   }

   void Restart()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void WinGame()
   {
       completeLevelUI.SetActive(true);
   }
}
