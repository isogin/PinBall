using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private int score = 0;

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    private GameObject gameScoreText;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        this.gameScoreText = GameObject.Find("GameScore");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
            this.gameScoreText.GetComponent<Text>().text = this.score + "pt";
        }
        if(other.gameObject.tag == "LargeStarTag")
        {
            this.score += 30;
            this.gameScoreText.GetComponent<Text>().text = this.score + "pt";
        }
        if(other.gameObject.tag == "SmallCloudtag")
        {
            this.score += 20;
            this.gameScoreText.GetComponent<Text>().text = this.score + "pt";
        }
        if(other.gameObject.tag == "LargeCloudTag") 
        {
            this.score += 50;
            this.gameScoreText.GetComponent<Text>().text = this.score + "pt";
        }
    }
}
