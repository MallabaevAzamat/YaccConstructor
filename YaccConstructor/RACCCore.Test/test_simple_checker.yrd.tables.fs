//this tables was generated by RACC
//source grammar:..\Tests\RACC\test_simple_checker\test_simple_checker.yrd
//date:3/14/2011 9:54:30

#light "off"
module Yard.Generators.RACCGenerator.Tables_Simple_checker

open Yard.Generators.RACCGenerator

let autumataDict = 
dict [|("raccStart",{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol "s");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbS 0))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 0))|]
|];
   ToStateID   = 2;
}
|];
}
);("s",{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol "e");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSeqS 2));(FATrace (TSmbS 1))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 1));(FATrace (TSeqE 2))|]
|];
   ToStateID   = 2;
}
|];
}
);("e",{ 
   DIDToStateMap = dict [|(0,(State 0));(1,(State 1));(2,(State 2));(3,(State 3));(4,(State 4));(5,(State 5));(6,(State 6));(7,DummyState);(8,DummyState)|];
   DStartState   = 0;
   DFinaleStates = Set.ofArray [|1;6|];
   DRules        = Set.ofArray [|{ 
   FromStateID = 0;
   Symbol      = (DSymbol "NUMBER");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TAlt1S 18));(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]
;List.ofArray [|(FATrace (TAlt2S 19));(FATrace (TSeqS 17));(FATrace (TSmbS 5))|]
|];
   ToStateID   = 1;
}
;{ 
   FromStateID = 0;
   Symbol      = (DSymbol "e");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TAlt1S 18));(FATrace (TSeqS 4));(FATrace (TSmbS 3))|]
;List.ofArray [|(FATrace (TAlt2S 19));(FATrace (TSeqS 17));(FATrace (TSmbS 5))|]
|];
   ToStateID   = 2;
}
;{ 
   FromStateID = 1;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 3));(FATrace (TSeqE 4));(FATrace (TAlt1E 18))|]
|];
   ToStateID   = 7;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol "MINUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt1S 14));(FATrace (TSeqS 7));(FATrace (TSmbS 6))|]
;List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt2S 15));(FATrace (TAlt1S 12));(FATrace (TSeqS 9));(FATrace (TSmbS 8))|]
;List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt2S 15));(FATrace (TAlt2S 13));(FATrace (TSeqS 11));(FATrace (TSmbS 10))|]
|];
   ToStateID   = 5;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol "MULT");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt1S 14));(FATrace (TSeqS 7));(FATrace (TSmbS 6))|]
;List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt2S 15));(FATrace (TAlt1S 12));(FATrace (TSeqS 9));(FATrace (TSmbS 8))|]
;List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt2S 15));(FATrace (TAlt2S 13));(FATrace (TSeqS 11));(FATrace (TSmbS 10))|]
|];
   ToStateID   = 4;
}
;{ 
   FromStateID = 2;
   Symbol      = (DSymbol "PLUS");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt1S 14));(FATrace (TSeqS 7));(FATrace (TSmbS 6))|]
;List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt2S 15));(FATrace (TAlt1S 12));(FATrace (TSeqS 9));(FATrace (TSmbS 8))|]
;List.ofArray [|(FATrace (TSmbE 5));(FATrace (TAlt2S 15));(FATrace (TAlt2S 13));(FATrace (TSeqS 11));(FATrace (TSmbS 10))|]
|];
   ToStateID   = 3;
}
;{ 
   FromStateID = 3;
   Symbol      = (DSymbol "e");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 6));(FATrace (TSeqE 7));(FATrace (TAlt1E 14));(FATrace (TSmbS 16))|]
|];
   ToStateID   = 6;
}
;{ 
   FromStateID = 4;
   Symbol      = (DSymbol "e");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 8));(FATrace (TSeqE 9));(FATrace (TAlt1E 12));(FATrace (TAlt2E 15));(FATrace (TSmbS 16))|]
|];
   ToStateID   = 6;
}
;{ 
   FromStateID = 5;
   Symbol      = (DSymbol "e");
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 10));(FATrace (TSeqE 11));(FATrace (TAlt2E 13));(FATrace (TAlt2E 15));(FATrace (TSmbS 16))|]
|];
   ToStateID   = 6;
}
;{ 
   FromStateID = 6;
   Symbol      = Dummy;
   Label       = Set.ofArray [|List.ofArray [|(FATrace (TSmbE 16));(FATrace (TSeqE 17));(FATrace (TAlt2E 19))|]
|];
   ToStateID   = 8;
}
|];
}
)|]

let gotoSet = 
    Set.ofArray [|(("e",0,"NUMBER"),Set.ofArray [|("e",1)|]);(("e",0,"e"),Set.ofArray [|("e",2)|]);(("e",1,"Dummy"),Set.ofArray [|("e",7)|]);(("e",2,"MINUS"),Set.ofArray [|("e",5)|]);(("e",2,"MULT"),Set.ofArray [|("e",4)|]);(("e",2,"PLUS"),Set.ofArray [|("e",3)|]);(("e",3,"NUMBER"),Set.ofArray [|("e",1)|]);(("e",3,"e"),Set.ofArray [|("e",2);("e",6)|]);(("e",4,"NUMBER"),Set.ofArray [|("e",1)|]);(("e",4,"e"),Set.ofArray [|("e",2);("e",6)|]);(("e",5,"NUMBER"),Set.ofArray [|("e",1)|]);(("e",5,"e"),Set.ofArray [|("e",2);("e",6)|]);(("e",6,"Dummy"),Set.ofArray [|("e",8)|]);(("raccStart",0,"NUMBER"),Set.ofArray [|("e",1)|]);(("raccStart",0,"e"),Set.ofArray [|("e",2);("s",1)|]);(("raccStart",0,"s"),Set.ofArray [|("raccStart",1)|]);(("raccStart",1,"Dummy"),Set.ofArray [|("raccStart",2)|]);(("s",0,"NUMBER"),Set.ofArray [|("e",1)|]);(("s",0,"e"),Set.ofArray [|("e",2);("s",1)|]);(("s",1,"Dummy"),Set.ofArray [|("s",2)|])|]
    |> dict
