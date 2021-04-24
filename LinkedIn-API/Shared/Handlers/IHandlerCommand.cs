using Shared.Commands;

namespace Shared.Handlers
{
    public interface IHandlerCommand
    {
        public interface IHandlerCommand<T> where T : ICommand
        {
            ICommandResult Handle(T command);
        }
    }
}
