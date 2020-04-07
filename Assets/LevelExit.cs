using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelExit : MonoBehaviour
{

    void WhwnSomethingHappens()
    {
        StartCoroutine(TheThingThatHappens);
    }
    IEnumerator TheThingThatHappens
    {
        yield with a delay;

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);

        
    }
}
