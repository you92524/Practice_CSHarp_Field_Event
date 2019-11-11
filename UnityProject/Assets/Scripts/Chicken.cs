using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("移動速度"), Range(1, 100)]
    public float speed = 10;
    [Header("跳躍高度"), Range(50, 2000)]
    public int jump = 200;
    [Header("對話內容")]
    public string talk = "咕咕咕~~~";
    [Header("是否取得雞蛋")]
    public bool egg = false;

    private void Start()
    {
        print("遊戲開始!!!");
    }

    private void Update()
    {
        print(talk);
    }
}
