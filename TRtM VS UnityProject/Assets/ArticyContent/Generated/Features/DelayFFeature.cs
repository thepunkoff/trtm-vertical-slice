//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.The_Road_To_Moscow;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.The_Road_To_Moscow.Features
{
    
    
    [Serializable()]
    public class DelayFFeature : IArticyBaseObject, IPropertyProvider
    {
        
        [SerializeField()]
        private Single mDelay;
        
        [SerializeField()]
        private Single mWaiting;
        
        [SerializeField()]
        private UInt64 mOwnerId;
        
        [SerializeField()]
        private UInt32 mOwnerInstanceId;
        
        /// <summary>
        /// Длительная задержка. Визуально отображается и может быть пропущена с помощью просмотра рекламы.
        /// </summary>
        public Single Delay
        {
            get
            {
                return mDelay;
            }
            set
            {
                var oldValue = mDelay;
                mDelay = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "DelayF.Delay", oldValue, mDelay);
            }
        }
        
        /// <summary>
        /// Короткая задержка.
        /// </summary>
        public Single Waiting
        {
            get
            {
                return mWaiting;
            }
            set
            {
                var oldValue = mWaiting;
                mWaiting = value;
                Articy.Unity.ArticyDatabase.ObjectNotifications.ReportChanged(OwnerId, OwnerInstanceId, "DelayF.Waiting", oldValue, mWaiting);
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
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.The_Road_To_Moscow.Features.DelayFFeature newClone = ((Articy.The_Road_To_Moscow.Features.DelayFFeature)(aClone));
            newClone.Delay = Delay;
            newClone.Waiting = Waiting;
            newClone.OwnerId = OwnerId;
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            Articy.The_Road_To_Moscow.Features.DelayFFeature clone = new Articy.The_Road_To_Moscow.Features.DelayFFeature();
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
            if ((aProperty == "Delay"))
            {
                Delay = System.Convert.ToSingle(aValue);
                return;
            }
            if ((aProperty == "Waiting"))
            {
                Waiting = System.Convert.ToSingle(aValue);
                return;
            }
        }
        
        public Articy.Unity.Interfaces.ScriptDataProxy getProp(string aProperty)
        {
            if ((aProperty == "Delay"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Delay);
            }
            if ((aProperty == "Waiting"))
            {
                return new Articy.Unity.Interfaces.ScriptDataProxy(Waiting);
            }
            return null;
        }
        #endregion
    }
}