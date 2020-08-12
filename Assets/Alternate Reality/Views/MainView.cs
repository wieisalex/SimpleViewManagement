using AlternateReality.Management;
using UnityEngine;
using UnityEngine.UI;

namespace AlternateReality.View
{
    public class MainView : BaseView
    {
        [SerializeField] private Button _buttonSettings;


        public override void Activate()
        {
            base.Activate();

            _buttonSettings.onClick.AddListener(() => ViewManagement.Instance.SetView(Views.SETTINGS_VIEW));
        }


        public override void Deactivate()
        {
            base.Deactivate();

            _buttonSettings.onClick.RemoveAllListeners();
        }
    }
}