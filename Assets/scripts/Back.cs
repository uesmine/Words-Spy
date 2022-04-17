using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Back : MonoBehaviour
{
    public void Return()
        {
            SceneManager.LoadScene("MainMenu");
        }
}
