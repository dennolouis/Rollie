using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
public class Chase : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    private void Update() {
        enemy.SetDestination(Player.position);
    }




}   
