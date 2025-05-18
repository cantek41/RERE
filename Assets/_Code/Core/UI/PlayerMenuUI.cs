using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMenuUI : _UIMenubase
{
    public GameObject canvas;
    public TextMeshProUGUI text;

    public void Show()
    {
        canvas.SetActive(true);
        base.ShowCanvas();
    }

  

    public void Reload()
    {
        //LevelManager.ReloadCurrentScene();

        GameObject[] objs = GameObject.FindGameObjectsWithTag("AlarmManager");
        foreach (var item in objs)
            Destroy(item);
    }

    public void Resume()
    {
        HideCanvas();
        canvas.SetActive(false);
    }

    public void Exit()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("AlarmManager");
        foreach (var item in objs)
            Destroy(item);
        SceneManager.LoadScene(1);
    }

}
