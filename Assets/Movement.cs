using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private int score = 0;
    public bool IsStart = true;
    public MessScreen Screen;

    void Start() 
    {
        if(IsStart) Screen.SetActiveFalse();
        Screen.SetActiveFirst();
        var cubeRenderer = gameObject.GetComponent<Renderer>();
        float numberColor = Random.RandomRange(1, 4);
        if(numberColor == 1) {
            cubeRenderer.GetComponent<Renderer>().material.color = Color.red;
            gameObject.tag = "red";
        }
        else if(numberColor == 2) {
            cubeRenderer.GetComponent<Renderer>().material.color = Color.blue;
            gameObject.tag = "blue";
        }
        else{
            cubeRenderer.GetComponent<Renderer>().material.color = Color.green;
            gameObject.tag = "green";
        }
    }

    private void Move() 
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(transform.forward * speed * verticalInput * Time.deltaTime);
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(transform.right * speed * horizontalInput * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
        StartCoroutine(CoroutineDelayAction());
        Instantiate(other, new Vector3(Random.RandomRange(-8, 9), 0, Random.RandomRange(-9, 9)), Quaternion.identity);
        if(other.CompareTag(this.tag)) score ++;
        else    Screen.ScreenLoss();
        if(score == 10)     Screen.ScreenWin();
        Start();
    }

    IEnumerator CoroutineDelayAction()
    {
        yield return new WaitForSeconds(1);
    }

    void Update() 
    {
        if(IsStart)    Move();
    }
    
    public int getScore() 
    {
        return score;
    }
}
