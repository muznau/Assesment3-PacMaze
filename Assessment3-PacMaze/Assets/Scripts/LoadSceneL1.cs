using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneL1 : MonoBehaviour
{
    public void LevelButton(int build)
    {
        SceneManager.LoadScene(build);
    }

    public void LevelButton(string name)
    {
        SceneManager.LoadScene(name);
    }
}
