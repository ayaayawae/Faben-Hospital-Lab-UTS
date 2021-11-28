using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.Random;
using static UnityEngine.Random;


public class Movement : MonoBehaviour
{   string direction;
    int room;
    bool stop = false;
    bool begin = true;
    int onProgress = 3;
    bool firstTurnExit = false;
    int totalRoom = 9; // Ini 8
    public Text MoneyText;
    int MoneyValue;
    int MoneyPlus = 10;

    void Start()
    {
        room = Random.Range(1, totalRoom);
        transform.localPosition = new Vector3(-0.3009744f, 1.55f, -20.11f);
        transform.rotation = Quaternion.identity;
    }

    void Awake(){
        transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {   
        if(!stop && begin){
            transform.position += transform.forward * Time.deltaTime * 7;
        }

        if(!begin){
            transform.position += transform.forward * Time.deltaTime * 7;
        }
    }

    public void OnTriggerEnter (Collider col){
        if(!begin && !firstTurnExit){
            if(room  < 5){
                    transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
                }else{
                    transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                }
            firstTurnExit = true;
        }else{
            if(room.ToString() == col.gameObject.name){
                if(room  < 5){
                    transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
                }else{
                    transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
                }
            }else if (col.gameObject.name == "Stop"){
                stop = true;
                StartCoroutine(onDoctor());
                
            }
        }
    }

    IEnumerator onDoctor()
    {
        yield return new WaitForSeconds(onProgress);
        MoneyValue = int.Parse(MoneyText.text);
        MoneyValue += MoneyPlus;
        MoneyText.text = MoneyValue.ToString();
        transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        transform.position += -transform.forward;
        begin = false;
    }

    

    void FixedUpdate(){
        
    }
}
