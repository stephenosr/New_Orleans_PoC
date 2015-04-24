//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace SMS.IFeePaymentGrain.Interfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    using SMS.Definitions.Classes;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class FeeManagerFactory
    {
        

                        public static SMS.IFeePaymentGrain.Interfaces.IFeeManager GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeeManager), 1964279557, primaryKey));
                        }

                        public static SMS.IFeePaymentGrain.Interfaces.IFeeManager GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeeManager), 1964279557, primaryKey, grainClassNamePrefix));
                        }

                        public static SMS.IFeePaymentGrain.Interfaces.IFeeManager GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeeManager), 1964279557, primaryKey));
                        }

                        public static SMS.IFeePaymentGrain.Interfaces.IFeeManager GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeeManager), 1964279557, primaryKey, grainClassNamePrefix));
                        }

            public static SMS.IFeePaymentGrain.Interfaces.IFeeManager Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return FeeManagerReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("SMS.IFeePaymentGrain.Interfaces.SMS.IFeePaymentGrain.Interfaces.IFeeManager")]
        internal class FeeManagerReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, SMS.IFeePaymentGrain.Interfaces.IFeeManager
        {
            

            public static SMS.IFeePaymentGrain.Interfaces.IFeeManager Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (SMS.IFeePaymentGrain.Interfaces.IFeeManager) global::Orleans.Runtime.GrainReference.CastInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeeManager), (global::Orleans.Runtime.GrainReference gr) => { return new FeeManagerReference(gr);}, grainRef, 1964279557);
            }
            
            protected internal FeeManagerReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal FeeManagerReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 1964279557;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "SMS.IFeePaymentGrain.Interfaces.SMS.IFeePaymentGrain.Interfaces.IFeeManager";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                FeeManagerReference input = ((FeeManagerReference)(original));
                return ((FeeManagerReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                FeeManagerReference input = ((FeeManagerReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return FeeManagerReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return FeeManagerMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task SMS.IFeePaymentGrain.Interfaces.IFeeManager.FeePaymentStall(SMS.Definitions.Classes.Fees @Fee)
            {

                return base.InvokeMethodAsync<object>(1190079746, new object[] {@Fee} );
            }
            
            System.Threading.Tasks.Task<SMS.Definitions.Classes.FeePayment> SMS.IFeePaymentGrain.Interfaces.IFeeManager.FeeEnquiry(System.Guid @FeeID)
            {

                return base.InvokeMethodAsync<SMS.Definitions.Classes.FeePayment>(1189339710, new object[] {@FeeID} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("SMS.IFeePaymentGrain.Interfaces.SMS.IFeePaymentGrain.Interfaces.IFeeManager", 1964279557)]
    internal class FeeManagerMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 1964279557;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1964279557:  // IFeeManager
                        switch (methodId)
                        {
                            case 1190079746: 
                                return ((IFeeManager)grain).FeePaymentStall((SMS.Definitions.Classes.Fees)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case 1189339710: 
                                return ((IFeeManager)grain).FeeEnquiry((Guid)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 1964279557:  // IFeeManager
                    switch (methodId)
                    {
                        case 1190079746:
                            return "FeePaymentStall";
                    case 1189339710:
                            return "FeeEnquiry";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class FeePaymentGrainFactory
    {
        

                        public static SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain), 98290911, primaryKey));
                        }

                        public static SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain), 98290911, primaryKey, grainClassNamePrefix));
                        }

                        public static SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain), 98290911, primaryKey));
                        }

                        public static SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain), 98290911, primaryKey, grainClassNamePrefix));
                        }

            public static SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return FeePaymentGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("SMS.IFeePaymentGrain.Interfaces.SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain")]
        internal class FeePaymentGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain
        {
            

            public static SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain), (global::Orleans.Runtime.GrainReference gr) => { return new FeePaymentGrainReference(gr);}, grainRef, 98290911);
            }
            
            protected internal FeePaymentGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal FeePaymentGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 98290911;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "SMS.IFeePaymentGrain.Interfaces.SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                FeePaymentGrainReference input = ((FeePaymentGrainReference)(original));
                return ((FeePaymentGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                FeePaymentGrainReference input = ((FeePaymentGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return FeePaymentGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return FeePaymentGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain.MakePayment(SMS.Definitions.Classes.Fees @payment)
            {

                return base.InvokeMethodAsync<object>(1533744513, new object[] {@payment} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("SMS.IFeePaymentGrain.Interfaces.SMS.IFeePaymentGrain.Interfaces.IFeePaymentGrain", 98290911)]
    internal class FeePaymentGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 98290911;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 98290911:  // IFeePaymentGrain
                        switch (methodId)
                        {
                            case 1533744513: 
                                return ((IFeePaymentGrain)grain).MakePayment((Fees)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 98290911:  // IFeePaymentGrain
                    switch (methodId)
                    {
                        case 1533744513:
                            return "MakePayment";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
namespace SMS.IFeePaymentGrain.InterfacesSerializers
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Orleans.Serialization;
    using SMS.Definitions.Classes;
    using System.Collections;
    using System.Runtime.Serialization;
    using System.Runtime.InteropServices;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class SMS_Definitions_Classes_FeesSerialization
    {
        
        static SMS_Definitions_Classes_FeesSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            return original;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            SMS.Definitions.Classes.Fees input = ((SMS.Definitions.Classes.Fees)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Date, stream, typeof(System.DateTime));
            Orleans.Serialization.SerializationManager.SerializeInner(input.FeeAmount, stream, typeof(double));
            Orleans.Serialization.SerializationManager.SerializeInner(input.FeeCode, stream, typeof(string));
            Orleans.Serialization.SerializationManager.SerializeInner(input.FeeID, stream, typeof(System.Guid));
            Orleans.Serialization.SerializationManager.SerializeInner(input.StudentID, stream, typeof(string));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            SMS.Definitions.Classes.Fees result = new SMS.Definitions.Classes.Fees();
            result.Date = ((System.DateTime)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.DateTime), stream)));
            result.FeeAmount = ((double)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(double), stream)));
            result.FeeCode = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            result.FeeID = ((System.Guid)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.Guid), stream)));
            result.StudentID = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(SMS.Definitions.Classes.Fees), DeepCopier, Serializer, Deserializer);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class SMS_Definitions_Classes_FeePaymentSerialization
    {
        
        static SMS_Definitions_Classes_FeePaymentSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            return original;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            SMS.Definitions.Classes.FeePayment input = ((SMS.Definitions.Classes.FeePayment)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Fee, stream, typeof(SMS.Definitions.Classes.Fees));
            Orleans.Serialization.SerializationManager.SerializeInner(input.StudentFee, stream, typeof(SMS.Definitions.Classes.Student));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            SMS.Definitions.Classes.FeePayment result = new SMS.Definitions.Classes.FeePayment();
            result.Fee = ((SMS.Definitions.Classes.Fees)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(SMS.Definitions.Classes.Fees), stream)));
            result.StudentFee = ((SMS.Definitions.Classes.Student)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(SMS.Definitions.Classes.Student), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(SMS.Definitions.Classes.FeePayment), DeepCopier, Serializer, Deserializer);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class SMS_Definitions_Classes_StudentSerialization
    {
        
        static SMS_Definitions_Classes_StudentSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            SMS.Definitions.Classes.Student input = ((SMS.Definitions.Classes.Student)(original));
            SMS.Definitions.Classes.Student result = new SMS.Definitions.Classes.Student();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            result.StudentID = ((System.Guid)(Orleans.Serialization.SerializationManager.DeepCopyInner(input.StudentID)));
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            SMS.Definitions.Classes.Student input = ((SMS.Definitions.Classes.Student)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.StudentID, stream, typeof(System.Guid));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            SMS.Definitions.Classes.Student result = new SMS.Definitions.Classes.Student();
            result.StudentID = ((System.Guid)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(System.Guid), stream)));
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(SMS.Definitions.Classes.Student), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
