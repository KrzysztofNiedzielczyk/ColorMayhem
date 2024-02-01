using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    [SerializeField] private GameObject exitMenu;
    private bool objectState = false;
    public AudioSource gameMusic;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitMenu.SetActive(!objectState);
            UpdateState();
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void UpdateState()
    {
        objectState = !objectState;
        ChangeMusic();
        ChangeTime();
    }

    public void ChangeMusic()
    {
        gameMusic.pitch = objectState == false ? 1.0f : 0.7f;
    }

    public void ChangeTime()
    {
        Time.timeScale = objectState == false ? 1.0f : 0.5f;
    }
}
