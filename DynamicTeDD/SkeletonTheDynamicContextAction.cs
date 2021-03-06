// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="SkeletonTheDynamicContextAction.cs" company="">
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
    using System;

    using JetBrains.Application.Progress;
    using JetBrains.ProjectModel;
    using JetBrains.ReSharper.Feature.Services.Bulbs;
    using JetBrains.ReSharper.Feature.Services.CSharp.Bulbs;
    using JetBrains.ReSharper.Feature.Services.LinqTools;
    using JetBrains.ReSharper.Intentions.Extensibility;
    using JetBrains.ReSharper.Psi.CSharp;
    using JetBrains.ReSharper.Psi.CSharp.Tree;
    using JetBrains.ReSharper.Psi.Tree;
    using JetBrains.TextControl;
    using JetBrains.Util;

    [ContextAction(Name = "SkeletonTheDynamic", Description = "Replaces the dynamic instance with a non-dynamic skeleton type instance.", Group = "C#")]
    public class SkeletonTheDynamicAction : ContextActionBase, IContextAction
    {
        private readonly ICSharpContextActionDataProvider provider;
        private ILiteralExpression stringLiteral;

        public SkeletonTheDynamicAction(ICSharpContextActionDataProvider provider)
        {
            this.provider = provider;
        }

        public override bool IsAvailable(IUserDataHolder cache)
        {
            var literal = this.provider.GetSelectedElement<ILiteralExpression>(true, true);

            if (literal != null && literal.IsConstantValue() && literal.ConstantValue.IsString())
            {
                var s = literal.ConstantValue.Value as string;
                if (!string.IsNullOrEmpty(s))
                {
                    this.stringLiteral = literal;
                    return true;
                }
            }

            return false;
        }

        protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
        {
            CSharpElementFactory factory = CSharpElementFactory.GetInstance(this.provider.PsiModule);

            var stringValue = this.stringLiteral.ConstantValue.Value as string;
            if (stringValue == null)
                return null;

            var chars = stringValue.ToCharArray();
            Array.Reverse(chars);
            ICSharpExpression newExpr = factory.CreateExpressionAsIs("\"" + new string(chars) + "\"");
            this.stringLiteral.ReplaceBy(newExpr);
            return null;
        }

        public override string Text
        {
            get { return "Skeleton the dynamic"; }
        }
    }

    // [ContextAction(Description = "My skeleton the dynamic context action does ...",
    // Group = "C#",
    // Name = "My skeleton the dynamic Context Action")]
    // public sealed class SkeletonTheDynamicContextAction : IContextAction
    // {
    // private readonly ICSharpContextActionDataProvider _provider;
    // private IBulbAction[] _items;

    // /// <summary>
    // /// For languages other than C# any inheritor of <see cref="IContextActionDataProvider"/> can 
    // /// be injected in this constructor.
    // /// </summary>
    // public SkeletonTheDynamicContextAction(ICSharpContextActionDataProvider provider)
    // {
    // _provider = provider;
    // }

    // public void CreateBulbItems(BulbMenu menu)
    // {
    // // Basically 
    // foreach (var item in Items)
    // {
    // // use other extension methods on BulbMenu to arrange menu items.
    // menu.ArrangeContextAction(item);
    // }
    // }

    // public bool IsAvailable(IUserDataHolder cache)
    // {
    // // Availability code may be optimized but for most cases can be as simple as follow:
    // return Items.Length > 0;
    // }

    // private IBulbAction[] Items
    // {
    // get
    // {
    // if (_items == null)
    // {
    // _items = new IBulbAction[]
    // {
    // new MyBulbItem(_provider)
    // };
    // }
    // return _items;
    // }
    // }
    // }

    // public class MyBulbItem : BulbActionBase
    // {
    // private readonly ICSharpContextActionDataProvider _provider;

    // public MyBulbItem(ICSharpContextActionDataProvider provider)
    // {
    // _provider = provider;
    // }

    // public override string Text
    // {
    // get
    // {
    // // text returned here will be displayed on the context action
    // return "Skeleton the dynamic Context action text";
    // }
    // }

    // protected override Action<ITextControl> ExecutePsiTransaction(ISolution solution, IProgressIndicator progress)
    // {
    // // put transacted steps here
    // // use 'provider' field to get currently selected element

    // return textControl =>
    // {
    // // put post-transaction steps here
    // // if there are none, you can replace this with 'return null'
    // };
    // }

    // }
}
