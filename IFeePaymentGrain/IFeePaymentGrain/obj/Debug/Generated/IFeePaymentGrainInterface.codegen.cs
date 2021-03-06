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

namespace IFeePaymentGrainInterface
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class FeePaymentGrainFactory
    {
        

                        public static IFeePaymentGrainInterface.IFeePaymentGrain GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IFeePaymentGrainInterface.IFeePaymentGrain), 2043049232, primaryKey));
                        }

                        public static IFeePaymentGrainInterface.IFeePaymentGrain GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IFeePaymentGrainInterface.IFeePaymentGrain), 2043049232, primaryKey, grainClassNamePrefix));
                        }

                        public static IFeePaymentGrainInterface.IFeePaymentGrain GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IFeePaymentGrainInterface.IFeePaymentGrain), 2043049232, primaryKey));
                        }

                        public static IFeePaymentGrainInterface.IFeePaymentGrain GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(IFeePaymentGrainInterface.IFeePaymentGrain), 2043049232, primaryKey, grainClassNamePrefix));
                        }

            public static IFeePaymentGrainInterface.IFeePaymentGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return FeePaymentGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("IFeePaymentGrainInterface.IFeePaymentGrainInterface.IFeePaymentGrain")]
        internal class FeePaymentGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, IFeePaymentGrainInterface.IFeePaymentGrain
        {
            

            public static IFeePaymentGrainInterface.IFeePaymentGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IFeePaymentGrainInterface.IFeePaymentGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IFeePaymentGrainInterface.IFeePaymentGrain), (global::Orleans.Runtime.GrainReference gr) => { return new FeePaymentGrainReference(gr);}, grainRef, 2043049232);
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
                    return 2043049232;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "IFeePaymentGrainInterface.IFeePaymentGrainInterface.IFeePaymentGrain";
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
            
            System.Threading.Tasks.Task IFeePaymentGrainInterface.IFeePaymentGrain.MakePayment(double @payment)
            {

                return base.InvokeMethodAsync<object>(-2108449300, new object[] {@payment} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("IFeePaymentGrainInterface.IFeePaymentGrainInterface.IFeePaymentGrain", 2043049232)]
    internal class FeePaymentGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 2043049232;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 2043049232:  // IFeePaymentGrain
                        switch (methodId)
                        {
                            case -2108449300: 
                                return ((IFeePaymentGrain)grain).MakePayment((Double)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
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
                
                case 2043049232:  // IFeePaymentGrain
                    switch (methodId)
                    {
                        case -2108449300:
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
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
