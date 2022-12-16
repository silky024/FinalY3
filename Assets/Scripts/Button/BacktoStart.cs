using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoStart : MonoBehaviour
{
    public void BackStart()
    {
        SceneManager.LoadScene(0);
    }
}
