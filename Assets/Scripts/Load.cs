using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    DontDestroy des;
    void Awake()
    {
        if (GameObject.Find("LoadCanvas"))
        {
            Destroy(GameObject.Find("LoadCanvas").gameObject);
        }
        if (FindObjectOfType<DontDestroy>())
            des = FindObjectOfType<DontDestroy>();
        else
        {
            DontDestroyOnLoad(des);
            GameController.CurrentTurn = "Player";
        }
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
