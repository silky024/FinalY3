using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryButton : MonoBehaviour
{
    public void ToInvent()
    {
        SceneManager.LoadScene(1);
    }
}
