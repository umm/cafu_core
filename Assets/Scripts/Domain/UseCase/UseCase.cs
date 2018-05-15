using CAFU.Core.Utility;
using JetBrains.Annotations;

namespace CAFU.Core.Domain.UseCase
{
    [PublicAPI]
    public interface IUseCase
    {
    }

    [PublicAPI]
    public interface ISingletonUseCase : IUseCase, ISingleton
    {
    }

    [PublicAPI]
    public interface IUseCaseFactory<out TUseCase> : IFactory<TUseCase> where TUseCase : IUseCase
    {
    }

    [PublicAPI]
    public class DefaultUseCaseFactory<TUseCase> : DefaultFactory<TUseCase>
        where TUseCase : IUseCase, new()
    {
    }
}