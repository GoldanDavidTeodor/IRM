using UnityEngine;
using TMPro; 

public class Target : MonoBehaviour
{
    public int baseScore = 10;
    public Transform throwOrigin;
    public TMP_Text scoreText; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Throwable"))
        {
            float distance = Vector3.Distance(throwOrigin.position, other.transform.position);
            int finalScore = Mathf.Max(0, Mathf.RoundToInt(baseScore - distance));

            if (scoreText != null)
            {
                scoreText.text = "Scor: " + finalScore;
            }

        }
    }
}
