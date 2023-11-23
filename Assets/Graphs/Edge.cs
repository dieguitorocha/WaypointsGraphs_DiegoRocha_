using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge
{
    public Node startNode;
    public LinkedListNode endNode;

    public Edge(LinkedListNode from, LinkedListNode to);
    {
        startNode = from;
        endNode = to;
    }

}
