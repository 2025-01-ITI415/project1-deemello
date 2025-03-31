using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoalOrb : MonoBehaviour
{
    public TextMeshProUGUI winText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Goal reached!");
            if (winText != null)
            {
                winText.gameObject.SetActive(true);
                winText.text = "You win!";
            }

            // Optional: Freeze player and stop spawner
            Time.timeScale = 0f;
        }
    }
}
