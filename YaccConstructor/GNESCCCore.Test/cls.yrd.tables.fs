//this tables was generated by GNESCC
//source grammar:../../../Tests/GNESCC/regexp/simple/cls/cls.yrd
//date:12/7/2011 11:30:10

module Yard.Generators.GNESCCGenerator.Tables_cls

open Yard.Generators.GNESCCGenerator
open Yard.Generators.GNESCCGenerator.CommonTypes

type symbol =
    | T_MULT
    | NT_s
    | NT_gnesccStart
let getTag smb =
    match smb with
    | T_MULT -> 5
    | NT_s -> 4
    | NT_gnesccStart -> 2
let getName tag =
    match tag with
    | 5 -> T_MULT
    | 4 -> NT_s
    | 2 -> NT_gnesccStart
    | _ -> failwith "getName: bad tag."
let prodToNTerm = 
  [| 1; 0 |];
let symbolIdx = 
  [| 1; 2; 1; 3; 0; 0 |];
let startKernelIdxs =  [0]
let isStart =
  [| [| true; true |];
     [| false; false |];
     [| false; false |]; |]
let gotoTable =
  [| [| Some 1; None |];
     [| None; None |];
     [| None; None |]; |]
let actionTable = 
  [| [| [Shift 2]; [Reduce 1]; [Reduce 1] |];
     [| [Accept]; [Accept]; [Accept] |];
     [| [Shift 2]; [Reduce 1]; [Reduce 1] |]; |]
let tables = 
  {StartIdx=startKernelIdxs
   SymbolIdx=symbolIdx
   GotoTable=gotoTable
   ActionTable=actionTable
   IsStart=isStart
   ProdToNTerm=prodToNTerm}
