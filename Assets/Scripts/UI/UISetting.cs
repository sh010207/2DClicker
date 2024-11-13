using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISetting : MonoBehaviour
{
    public GameObject settingWindow;
    public TextMeshProUGUI currentClickCountText;
    public TextMeshProUGUI currentGoldCountText;

    private void Update()
    {
        currentClickCountText.text = $"{GoodsManager.Instance.playerClickCount}M";
        currentGoldCountText.text = $"{GoodsManager.Instance.playerGold}G";
    }
    public void OnSettingWindow()
    {
        Time.timeScale = 0.0f;
        settingWindow.SetActive(true);
    }

    public void OnRetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }

    public void OnMenuButton()
    {
        SceneManager.LoadScene(1);
    }   
    
    public void OnResumeButton()
    {
        Time.timeScale = 0.0f;
        settingWindow.SetActive(false);
    }

    public void OnMainSceneButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
