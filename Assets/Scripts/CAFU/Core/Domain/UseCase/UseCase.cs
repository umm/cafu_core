using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain.UseCase {

    public interface IUseCase {

    }

    public interface ISingletonUseCase : IUseCase, ISingleton {

    }

    public interface IUseCaseFactory<out TUseCase> : IFactory<TUseCase> where TUseCase : IUseCase {

    }

    public class DefaultUseCaseFactory<TUseCase> : DefaultUseCaseFactory<DefaultUseCaseFactory<TUseCase>, TUseCase>
        where TUseCase : IUseCase, new() {

    }

    public class DefaultUseCaseFactory<TFactory, TUseCase> : DefaultFactory<TFactory, TUseCase>, IUseCaseFactory<TUseCase>
        where TFactory : DefaultFactory<TFactory, TUseCase>, new()
        where TUseCase : IUseCase, new() {

    }

}