
using UnityEngine;
using UnityEngine.UI;


public class Win : MonoBehaviour
{
    public GameObject LevelPanel;
    public Text MyText;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
                LevelPanel.SetActive(true);
                Time.timeScale = 0f;
            MyText.text = $"Вы выиграли !";

        }
    }
}
