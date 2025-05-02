using UnityEngine;
using TMPro;

public class VictoryDisplay : MonoBehaviour
{
    public TextMeshProUGUI winText;

    void Start()
{
    Debug.Log("Winner read as: " + GameData.winnerName); // ดูว่าขึ้นไหม
    winText.text = GameData.winnerName + " Wins!";
}
}
