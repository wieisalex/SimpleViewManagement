using AlternateReality.Management;
using UnityEngine;
using UnityEngine.UI;

namespace AlternateReality.View
{
    public class SettingsView : BaseView
    {
        [SerializeField] private Button _buttonBack;


        public override void Activate()
        {
            base.Activate();

            _buttonBack.onClick.AddListener(() => ViewManagement.Instance.SetView(Views.MAIN_VIEW));
        }


        public override void Deactivate()
        {
            base.Deactivate();

            _buttonBack.onClick.RemoveAllListeners();
        }
    }
}