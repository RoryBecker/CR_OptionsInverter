using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_OptionsInverter
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_OptionsInverterExtension : IVsixPluginExtension { }
}