using UnityEngine;
using UnityEngine.UI;

public class GameInfomationUi : MonoBehaviour
{
    [SerializeField] Text timeUi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetText(float time,float limit)
    {
        timeUi.text = "TIME:" + Mathf.Ceil(time).ToString() + "/" + limit;
    }
}
