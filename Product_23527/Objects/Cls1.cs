﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Product_23527
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Cls1.
    /// </summary>
    //  *** Start programmer edit section *** (Cls1 CustomAttributes)

    //  *** End programmer edit section *** (Cls1 CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("Cls1E", new string[] {
            "attr1 as \'aaaa\' on \'#1(10*)\'",
            "attr3 as \'mmmmm\' on \'#2\'",
            "attr4 on \'#1\'"})]
    [View("Cls1L", new string[] {
            "attr1 as \'Attr1\'"})]
    [View("ViewE", new string[] {
            "attr1"})]
    public class Cls1 : ICSSoft.STORMNET.DataObject
    {
        
        private bool fattr4;
        
        private string fattr3;
        
        private string fattr1;
        
        //  *** Start programmer edit section *** (Cls1 CustomMembers)

        //  *** End programmer edit section *** (Cls1 CustomMembers)

        
        /// <summary>
        /// attr4.
        /// </summary>
        //  *** Start programmer edit section *** (Cls1.attr4 CustomAttributes)

        //  *** End programmer edit section *** (Cls1.attr4 CustomAttributes)
        public virtual bool attr4
        {
            get
            {
                //  *** Start programmer edit section *** (Cls1.attr4 Get start)

                //  *** End programmer edit section *** (Cls1.attr4 Get start)
                bool result = this.fattr4;
                //  *** Start programmer edit section *** (Cls1.attr4 Get end)

                //  *** End programmer edit section *** (Cls1.attr4 Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Cls1.attr4 Set start)

                //  *** End programmer edit section *** (Cls1.attr4 Set start)
                this.fattr4 = value;
                //  *** Start programmer edit section *** (Cls1.attr4 Set end)

                //  *** End programmer edit section *** (Cls1.attr4 Set end)
            }
        }
        
        /// <summary>
        /// attr3.
        /// </summary>
        //  *** Start programmer edit section *** (Cls1.attr3 CustomAttributes)

        //  *** End programmer edit section *** (Cls1.attr3 CustomAttributes)
        [StrLen(255)]
        public virtual string attr3
        {
            get
            {
                //  *** Start programmer edit section *** (Cls1.attr3 Get start)

                //  *** End programmer edit section *** (Cls1.attr3 Get start)
                string result = this.fattr3;
                //  *** Start programmer edit section *** (Cls1.attr3 Get end)

                //  *** End programmer edit section *** (Cls1.attr3 Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Cls1.attr3 Set start)

                //  *** End programmer edit section *** (Cls1.attr3 Set start)
                this.fattr3 = value;
                //  *** Start programmer edit section *** (Cls1.attr3 Set end)

                //  *** End programmer edit section *** (Cls1.attr3 Set end)
            }
        }
        
        /// <summary>
        /// attr1.
        /// </summary>
        //  *** Start programmer edit section *** (Cls1.attr1 CustomAttributes)

        //  *** End programmer edit section *** (Cls1.attr1 CustomAttributes)
        [StrLen(255)]
        public virtual string attr1
        {
            get
            {
                //  *** Start programmer edit section *** (Cls1.attr1 Get start)

                //  *** End programmer edit section *** (Cls1.attr1 Get start)
                string result = this.fattr1;
                //  *** Start programmer edit section *** (Cls1.attr1 Get end)

                //  *** End programmer edit section *** (Cls1.attr1 Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Cls1.attr1 Set start)

                //  *** End programmer edit section *** (Cls1.attr1 Set start)
                this.fattr1 = value;
                //  *** Start programmer edit section *** (Cls1.attr1 Set end)

                //  *** End programmer edit section *** (Cls1.attr1 Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "Cls1E" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Cls1E
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Cls1E", typeof(IIS.Product_23527.Cls1));
                }
            }
            
            /// <summary>
            /// "Cls1L" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Cls1L
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Cls1L", typeof(IIS.Product_23527.Cls1));
                }
            }
            
            /// <summary>
            /// "ViewE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ViewE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ViewE", typeof(IIS.Product_23527.Cls1));
                }
            }
        }
    }
}