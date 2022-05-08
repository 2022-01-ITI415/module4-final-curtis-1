using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectionUI : MonoBehaviour
{
    private TextMeshProUGUI ballText;
    // Start is called before the first frame update
    void Start()
    {
        ballText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBallText(PlayerCollection playerCollection)
    {
        ballText.text = playerCollection.NumberOfBalls.ToString();
    }
}
