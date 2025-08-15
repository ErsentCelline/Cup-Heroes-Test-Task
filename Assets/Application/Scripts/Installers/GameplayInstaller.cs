using Core.Messages;
using MessagePipe;
using VContainer;
using VContainer.Unity;

namespace Installers
{
    public class GameplayInstaller : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            var options = builder.RegisterMessagePipe();

            builder.RegisterMessageBroker<EnemyDieMessage>(options);
            builder.RegisterMessageBroker<WaveClearMessage>(options);
        }
    }
}