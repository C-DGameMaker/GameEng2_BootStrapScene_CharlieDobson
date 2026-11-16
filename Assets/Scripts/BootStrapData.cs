using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using NUnit.Framework.Constraints;

public static class PreformBootstrap
{
    const string SceneName = "BootStrapScene";

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Execute()
    {
        for (int sceneIndex = 0; sceneIndex < SceneManager.sceneCount; sceneIndex++)
        {
            var canidate = SceneManager.GetSceneAt(sceneIndex);

            if (canidate.name == SceneName)
            {
                return;
            }
        }

        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
    }
}

public class BootStrapData : MonoBehaviour
{
    public static BootStrapData Instance { get; private set; } = null;

    public GameStateManager gameStateManager;
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("Found Bootstrap Data on " + gameObject.name);
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        if(gameStateManager == null)
        {
            GameObject obj = new GameObject("GameStateManager", typeof(GameStateManager));
            gameStateManager = obj.GetComponent<GameStateManager>();
            DontDestroyOnLoad(gameStateManager);
        }
        gameStateManager.SetGameStates(GameStates.init);
       
    }

    public void Test()
    {
        Debug.Log("Bootstrap Sucessful");
    }
}
