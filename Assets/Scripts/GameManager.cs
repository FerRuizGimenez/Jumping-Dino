using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreTxt;

    public float score;

    void Update()
    {
        score += Time.deltaTime * 100;
        scoreTxt.text = score.ToString("000000");
    }
}
