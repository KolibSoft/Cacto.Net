namespace Cacto.Net.Abstractions;

public interface ILeafNode : INode
{

    int INode.ChildCount => 0;
    INode? INode.GetChild(int index) => null;

    void INode.OnAppend(INode child) => throw new ApplicationException("Leaf nodes can not hold childs");
    void INode.OnRemove(INode child) => throw new ApplicationException("Leaf nodes can not hold childs");

}