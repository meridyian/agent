using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
     
    private float health;
    public Image healthbar;
    public GameObject[] points;
    


    void Start()
    {
        health = 100;
        //healthbar.fillAmount -= .1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointButtons(int indexvalue)
    {
        //noktalara göre butonlar index taşısın
        points[indexvalue].GetComponent<MeshRenderer>().enabled = true;
        Debug.Log(indexvalue);

    }




}
