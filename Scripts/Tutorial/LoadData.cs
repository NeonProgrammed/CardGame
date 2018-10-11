using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadData : MonoBehaviour {

    // ________PLAYER DATA LOAD_____________
    public PlayerConfig playerConfig;

    public string username;

    public bool bugSelected = false;
    public bool dragonSelected = false;

    public bool redSelected = false;
    public bool blueSelected = false;
    public bool purpleSelected = false;

    // _____SET UP PLAY FIELD_____
    public Transform redAttribute;
    public Transform blueAttribute;
    public Transform purpleAttribute;

    public Image playerGraphic;
    public Image enemyGraphic;

    public Sprite bugSprite;
    public Sprite dragonSprite;

    public Transform playerContainer;
    public Transform enemyContainer;


    public int creatureEnergy = 10;
    public int creatureAttack = 1;

    public TMP_Text energyCounter;
    public TMP_Text attack;

    void Awake() {
        // ________PLAYER DATA LOAD_____________
        SetData();
    }

    void Start() {
        // _____SET UP PLAY FIELD_____
        SetUp();
    }

    private void SetData()
    {
        username = playerConfig.username;

        bugSelected = playerConfig.bugSelected;
        dragonSelected = playerConfig.dragonSelected;

        redSelected = playerConfig.redSelected;
        blueSelected = playerConfig.blueSelected;
        purpleSelected = playerConfig.purpleSelected;
    }

    public virtual void SetUp()
    {
        // Setting up player graphic
        playerGraphic.sprite = null;
        if (bugSelected)
            playerGraphic.sprite = bugSprite;
        else if (dragonSelected)
            playerGraphic.sprite = dragonSprite;

        // Setting up player attribute
        if (redSelected)
            Instantiate(redAttribute, playerContainer);
        else if (blueSelected)
            Instantiate(blueAttribute, playerContainer);
        else if (purpleSelected)
            Instantiate(purpleAttribute, playerContainer);

        // Setting up creature state
        energyCounter.text = creatureEnergy.ToString();
        attack.text = creatureAttack.ToString();
    }
}
