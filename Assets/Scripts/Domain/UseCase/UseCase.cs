using CAFU.Core.Utility;

namespace CAFU.Core.Domain.UseCase
{
    public interface IUseCase
    {
    }

    public interface ISingletonUseCase : IUseCase, ISingleton
    {
    }

    public interface IUseCaseFactory<out TUseCase> : IFactory<TUseCase> where TUseCase : IUseCase
    {
    }

    public class DefaultUseCaseFactory<TUseCase> : DefaultFactory<TUseCase>
        where TUseCase : IUseCase, new()
    {
    }
}