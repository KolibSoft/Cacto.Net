using SFML.Window;

namespace Cacto.Net.Abstractions;

public interface IEventNode
{

    protected bool OnEvent(in Event @event);

}