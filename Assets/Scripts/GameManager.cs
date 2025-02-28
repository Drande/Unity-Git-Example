using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;} 
    
    private void Awake() {
        if(Instance != null)
        {
            Destroy(this.gameObject);
        }else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
