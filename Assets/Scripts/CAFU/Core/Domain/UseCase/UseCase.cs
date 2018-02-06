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

    public class DefaultUseCaseFactory<TFactory, TUseCase> : DefaultFactory<TFactory, TUseCase>, IUseCaseFactory<TUseCase> where TFactory : DefaultFactory<TFactory, TUseCase>, new() where TUseCase : IUseCase, new() {

    }

}