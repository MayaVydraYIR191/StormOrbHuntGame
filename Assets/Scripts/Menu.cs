using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject loreTabe;
    [SerializeField] private GameObject howToPlayTabe;
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject exitButton;
    [SerializeField] private GameObject loreButton;
    [SerializeField] private GameObject howButton;
    
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void LoreTab()
    {
        loreTabe.SetActive(true);
        playButton.SetActive(false);
        exitButton.SetActive(false);
    }

    public void HowToPlayTab()
    {
        howToPlayTabe.SetActive(true);
        playButton.SetActive(false);
        exitButton.SetActive(false);
        loreButton.SetActive(false);
        howButton.SetActive(false);
    }

    public void CloseLore()
    {
        loreTabe.SetActive(false);
        playButton.SetActive(true);
        exitButton.SetActive(true);
        loreButton.SetActive(true);
        howButton.SetActive(true);
    }

    public void CloseHow()
    {
        howToPlayTabe.SetActive(false);
        playButton.SetActive(true);
        exitButton.SetActive(true);
        loreButton.SetActive(true);
        howButton.SetActive(true);
    }
}
