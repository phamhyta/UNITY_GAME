using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    public GameObject sphere;

    void Start() 
    {
        for(int i = 1; i <= 3; i++){
            Instantiate(sphere, new Vector3(Random.RandomRange(-8, 9), 0, Random.RandomRange(-9, 9)), Quaternion.identity);
            if(i == 1)      sphere.tag = "red";
            else if(i == 2) sphere.tag = "blue";
            else            sphere.tag = "green";
        }
    }

    void Update() 
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("red");
        gos[0].GetComponent<Renderer> ().material.color = Color.red;
        if(gos.Length > 1) gos[1].GetComponent<Renderer> ().material.color = Color.red;
        gos = GameObject.FindGameObjectsWithTag("blue");
        gos[0].GetComponent<Renderer> ().material.color = Color.blue;
        if(gos.Length > 1) gos[1].GetComponent<Renderer> ().material.color = Color.blue;
        gos = GameObject.FindGameObjectsWithTag("green");
        gos[0].GetComponent<Renderer> ().material.color = Color.green;
        if(gos.Length > 1) gos[1].GetComponent<Renderer> ().material.color = Color.green;
    }

}
