using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("移動速度"),Range(1f,100f),Tooltip("控制小雞移動速度")]
    public float speed = 10f;

    [Header("跳躍高度"),Range(1, 1000), Tooltip("控制小雞跳躍高度")]
    public int jump = 100;

    [Header("跳躍高度"),  Tooltip("控制小雞談話內容")]
    public string talk="咕咕咕";
    
    [Header("是否取得雞蛋"), Tooltip("控制小雞擁有雞蛋")]
    public bool egg = true;

    private void Start ()
    { 
        print("遊戲開始");
        
    }

    private void Update()
    {
       
        print(talk);
    }
}
