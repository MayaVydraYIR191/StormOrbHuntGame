using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();
    }
}
