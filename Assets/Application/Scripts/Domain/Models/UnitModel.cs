using UniRx;

namespace Domain.Models
{
    public class UnitModel
    {
        public ReactiveProperty<int> Damage = new ReactiveProperty<int>(5);
        public ReactiveProperty<int> Health = new ReactiveProperty<int>(50);
        public ReactiveProperty<float> AttackDelay = new ReactiveProperty<float>(1);
        public ReactiveProperty<bool> IsAlive = new ReactiveProperty<bool>(true);
    }
}