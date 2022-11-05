using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelCheckPoint : MonoBehaviour
{
    public int sceneIndex;
    public int CurrentLevel; //this is because we can verify by sceneindex, we need a seperate counter so we can make the bool to allow level true.  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider checkpoint){

        SceneManager.LoadScene(sceneIndex);
        LevelVerifyer.AllowLevels[CurrentLevel] = true; 


    }
}
