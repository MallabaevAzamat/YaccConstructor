//this file was generated by GNESCC
//source grammar:../../../Tests/GNESCC/recursive_rules/test_rec_rule_3/test_rec_rule_3.yrd
//date:12/7/2011 11:30:09

module GNESCC.Actions_test_rec_rule_3

open Yard.Generators.GNESCCGenerator

let getUnmatched x expectedType =
    "Unexpected type of node\nType " + x.ToString() + " is not expected in this position\n" + expectedType + " was expected." |> failwith
let s0 expr = 
    let inner  = 
        match expr with
        | RESeq [gnescc_x0; gnescc_x1; gnescc_x2] -> 
            let (gnescc_x0) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tPLUS -> tPLUS :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(gnescc_x0)
            let (gnescc_x1) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf s -> (s :?> _ ) 
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(gnescc_x1)
            let (gnescc_x2) =
                let yardElemAction expr = 
                    match expr with
                    | RELeaf tPLUS -> tPLUS :?> 'a
                    | x -> getUnmatched x "RELeaf"

                yardElemAction(gnescc_x2)
            (gnescc_x0,gnescc_x1,gnescc_x2 )
        | x -> getUnmatched x "RESeq"
    box (inner)

let ruleToAction = dict [|(1,s0)|]

