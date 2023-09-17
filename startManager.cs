using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMAnager : MonoBehaviour
{   
    public GameObject startScene;
    public GameObject introduction;
    public GameObject cupgame;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DalayTime(2));
        introduction.SetActive(false);

    }

    IEnumerator DalayTime(float time)
    {
        yield return new WaitForSeconds(time);
        
        startScene.SetActive(false);
        introduction.SetActive(true);
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
