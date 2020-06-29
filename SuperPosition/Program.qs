namespace SuperPosition {

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
}
6