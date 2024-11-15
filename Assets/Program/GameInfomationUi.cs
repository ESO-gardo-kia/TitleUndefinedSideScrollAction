using UnityEngine;
using UnityEngine.UI;

public class GameInfomationUi : MonoBehaviour
{
    [SerializeField] Text timeUi;
    [SerializeField] GameObject clearPanel;
    [SerializeField] GameObject gameOverPanel;
    void Start()
    {
        clearPanel.SetActive(false);
        gameOverPanel.SetActive(false);
    }

    void Update()
    {

    }
    public void SetClear()
    {
        clearPanel.SetActive(true);
    }
    public void SetGameOver()
    {
        gameOverPanel.SetActive(true);
    }
    public void SetText(float time,float limit)
    {
        timeUi.text = "TIME:" + Mathf.Ceil(time).ToString() + "/" + limit;
    }
}
