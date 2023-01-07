using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTriggerScript : MonoBehaviour
{
    public enum typeTransition
    {
        toStatic,
        toMoving
    }
    public typeTransition trans;
    public CinemachineVirtualCamera[] Vcams;
    public Transform Player, toLook;
    public Transform pointToTepTo;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Vcams[0].Priority = 0;
        Vcams[1].Priority = 1;

        Player.position = pointToTepTo.transform.position;
        switch (trans)
        {
            case typeTransition.toStatic:
                Vcams[1].Follow = toLook;
                break;
            case typeTransition.toMoving:
                Vcams[1].Follow = Player;
                break;
            
        }
        
    }
}
