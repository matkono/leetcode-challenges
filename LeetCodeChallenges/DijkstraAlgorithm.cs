using Resolved.DataStructure.Graph;

namespace Resolved;

// There is no leetcode challenge specific to the Dijkstra algorithm. But, as it's a famous algorithm, I decided to do it.
public class DijkstraAlgorithm
{
    public void FindShortestPath() 
    {
        var nodeA = new Graph.Node("A");
        var nodeB = new Graph.Node("B");
        var nodeC = new Graph.Node("C");
        var nodeD = new Graph.Node("D");
        var nodeE = new Graph.Node("E");
        var nodeF = new Graph.Node("F");
        var nodeG = new Graph.Node("G");
        var nodeH = new Graph.Node("H");

        nodeA.ConnectNode(nodeB, 3);
        nodeA.ConnectNode(nodeC, 2);

        nodeB.ConnectNode(nodeA, 3);
        nodeB.ConnectNode(nodeC, 1);
        nodeB.ConnectNode(nodeD, 5);
        nodeB.ConnectNode(nodeG, 5);

        nodeC.ConnectNode(nodeA, 2);
        nodeC.ConnectNode(nodeB, 1);
        nodeC.ConnectNode(nodeD, 3);
        nodeC.ConnectNode(nodeE, 10);
        nodeC.ConnectNode(nodeF, 7);

        nodeD.ConnectNode(nodeB, 5);
        nodeD.ConnectNode(nodeC, 3);
        nodeD.ConnectNode(nodeE, 4);

        nodeE.ConnectNode(nodeC, 10);
        nodeE.ConnectNode(nodeD, 4);
        nodeE.ConnectNode(nodeF, 2);
        nodeE.ConnectNode(nodeH, 1);

        nodeF.ConnectNode(nodeC, 7);
        nodeF.ConnectNode(nodeE, 2);

        nodeG.ConnectNode(nodeB, 5);
        nodeG.ConnectNode(nodeH, 2);

        nodeH.ConnectNode(nodeE, 1);
        nodeH.ConnectNode(nodeG, 2);

        var nodes = new List<Graph.Node>
        {
            nodeA,
            nodeB,
            nodeC,
            nodeD,
            nodeE,
            nodeF,
            nodeG,
            nodeH
        };

        var graph = new Graph(nodes);
        var result = graph.Dijkstra(nodeA, nodeE);
        Console.WriteLine("The shortest path is: ");
        foreach (var item in result)
            Console.WriteLine(item.Label);
    }
}
