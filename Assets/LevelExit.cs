using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelExit : MonoBehaviour
{
    //BoxCollider2D myCollider;
    [SerializeField] float LevelLoadDelay = 2f;
    [SerializeField] float LevelLoadSloMo = .2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Collided with Level Exit");
        StartCoroutine(LoadNextLevel());
    }
    
    IEnumerator LoadNextLevel()
    {
        Time.timeScale = LevelLoadSloMo;
        yield return new WaitForSecondsRealtime(LevelLoadDelay);
        Time.timeScale = 1f;
   

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        
    }

}
