using UnityEngine;

[CreateAssetMenu(fileName = "new Player Config", menuName = "Card Game/Player Configuration")]
public class PlayerConfig : ScriptableObject {
    public string username;

    public bool bugSelected = false;
    public bool dragonSelected = false;

    public bool redSelected = false;
    public bool blueSelected = false;
    public bool purpleSelected = false;
}
