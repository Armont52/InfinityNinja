using System.Collections.Generic;
using UnityEngine;

public class Stage1 : Stage
{
    Stage1(){
        timeLimit = 60;
        enemyList = new int[] {1,2,3,1,2,3,1,2,3};
        enemyQueue = new Queue<int>(enemyList);
    }
}
