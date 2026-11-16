using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BootStrapData.Instance.Test();
        Debug.Log(BootStrapData.Instance.gameStateManager.currentState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
