namespace Entanglement {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;
    

    @EntryPoint()
    operation PrepareState1() : Unit {
        using(qs = Qubit[2]){
            X(qs[0]);
            X(qs[1]);
            ResetAll(qs);
        }
    }

    operation PrepareState2() : Unit {
        using(qs = Qubit[2]){
            X(qs[1]);
            H(qs[1]);
            ResetAll(qs);
        }
    }

    operation PrepareState3() : Unit {
        using(qs = Qubit[2]){
            H(qs[0]);
            X(qs[1]);
            H(qs[1]);
        }
    }

    operation PrepareState4() : Unit {
        using(qs = Qubit[2]){
            H(qs[0]);
            S(qs[0]);
            H(qs[1]);
            T(qs[1]);
        }
    }
}
