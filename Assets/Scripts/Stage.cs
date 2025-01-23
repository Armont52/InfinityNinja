using System.Collections.Generic;
using UnityEngine;

public abstract class Stage
{
    protected int minutes, seconds;
    protected int[] enemyList;
    protected Queue<int> enemyQueue;

    public int NextEnemy(){
        return enemyQueue.Dequeue();
    }
}