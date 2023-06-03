using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void Next(int level)
    {
        SceneManager.LoadSceneAsync(level);
    }

    public void Finish(GameObject finishPanel)
    {
        finishPanel.gameObject.SetActive(true);
    }
}
