using System.Collections.Generic;
using UnityEngine;

public class Stage1 : Stage
{
    Stage1(){
        minutes = 1;
        seconds = 0;
        enemyList = new int[] {1,2,3,1,2,3,1,2,3};
        enemyQueue = new Queue<int>(enemyList);
    }
}
