using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeckButton : MonoBehaviour
{
    public void ToDeck()
    {
        SceneManager.LoadScene(5);
    }
}
