// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AboutAction.cs" company="">
// //   Copyright 2014 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace DynamicTeDD
{
    using System.Windows.Forms;

    using JetBrains.ActionManagement;
    using JetBrains.Application.DataContext;

    [ActionHandler("DynamicTeDD.About")]
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
            "DynamicTeDD\nThomas PIERRAIN, from Rui CARVALHO's original idea\n\nA ReSharper plug-in to make your TDD more fluent via dynamic usage. 1/ You start defining your contract using a dynamic 'modeling clay' instance from within a test (compiling RED) 2/ The plugin replace your dynamic instance with a non-dynamic skeleton code (RED) 3/ You implement the dynamic skeleton code to make your test pass (GREEN).", 
            "About DynamicTeDD", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }
    }
}
