namespace Cacto.Net.Abstractions;

public interface INode
{

    #region Public

    public INode? Parent { get; }
    public int ChildCount { get; }
    public INode? GetChild(int index = 0);

    public static void Link(INode parent, INode child)
    {
        if (child.Parent != null)
            throw new ApplicationException("This child node is attached to another parent node");
        var node = parent;
        while (node != null)
        {
            if (node == child)
                throw new ApplicationException("The child node is its own ancestor");
            node = node.Parent;
        }
        parent.OnAppend(child);
        child.OnAttach(parent);
    }

    public static void Unlink(INode parent, INode child)
    {
        if (child.Parent != parent)
            throw new ApplicationException("This child node is attached to another parent node");
        child.OnDetach(parent);
        parent.OnRemove(child);
    }

    #endregion

    #region Protected

    protected void OnAttach(INode parent);
    protected void OnDetach(INode parent);
    protected void OnAppend(INode child);
    protected void OnRemove(INode child);

    #endregion

}