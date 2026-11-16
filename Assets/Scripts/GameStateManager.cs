using UnityEngine;

public enum GameStates
{
    init,
    mainMenu,
    gamePlay,
    paused,
    gameWin,
    gameOver,

}

public class GameStateManager : MonoBehaviour
{
    [Header("Game States")]

    public GameStates currentState { get; private set; }
    public GameStates previousState { get; private set; }

    private void Start()
    {
        
    }
    public void SetGameStates(GameStates newState)
    {
        previousState = currentState;
        currentState = newState;

        SwitchGameStates(newState);
    }

    private void SwitchGameStates(GameStates switchedState)
    {
        switch (switchedState)
        {
            default:
                break;

            case GameStates.init:
                Debug.Log("Got here");
                SetGameStates(GameStates.mainMenu);
                break;

            case GameStates.mainMenu:
                break;

            case GameStates.gamePlay:
                break;

            case GameStates.paused:
                break;

            case GameStates.gameWin:
                break;

            case GameStates.gameOver:
                break;
        }

    }
}
