using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cam_Controller : MonoBehaviour
{
    [SerializeField] private Transform Player_Body;
    [SerializeField] private Transform Player_Cam_AxisY;
    [SerializeField] private Transform Player_Cam_AxisX;
    [SerializeField] private Player_Cam_Rotater m_Player_Cam_Rotater;

    void Start() {
        m_Player_Cam_Rotater.Init(Player_Cam_AxisY, Player_Cam_AxisX);
    }

    void Update() {
        //3인칭 카메라 회전
        m_Player_Cam_Rotater.LookRotation(Player_Cam_AxisY, Player_Cam_AxisX);
        //카메라가 플레이어 바디 따라다님
        Player_Cam_AxisY.position = Player_Body.position + (Vector3.up * 3);
        
    }
}