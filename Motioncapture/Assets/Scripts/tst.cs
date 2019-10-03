using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tst : MonoBehaviour
{ 
    [Header("分數")]
    [Range(0, 100)]
	public int score = 65;
    [Header("速度"), Range(1.5f, 10f)]
    public float speed = 1.5f;
   [Header("道具"),Tooltip("可以放紅色藥水與藍色藥水")]
    public string prop = "藥水";
    [Header("任務"),]
    public bool mission = false;

    public Vector2 v2 = new Vector2(7, 77);
    public Vector3 v3= new Vector3(1, 2, 3);

    public Color blue = Color.blue;
    public Color red = new Color(0.7f, 0.1f, 0.2f);

    public AudioClip sound;
    public Camera cam;
    public Light lig;
    public Transform camPos;
    public GameObject obj;
    public Debug deb;
}
