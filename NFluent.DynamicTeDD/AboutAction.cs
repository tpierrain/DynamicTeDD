using System.Windows.Forms;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;

namespace NFluent.DynamicTeDD
{
  [ActionHandler("NFluent.DynamicTeDD.About")]
  public class AboutAction : IActionHandler
  {
    public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
    {
      // return true or false to enable/disable this action
      return true;
    }

    public void Execute(IDataContext context, DelegateExecute nextExecute)
    {
      MessageBox.Show(
        "NFluent.DynamicTeDD\nThomas PIERRAIN, from Rui CARVALHO's original idea\n\nA ReSharper plug-in to make your TDD more fluent via dynamic usage. 1/ You start defining your contract using a dynamic 'modeling clay' instance from within a test (compiling RED) 2/ The plugin replace your dynamic instance with a non-dynamic skeleton code (RED) 3/ You implement the dynamic skeleton code to make your test pass (GREEN).",
        "About NFluent.DynamicTeDD",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
    }
  }
}
