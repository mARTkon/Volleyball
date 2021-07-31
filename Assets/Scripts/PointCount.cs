using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
{
    public Text ScoreText;

    int Score = 0;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.name == "Ball")
        {
            Score++;
            ScoreText.text = Score.ToString();
        }
    }
}
