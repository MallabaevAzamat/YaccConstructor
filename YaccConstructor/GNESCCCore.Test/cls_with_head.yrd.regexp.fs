//this file was generated by GNESCC
//source grammar:../../../Tests/GNESCC/regexp/complex/cls_with_head/cls_with_head.yrd
//date:12/7/2011 11:30:09

module GNESCC.Regexp_cls_with_head

open Yard.Generators.GNESCCGenerator
open System.Text.RegularExpressions

let buildIndexMap kvLst =
    let ks = List.map (fun (x:string,y) -> x.Length + 2,y) kvLst
    List.fold (fun (bl,blst) (l,v) -> bl+l,((bl,v)::blst)) (0,[]) ks
    |> snd
    |> dict

let buildStr kvLst =
    let sep = ";;"
    List.map fst kvLst 
    |> String.concat sep
    |> fun s -> ";" + s + ";"

let s childsLst = 
    let str = buildStr childsLst
    let idxValMap = buildIndexMap childsLst
    let re = new Regex("((;5;)(((;5;)))*)")
    let elts =
        let res = re.Match(str)
        if Seq.fold (&&) true [for g in res.Groups -> g.Success]
        then res.Groups
        else (new Regex("((;5;)(((;5;)))*)",RegexOptions.RightToLeft)).Match(str).Groups
    let e1 =
        let ofset = ref 0
        let e i =
            let str = elts.[3].Captures.[i].Value
            let re = new Regex("((;5;))")
            let elts =
                let res = re.Match(str)
                if Seq.fold (&&) true [for g in res.Groups -> g.Success]
                then res.Groups
                else (new Regex("((;5;))",RegexOptions.RightToLeft)).Match(str).Groups
            let res =
                let e0 =
                    idxValMap.[!ofset + elts.[2].Captures.[0].Index] |> RELeaf
                RESeq [e0]
            ofset := !ofset + str.Length
            res
        REClosure [for i in [0..elts.[3].Captures.Count-1] -> e i]

    let e0 =
        idxValMap.[elts.[2].Captures.[0].Index] |> RELeaf
    RESeq [e0; e1]

let ruleToRegex = dict [|(1,s)|]

