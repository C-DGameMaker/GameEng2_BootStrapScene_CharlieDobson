using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public string loadSceneName;
   public void SceneLoad(string sceneName)
   {
        loadSceneName = sceneName;
        StartCoroutine(LoadingTime());
   }

    IEnumerator LoadingTime()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(loadSceneName);
        yield break;
    }
}
