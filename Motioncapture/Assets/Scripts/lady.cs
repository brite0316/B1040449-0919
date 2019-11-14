
using UnityEngine;

public class lady : MonoBehaviour
{
    private Animator ani;       //動畫元件
    private Rigidbody rig;      //剛體元件

    [Header("速度"), Range(0f, 80f)]
     public float speed = 1.5f;

    [Header("動畫控制器:參數名稱")]
    public string parRun = "走路開關";
    public string parAtk = "攻擊觸發";
    public string parDam = "受傷觸發";
    public string parjump = "跳躍觸發";
    public string parDead = "死亡開關";


    private void Start()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Walk();
        Attack();
        Jump();
    }
    //定義方法
    //修飾詞 傳回類型 方法名稱 (參數) (敘述)
    //woid 無回傳

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        ani.SetBool(parRun,Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0);
        //rig.AddForce(0 , 0, Input.GetAxisRaw("Vertical") * speed)://以世界座標移動
        rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * speed);
    }

    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {
         if (Input.GetKeyDown(KeyCode.Mouse0))
            ani.SetTrigger(parAtk);
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ani.SetTrigger(parjump);
    }

    /// <summary>
    /// 受傷
    /// </summary>
    private void Hurt()
    {
        ani.SetTrigger(parDam);
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        ani.SetBool(parDead, true);
    }
}
