using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph 
{
    List<Edge> edges = new List<Edge>();
    List<Node> nodes = new List<Node>();
    List<Node> pathList = new List<Node>();

    public Graph() { }

    public void AddNode(GameObject id)
    {
        Node node = new Node(id);
        nodes.Add(node);

    }
    public void AddEdge(GameObject fromNode, GameObject toNode)
    {
        nodes from = FindNode(fromNode);
        nodes to = FindNode(toNode);

        if(from != null && to != null)
        {
            edges e = new Edge(from, to);
            edges.Add(e);
            from.edgesList.Add(e);
        }
    }
    LinkedListNode FindNode(GameObject id)
    {
        foreach (LinkedListNode n in nodes)
        {
            if (n.getId() == id)
                return n;

        }
        return null;
    }
}
