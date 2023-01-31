using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitter : MonoBehaviour
{
    public void Quit_func()
    {
        Debug.Log("quit !");
        Application.Quit();
    }
}
