using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{


    public enum EnemyState
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }


    public EnemyState currentState;

    void Start()
    {
        currentState = EnemyState.Patroling;
    }


    void Update()
    {
        switch(currentState)
        {
            case EnemyState.Patroling:
                // do patroling stuff
                Debug.Log("Patroling");
                break;
            case EnemyState.Attacking:
                // do Attacking stuff
                Debug.Log("Attacking");
                break;
            case EnemyState.Chasing:
                // do Chasing stuff
                Debug.Log("Chasing");
                break;
            case EnemyState.Death:
                // do Death stuff
                Debug.Log("Death");
               break;  
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemyState.Attacking;
        }

    }
}
