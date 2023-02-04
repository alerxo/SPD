using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if(nextSceneIndex > SceneManager.sceneCount)
        {
            SceneManager.LoadScene(0);
        }

        else
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
