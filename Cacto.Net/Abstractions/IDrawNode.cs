using SFML.Graphics;

namespace Cacto.Net.Abstractions;

public interface IDrawNode
{

    protected void onDraw(RenderTarget target, in RenderStates states);

}
