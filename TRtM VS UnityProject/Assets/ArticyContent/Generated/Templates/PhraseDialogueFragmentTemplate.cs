//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Test;
using Articy.Test.Features;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Test.Templates
{
    
    
    [Serializable()]
    public class PhraseDialogueFragmentTemplate : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private ArticyValuePhraseFeatureFeature mPhraseFeature = new ArticyValuePhraseFeatureFeature();
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        public Articy.Test.Features.PhraseFeatureFeature PhraseFeature
        {
            get
            {
                return mPhraseFeature.GetValue();
            }
            set
            {
                mPhraseFeature.SetValue(value);
            }
        }
        
        public UInt64 OwnerId
        {
            get
            {
                return mOwnerId;
            }
            set
            {
                mOwnerId = value;
                PhraseFeature.OwnerId = value;
            }
        }
        
        public UInt32 OwnerInstanceId
        {
            get
            {
                return mOwnerInstanceId;
            }
            set
            {
                mOwnerInstanceId = value;
                PhraseFeature.OwnerInstanceId = value;
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Test.Templates.PhraseDialogueFragmentTemplate newClone = ((Articy.Test.Templates.PhraseDialogueFragmentTemplate)(aClone));
            if ((PhraseFeature != null))
            {
                newClone.PhraseFeature = ((Articy.Test.Features.PhraseFeatureFeature)(PhraseFeature.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.Test.Templates.PhraseDialogueFragmentTemplate clone = new Articy.Test.Templates.PhraseDialogueFragmentTemplate();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
        
        public virtual bool IsLocalizedPropertyOverwritten(string aProperty)
        {
            return false;
        }
        
        #region property provider interface
        public void setProp(string aProperty, object aValue)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "PhraseFeature"))
                {
                    PhraseFeature.setProp(featureProperty, aValue);
                }
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            int featureIndex = aProperty.IndexOf('.');
            if ((featureIndex != -1))
            {
                string featurePath = aProperty.Substring(0, featureIndex);
                string featureProperty = aProperty.Substring((featureIndex + 1));
                if ((featurePath == "PhraseFeature"))
                {
                    return PhraseFeature.getProp(featureProperty);
                }
            }
            return null;
        }
        #endregion
    }
}