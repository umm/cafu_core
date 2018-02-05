using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain.UseCase {

    public interface IUseCase {

    }

    public interface ISingletonUseCase : IUseCase, ISingleton {

    }

    public interface IUseCaseFactory<out TUseCase> where TUseCase : IUseCase {

        TUseCase Create();

    }

    public class DefaultUseCaseFactory<TUseCase> : DefaultFactory<TUseCase>, IUseCaseFactory<TUseCase> where TUseCase : IUseCase, new() {

    }

}