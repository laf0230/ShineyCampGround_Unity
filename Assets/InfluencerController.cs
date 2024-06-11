using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluencerController : MonoBehaviour
{
    public enum CharacterState
    {
        Idle,
        Move,
        Building,
        Packing,
        Exit,
        Talk
    }

    public CharacterState currentState;

    Rigidbody rigid;
    public SOMovePointList movePoint_SO;
    public List<GameObject> waypoints;
    bool isStateComplete = true;
    bool isGoal;
    int movePointIndex = 0;

    private void Start()
    {
        currentState = CharacterState.Idle;
        rigid = GetComponent<Rigidbody>();
        waypoints = movePoint_SO.WayPoints;
    }

    public void StartState()
    {
        switch (currentState)
        {
            case CharacterState.Idle:

                break;
            case CharacterState.Move:
                MoveTo(waypoints[movePointIndex].transform.position);
                movePointIndex++;
                break;
            case CharacterState.Building:
                break;
            case CharacterState.Packing:
                break;
            case CharacterState.Exit:
                break;
            case CharacterState.Talk:
                break;
        }
    }

    public void MoveTo(Vector3 targetLocation)
    {
        while (!isGoal)
        {
        Vector3 direction = targetLocation - transform.position;
        rigid.velocity = direction * Time.deltaTime;
        }
    }
}
