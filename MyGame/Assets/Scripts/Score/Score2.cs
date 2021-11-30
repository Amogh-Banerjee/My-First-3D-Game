using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{

    public Transform player;
    public Text label;
    private float distance;
    // Update is called once per frame
    void Update()
    {
        if (player.position.x <= 36)
        {
            distance = 36-player.position.x;
        label.text = distance.ToString("0");
        }
        
    }
    
}
