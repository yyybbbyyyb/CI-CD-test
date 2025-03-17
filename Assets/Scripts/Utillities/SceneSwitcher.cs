using UnityEngine;
using UnityEngine.SceneManagement ;
public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 加载 01.Field 场景 
        SceneManager.LoadScene ( "01.Field", LoadSceneMode.Additive) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
