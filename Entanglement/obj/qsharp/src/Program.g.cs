//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Entanglement\",\"Name\":\"PrepareState1\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":7,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Entanglement\",\"Name\":\"PrepareState1\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Entanglement\",\"Name\":\"PrepareState2\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Entanglement\",\"Name\":\"PrepareState2\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Entanglement
{
    [SourceLocation("C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs", OperationFunctor.Body, 9, 17)]
    public partial class PrepareState1 : Operation<QVoid, QVoid>, ICallable
    {
        public PrepareState1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareState1";
        String ICallable.FullName => "Entanglement.PrepareState1";
        public static EntryPointInfo<QVoid, QVoid> Info => new EntryPointInfo<QVoid, QVoid>(typeof(PrepareState1));
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 10 "C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 11 "C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs"
                    MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
#line 12 "C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs"
                    MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
#line 13 "C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(qs);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release.Apply(qs);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<PrepareState1, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs", OperationFunctor.Body, 17, -1)]
    public partial class PrepareState2 : Operation<QVoid, QVoid>, ICallable
    {
        public PrepareState2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareState2";
        String ICallable.FullName => "Entanglement.PrepareState2";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 18 "C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 19 "C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs"
                    MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
#line 20 "C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs"
                    MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 21 "C:/Users/Reaper/Desktop/Quantum/MultiQubitSystems/Entanglement/Program.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(qs);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release.Apply(qs);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<PrepareState2, QVoid, QVoid>(QVoid.Instance);
        }
    }
}