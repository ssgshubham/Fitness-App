using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenelod : MonoBehaviour
{
    public void scen0()
    {
        SceneManager.LoadScene(0);
    }

    public void scen1()
    {
        SceneManager.LoadScene(1);
    }

    public void scen2()
    {
        SceneManager.LoadScene(2);
    }
    public void train()
    {
        Application.OpenURL("https://vaibhav-c.github.io/healthy/train");
    }

    public void fun()
    {
        Application.OpenURL("https://vaibhav-c.github.io/healthy/fun");
    }

}
