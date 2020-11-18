using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayeController15 : MonoBehaviour
{
    float speed = 5.00f;
    public GameObject CoinCollected;
    int CoinCount;
    private int totalCoin;

    // Start is called before the first frame update
    void Start()
    {
        CoinCollected.GetComponent<Text>().text = "Coin Collected: " + CoinCount.ToString("0");
        totalCoin = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        //CoinCollected = GameObject.FindGameObjectsWithTag("Coin").Length;
        CoinCollected.GetComponent<Text>().text = "Coin Collected: " + CoinCount.ToString("0");
        Debug.Log("Total Coins LEFT: " + CoinCount.ToString("0"));

        if (CoinCount == totalCoin)
        {
            Debug.Log("Going OVER to new SCENE NOW when ALL Coin are collected!!");
            SceneManager.LoadScene("YouWin");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 10.00f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5.00f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            CoinCount++;
            CoinCollected.GetComponent<Text>().text = "Coin Collected: " + CoinCount.ToString("0");
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("YouLose"))
        {
            SceneManager.LoadScene("YouLose");
        }
    }
}
