
using System;
using Test;
using System.Collections;


namespace Intro_Ex1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TestArray test = new TestArray();
            //test.Awake();
            TestQueue testQueue = new TestQueue();
            //testQueue.Awake();
            TestStack testStack = new TestStack();
            //testStack.Awake();
            TestHashTable testHashTable = new TestHashTable();
            testHashTable.Awake();
            
        }
    }
}   