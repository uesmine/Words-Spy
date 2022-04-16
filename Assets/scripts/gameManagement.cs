using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManagement : MonoBehaviour
{
    public void playgame()
        {
            SceneManager.LoadScene("gamePlay");
        }
}
