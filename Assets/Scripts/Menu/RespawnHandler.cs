using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnHandler : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject Camera;
    public GameObject GameOverScreen;
    public Vector3 RespawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Respawner")
        {
            gameObject.tag = "GameController";
            RespawnPlayer();
        }
    }

    private void RespawnPlayer()
    {
        GameObject newPlayer = Instantiate(PlayerPrefab,RespawnPos,Quaternion.identity);
        //newPlayer.GetComponent<PlayerBehaviour>().GameOverScreen = GameOverScreen;
        Camera.GetComponent<CameraFollow>().target = newPlayer.transform;
        GameOverScreen.SetActive(false);
    }

}
