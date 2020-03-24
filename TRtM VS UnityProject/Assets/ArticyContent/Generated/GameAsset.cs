//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.The_Road_To_Moscow.Features;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.The_Road_To_Moscow
{
    
    
    public class GameAsset : Instruction, IInstruction, IPropertyProvider, IObjectWithFeatureAssetF
    {
        
        [SerializeField()]
        private ArticyValueGameAssetTemplate mTemplate = new ArticyValueGameAssetTemplate();
        
        private static Articy.The_Road_To_Moscow.Templates.GameAssetTemplateConstraint mConstraints = new Articy.The_Road_To_Moscow.Templates.GameAssetTemplateConstraint();
        
        public Articy.The_Road_To_Moscow.Templates.GameAssetTemplate Template
        {
            get
            {
                return mTemplate.GetValue();
            }
            set
            {
                mTemplate.SetValue(value);
            }
        }
        
        public static Articy.The_Road_To_Moscow.Templates.GameAssetTemplateConstraint Constraints
        {
            get
            {
                return mConstraints;
            }
        }
        
        public AssetFFeature GetFeatureAssetF()
        {
            return Template.AssetF;
        }
        
        protected override void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            GameAsset newClone = ((GameAsset)(aClone));
            if ((Template != null))
            {
                newClone.Template = ((Articy.The_Road_To_Moscow.Templates.GameAssetTemplate)(Template.CloneObject(newClone, aFirstClassParent)));
            }
            base.CloneProperties(newClone, aFirstClassParent);
        }
        
        public override bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return base.IsLocalizedPropertyOverwritten(aProperty);
        }
        
        #region property provider interface
        public override void setProp(string aProperty, object aValue)
        {
            if (aProperty.Contains("."))
            {
                Template.setProp(aProperty, aValue);
                return;
            }
            base.setProp(aProperty, aValue);
        }
        
        public override Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if (aProperty.Contains("."))
            {
                return Template.getProp(aProperty);
            }
            return base.getProp(aProperty);
        }
        #endregion
    }
}