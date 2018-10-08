using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    public GameObject container;
    RectTransform RTcontainer;
    public bool isopen;

	// Use this for initialization
	void Start () {
        isopen = false;
        RTcontainer = container.GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 scale = RTcontainer.localScale;
        scale.y = Mathf.Lerp(scale.y, isopen ? 1 : 0, Time.deltaTime * 12);
        RTcontainer.localScale = scale;

        if (scale.y < 0.01)
            container.SetActive(false);
        else if (scale.y > 0)
            container.SetActive(true);
    }

    public void PressStart()
    {
        if (!isopen)
            isopen = true;
        else if (isopen)
            isopen = false;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
