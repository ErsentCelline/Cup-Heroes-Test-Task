using UI.Components;
using UnityEngine;
using UnityEngine.UI;

namespace UI.View.Gameplay_View
{
    public class GameplayView : MonoBehaviour, IView
    {
        [SerializeField] private ValueView _coinsView;
        [SerializeField] private Button _pauseButton;

        public ValueView CoinsView => _coinsView;
        public Button PauseButton => _pauseButton;
    }

    public interface IView
    {
        
    }

    public class GameplayPresenter
    {
        private GameplayView _view;

        public GameplayPresenter(
            GameplayView view
            )
        {
            _view = view;
        }
        
        
    }
}