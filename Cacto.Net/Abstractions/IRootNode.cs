namespace Cacto.Net.Abstractions;

public interface IRootNode : INode
{

    INode? INode.Parent => null;

    void INode.OnAttach(INode parent) => throw new ApplicationException("Root nodes can not be holded");
    void INode.OnDetach(INode parent) => throw new ApplicationException("Root nodes can not be holded");

}