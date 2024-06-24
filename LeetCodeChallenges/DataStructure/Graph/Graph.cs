using static Resolved.DataStructure.Graph.Graph;

namespace Resolved.DataStructure.Graph;

public class Graph(List<Node> nodes)
{
    public List<Node> Nodes { get; private set; } = nodes;

    public class Node(string label)
    {
        public string Label { get; init; } = label;
        public List<Edge> Edges { get; set; } = new List<Edge>();

        public void ConnectNode(Node destinationNode, int weight) =>
            Edges.Add(new Edge(destinationNode, weight));

        public class Edge(Node destinationNode, int weight)
        {
            public Node DestinationNode { get; init; } = destinationNode;
            public int Weight { get; init; } = weight;
        }
    }
}

public static class GraphExtension
{
    public static List<Node> Dijkstra(this Graph graph, Node from, Node to) 
    {
        var visitedNodes = new List<Node>();
        var nodeSegmentMap = graph.Nodes.ToDictionary(
            node => node, 
            _ => new Segment(null, int.MaxValue)
        );
        nodeSegmentMap[from] = new Segment(null, 0);

        var currentNode = from;
        while (visitedNodes.Count < graph.Nodes.Count) 
        {
            foreach (var edge in currentNode.Edges.Where(edge => !visitedNodes.Any(visitedNode => visitedNode == edge.DestinationNode)))
            {
                var currentWeight = nodeSegmentMap[currentNode].Weight;
                if (edge.Weight + currentWeight < nodeSegmentMap[edge.DestinationNode].Weight)
                    nodeSegmentMap[edge.DestinationNode] = new Segment(currentNode, edge.Weight + currentWeight);
            }

            visitedNodes.Add(currentNode);
            currentNode = nodeSegmentMap.Where(x => !visitedNodes.Any(visitedNode => visitedNode == x.Key)).OrderBy(x => x.Value.Weight).FirstOrDefault().Key;
        }

        var result = new List<Node>();
        var node = to;
        do
        {
            result.Insert(0, node);
            node = nodeSegmentMap[node].PreviousNode;
        } 
        while (node != null);

        return result;
    }

    internal struct Segment(Node? previousNode, int weight)
    {
        internal Node? PreviousNode { get; set; } = previousNode;
        internal int Weight { get; set; } = weight;
    }
}
