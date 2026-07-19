using UnityEngine;
using Harborview.GameTools;

public class GM : MonoBehaviour, IGameState
{
    bool isPaused { get; set; }
    public GameObject pauseScreen;
    public int totalStars;
    public int totalRunes;

    bool IGameState.IsPaused => isPaused;

    void IGameState.PauseGame()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseScreen.SetActive(false);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
