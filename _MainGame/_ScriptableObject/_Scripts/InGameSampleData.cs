using UnityEngine;
using Zenject;

namespace MVPTemplateEditor.Data
{
    [CreateAssetMenu(fileName = "InGameSampleData", menuName = "Installers/InGameSampleData")]
    public class InGameSampleData :  ScriptableObjectInstaller<InGameSampleData>
    {
        [SerializeField] string _value = default;

        public string Value { get => _value; }

        public override void InstallBindings()
        {
            Container.Bind<InGameSampleData>().FromInstance(this).AsCached();
        }
    }
}