//this tables was generated by GNESCC
//source grammar:../../../Tests/GNESCC/test_4/test_4.yrd
//date:12/7/2011 11:30:10

module Yard.Generators.GNESCCGenerator.Tables_test_4

open Yard.Generators.GNESCCGenerator
open Yard.Generators.GNESCCGenerator.CommonTypes

type symbol =
    | T_MULT
    | NT_m
    | NT_e
    | NT_s
    | NT_gnesccStart
let getTag smb =
    match smb with
    | T_MULT -> 7
    | NT_m -> 6
    | NT_e -> 5
    | NT_s -> 4
    | NT_gnesccStart -> 2
let getName tag =
    match tag with
    | 7 -> T_MULT
    | 6 -> NT_m
    | 5 -> NT_e
    | 4 -> NT_s
    | 2 -> NT_gnesccStart
    | _ -> failwith "getName: bad tag."
let prodToNTerm = 
  [| 3; 2; 1; 0 |];
let symbolIdx = 
  [| 1; 2; 3; 3; 2; 1; 0; 0 |];
let startKernelIdxs =  [0]
let isStart =
  [| [| true; true; true; true |];
     [| false; false; false; false |];
     [| false; false; true; true |];
     [| false; false; false; false |];
     [| false; false; false; false |]; |]
let gotoTable =
  [| [| Some 3; Some 2; Some 1; None |];
     [| None; None; None; None |];
     [| Some 3; Some 2; None; None |];
     [| None; None; None; None |];
     [| None; None; None; None |]; |]
let actionTable = 
  [| [| [Shift 4]; [Reduce 1]; [Reduce 1] |];
     [| [Accept]; [Accept]; [Accept] |];
     [| [Shift 4]; [Reduce 1]; [Reduce 1] |];
     [| [Reduce 2]; [Reduce 2]; [Reduce 2] |];
     [| [Reduce 3]; [Reduce 3]; [Reduce 3] |]; |]
let tables = 
  {StartIdx=startKernelIdxs
   SymbolIdx=symbolIdx
   GotoTable=gotoTable
   ActionTable=actionTable
   IsStart=isStart
   ProdToNTerm=prodToNTerm}
