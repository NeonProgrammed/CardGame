using UnityEngine;
using TMPro;

public class SelectionManager : MonoBehaviour {
    public PlayerConfig playerConfig;

    public Transform augmentMenu;
    AugmentSelection augmentSelection;

    public Transform creatureMenu;
    CreatureSelection creatureSelection;

    public TMP_InputField username;

    private void Start () {

        augmentSelection = augmentMenu.GetComponent<AugmentSelection>();
        creatureSelection = creatureMenu.GetComponent<CreatureSelection>();

    }

    // Update is called once per frame
    void Update () {
        playerConfig.username = username.text;

        playerConfig.bugSelected = creatureSelection.bugSelected;
        playerConfig.dragonSelected = creatureSelection.dragonSelected;
        playerConfig.redSelected = augmentSelection.redSelected;
        playerConfig.blueSelected = augmentSelection.blueSelected;
        playerConfig.purpleSelected = augmentSelection.purpleSelected;
	}
}
