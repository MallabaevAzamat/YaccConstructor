//this file was generated by GNESCC
//source grammar:../../../Tests/GNESCC/regexp/complex/seq_in_cls_2/seq_in_cls_2.yrd
//date:12/7/2011 11:30:10

module GNESCC.Actions_seq_in_cls_2

open Yard.Generators.GNESCCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith
let s0 expr = 
    let inner  = 
        match expr with
        | RESeq [gnescc_x0] -> 
            let (gnescc_x0) =
                let yardElemAction expr = 
                    match expr with
                    | REClosure(lst) -> 
                        let yardClsAction expr = 
                            match expr with
                            | RESeq [gnescc_x0; gnescc_x1] -> 
                                let (gnescc_x0) =
                                    let yardElemAction expr = 
                                        match expr with
                                        | RELeaf s -> (s :?> _ ) 
                                        | x -> getUnmatched x "RELeaf"

                                    yardElemAction(gnescc_x0)
                                let (gnescc_x1) =
                                    let yardElemAction expr = 
                                        match expr with
                                        | RELeaf tPLUS -> tPLUS :?> 'a
                                        | x -> getUnmatched x "RELeaf"

                                    yardElemAction(gnescc_x1)
                                (gnescc_x0,gnescc_x1 )
                            | x -> getUnmatched x "RESeq"

                        List.map yardClsAction lst 
                    | x -> getUnmatched x "REClosure"

                yardElemAction(gnescc_x0)
            (gnescc_x0 )
        | x -> getUnmatched x "RESeq"
    box (inner)

let ruleToAction = dict [|(1,s0)|]

