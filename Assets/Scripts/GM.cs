using UnityEngine;
using Harborview.GameTools;
using TMPro;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour, IGameState
{
    bool isPaused { get; set; }
    public GameObject pauseScreen;
    public int totalStars;
    public int totalRunes;
    public GameObject frontDoor;
    public TextMeshProUGUI starsText;
    public TextMeshProUGUI runeText;
    public int countRunes;
    public int countStars;

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
        countRunes = GameObject.FindGameObjectsWithTag("Rune").Length;
        countStars = GameObject.FindGameObjectsWithTag("Star").Length;
        //foreach (GameObject.FindGameObjectWithTag("Rune") in ) { countRunes++};

    }


    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }


    // Update is called once per frame
    void Update()
    {
        starsText.text = totalStars.ToString();
        runeText.text = totalRunes.ToString();
        RevealPrize();
    }

    void RevealPrize()
    {
        if (totalStars == countStars && totalRunes == countRunes)
        {
            frontDoor.SetActive(false);
        }
    }
}
