
# 2 "Calc.yrd.fs"
module RNGLR.ParseCalc
#nowarn "64";; // From fsyacc: turn off warnings that type variables used in production annotations are instantiated to concrete type
open Yard.Generators.RNGLR.Parser
open Yard.Generators.RNGLR
open Yard.Generators.RNGLR.AST
type Token =
    | DIV of (int)
    | LBRACE of (int)
    | MINUS of (int)
    | MULT of (int)
    | NUMBER of (int)
    | PLUS of (int)
    | POW of (int)
    | RBRACE of (int)
    | RNGLR_EOF of (int)

let genLiteral (str : string) posStart posEnd =
    match str.ToLower() with
    | x -> failwithf "Literal %s undefined" x
let tokenData = function
    | DIV x -> box x
    | LBRACE x -> box x
    | MINUS x -> box x
    | MULT x -> box x
    | NUMBER x -> box x
    | PLUS x -> box x
    | POW x -> box x
    | RBRACE x -> box x
    | RNGLR_EOF x -> box x

let numToString = function
    | 0 -> "error"
    | 1 -> "expr"
    | 2 -> "factor"
    | 3 -> "factorOp"
    | 4 -> "powExpr"
    | 5 -> "powOp"
    | 6 -> "term"
    | 7 -> "termOp"
    | 8 -> "yard_rule_binExpr_1"
    | 9 -> "yard_rule_binExpr_3"
    | 10 -> "yard_rule_binExpr_5"
    | 11 -> "yard_rule_yard_many_1_2"
    | 12 -> "yard_rule_yard_many_1_4"
    | 13 -> "yard_rule_yard_many_1_6"
    | 14 -> "yard_start_rule"
    | 15 -> "DIV"
    | 16 -> "LBRACE"
    | 17 -> "MINUS"
    | 18 -> "MULT"
    | 19 -> "NUMBER"
    | 20 -> "PLUS"
    | 21 -> "POW"
    | 22 -> "RBRACE"
    | 23 -> "RNGLR_EOF"
    | _ -> ""

let tokenToNumber = function
    | DIV _ -> 15
    | LBRACE _ -> 16
    | MINUS _ -> 17
    | MULT _ -> 18
    | NUMBER _ -> 19
    | PLUS _ -> 20
    | POW _ -> 21
    | RBRACE _ -> 22
    | RNGLR_EOF _ -> 23

let isLiteral = function
    | DIV _ -> false
    | LBRACE _ -> false
    | MINUS _ -> false
    | MULT _ -> false
    | NUMBER _ -> false
    | PLUS _ -> false
    | POW _ -> false
    | RBRACE _ -> false
    | RNGLR_EOF _ -> false

let getLiteralNames = []
let mutable private cur = 0
let leftSide = [|1; 14; 8; 11; 11; 7; 7; 6; 9; 12; 12; 3; 3; 2; 10; 13; 13; 5; 4; 4|]
let private rules = [|8; 1; 6; 11; 7; 6; 11; 20; 17; 9; 2; 12; 3; 2; 12; 18; 15; 10; 4; 13; 5; 4; 13; 21; 19; 16; 1; 22|]
let private rulesStart = [|0; 1; 2; 4; 4; 7; 8; 9; 10; 12; 12; 15; 16; 17; 18; 20; 20; 23; 24; 25; 28|]
let startRule = 1

let acceptEmptyInput = false

let defaultAstToDot =
    (fun (tree : Yard.Generators.RNGLR.AST.Tree<Token>) -> tree.AstToDot numToString tokenToNumber leftSide)

let private lists_gotos = [|1; 2; 8; 44; 50; 48; 42; 13; 40; 3; 43; 6; 7; 4; 5; 9; 41; 12; 10; 11; 14; 16; 20; 27; 37; 33; 34; 24; 35; 15; 17; 39; 18; 19; 21; 38; 22; 23; 25; 26; 28; 36; 31; 32; 29; 30; 45; 49; 46; 47|]
let private small_gotos =
        [|9; 65536; 131073; 262146; 393219; 524292; 589829; 655366; 1048583; 1245192; 131076; 196617; 786442; 983051; 1179660; 196613; 131085; 262146; 655366; 1048583; 1245192; 262148; 196617; 786446; 983051; 1179660; 524291; 327695; 851984; 1376273; 589827; 262162; 1048583; 1245192; 655363; 327695; 851987; 1376273; 851977; 65556; 131093; 262166; 393239; 524312; 589849; 655386; 1048603; 1245212; 917505; 1441821; 1048580; 196638; 786463; 983051; 1179660; 1114117; 131104; 262166; 655386; 1048603; 1245212; 1179652; 196638; 786465; 983051; 1179660; 1310723; 327714; 852003; 1376273; 1376259; 262180; 1048603; 1245212; 1441795; 327714; 852005; 1376273; 1572873; 65574; 131093; 262166; 393239; 524312; 589849; 655386; 1048603; 1245212; 1638401; 1441831; 1769476; 458792; 720937; 1114154; 1310763; 1835015; 131093; 262166; 393260; 589849; 655386; 1048603; 1245212; 1900548; 458792; 720941; 1114154; 1310763; 2883588; 458798; 720943; 1114154; 1310763; 2949127; 131073; 262146; 393264; 589829; 655366; 1048583; 1245192; 3014660; 458798; 720945; 1114154; 1310763|]
let gotos = Array.zeroCreate 51
for i = 0 to 50 do
        gotos.[i] <- Array.zeroCreate 24
cur <- 0
while cur < small_gotos.Length do
    let i = small_gotos.[cur] >>> 16
    let length = small_gotos.[cur] &&& 65535
    cur <- cur + 1
    for k = 0 to length-1 do
        let j = small_gotos.[cur + k] >>> 16
        let x = small_gotos.[cur + k] &&& 65535
        gotos.[i].[j] <- lists_gotos.[x]
    cur <- cur + length
let private lists_reduces = [|[|8,1|]; [|10,2|]; [|10,3|]; [|12,1|]; [|11,1|]; [|14,1|]; [|16,2|]; [|16,3|]; [|17,1|]; [|19,3|]; [|2,1|]; [|4,2|]; [|4,3|]; [|6,1|]; [|5,1|]; [|7,1|]; [|13,1|]; [|18,1|]; [|2,2|]; [|0,1|]; [|14,2|]; [|8,2|]|]
let private small_reduces =
        [|131075; 1114112; 1310720; 1507328; 262147; 1114113; 1310721; 1507329; 327683; 1114114; 1310722; 1507330; 393218; 1048579; 1245187; 458754; 1048580; 1245188; 524293; 983045; 1114117; 1179653; 1310725; 1507333; 655365; 983046; 1114118; 1179654; 1310726; 1507334; 720901; 983047; 1114119; 1179655; 1310727; 1507335; 786434; 1048584; 1245192; 983046; 983049; 1114121; 1179657; 1310729; 1376265; 1507337; 1048579; 1114112; 1310720; 1441792; 1179651; 1114113; 1310721; 1441793; 1245187; 1114114; 1310722; 1441794; 1310725; 983045; 1114117; 1179653; 1310725; 1441797; 1441797; 983046; 1114118; 1179654; 1310726; 1441798; 1507333; 983047; 1114119; 1179655; 1310727; 1441799; 1703942; 983049; 1114121; 1179657; 1310729; 1376265; 1441801; 1769473; 1441802; 1900545; 1441803; 1966081; 1441804; 2031618; 1048589; 1245197; 2097154; 1048590; 1245198; 2162691; 1114127; 1310735; 1441807; 2228229; 983056; 1114128; 1179664; 1310736; 1441808; 2293766; 983057; 1114129; 1179665; 1310737; 1376273; 1441809; 2359297; 1441810; 2424833; 1441811; 2490373; 983060; 1114132; 1179668; 1310740; 1441812; 2555907; 1114133; 1310741; 1441813; 2621446; 983057; 1114129; 1179665; 1310737; 1376273; 1507345; 2686981; 983060; 1114132; 1179668; 1310740; 1507348; 2752517; 983056; 1114128; 1179664; 1310736; 1507344; 2818051; 1114133; 1310741; 1507349; 2883585; 1507338; 3014657; 1507339; 3080193; 1507340; 3145731; 1114127; 1310735; 1507343; 3211265; 1507346; 3276801; 1507347|]
let reduces = Array.zeroCreate 51
for i = 0 to 50 do
        reduces.[i] <- Array.zeroCreate 24
cur <- 0
while cur < small_reduces.Length do
    let i = small_reduces.[cur] >>> 16
    let length = small_reduces.[cur] &&& 65535
    cur <- cur + 1
    for k = 0 to length-1 do
        let j = small_reduces.[cur + k] >>> 16
        let x = small_reduces.[cur + k] &&& 65535
        reduces.[i].[j] <- lists_reduces.[x]
    cur <- cur + length
let private lists_zeroReduces = [|[|9|]; [|15|]; [|3|]|]
let private small_zeroReduces =
        [|131075; 1114112; 1310720; 1507328; 262147; 1114112; 1310720; 1507328; 524293; 983041; 1114113; 1179649; 1310721; 1507329; 655365; 983041; 1114113; 1179649; 1310721; 1507329; 1048579; 1114112; 1310720; 1441792; 1179651; 1114112; 1310720; 1441792; 1310725; 983041; 1114113; 1179649; 1310721; 1441793; 1441797; 983041; 1114113; 1179649; 1310721; 1441793; 1769473; 1441794; 1900545; 1441794; 2883585; 1507330; 3014657; 1507330|]
let zeroReduces = Array.zeroCreate 51
for i = 0 to 50 do
        zeroReduces.[i] <- Array.zeroCreate 24
cur <- 0
while cur < small_zeroReduces.Length do
    let i = small_zeroReduces.[cur] >>> 16
    let length = small_zeroReduces.[cur] &&& 65535
    cur <- cur + 1
    for k = 0 to length-1 do
        let j = small_zeroReduces.[cur + k] >>> 16
        let x = small_zeroReduces.[cur + k] &&& 65535
        zeroReduces.[i].[j] <- lists_zeroReduces.[x]
    cur <- cur + length
let private small_acc = [1]
let private accStates = Array.zeroCreate 51
for i = 0 to 50 do
        accStates.[i] <- List.exists ((=) i) small_acc
let eofIndex = 23
let errorIndex = 0
let errorRulesExists = false
let private parserSource = new ParserSource<Token> (gotos, reduces, zeroReduces, accStates, rules, rulesStart, leftSide, startRule, eofIndex, tokenToNumber, acceptEmptyInput, numToString, errorIndex, errorRulesExists)
let buildAstAbstract : (seq<int*array<'TokenType*int>> -> ParseResult<Token>) =
    buildAstAbstract<Token> parserSource

let buildAst : (seq<'TokenType> -> ParseResult<Token>) =
    buildAst<Token> parserSource

let _rnglr_epsilons : Tree<Token>[] = [|new Tree<_>(null,box (new AST(new Family(20, new Nodes([||])), null)), null); null; null; null; null; null; null; null; null; null; null; new Tree<_>(null,box (new AST(new Family(3, new Nodes([||])), null)), null); new Tree<_>(null,box (new AST(new Family(9, new Nodes([||])), null)), null); new Tree<_>(null,box (new AST(new Family(15, new Nodes([||])), null)), null); null|]
let _rnglr_filtered_epsilons : Tree<Token>[] = [|new Tree<_>(null,box (new AST(new Family(20, new Nodes([||])), null)), null); null; null; null; null; null; null; null; null; null; null; new Tree<_>(null,box (new AST(new Family(3, new Nodes([||])), null)), null); new Tree<_>(null,box (new AST(new Family(9, new Nodes([||])), null)), null); new Tree<_>(null,box (new AST(new Family(15, new Nodes([||])), null)), null); null|]
for x in _rnglr_filtered_epsilons do if x <> null then x.ChooseSingleAst()
let _rnglr_extra_array, _rnglr_rule_, _rnglr_concats = 
  (Array.zeroCreate 0 : array<'_rnglr_type_error * '_rnglr_type_expr * '_rnglr_type_factor * '_rnglr_type_factorOp * '_rnglr_type_powExpr * '_rnglr_type_powOp * '_rnglr_type_term * '_rnglr_type_termOp * '_rnglr_type_yard_rule_binExpr_1 * '_rnglr_type_yard_rule_binExpr_3 * '_rnglr_type_yard_rule_binExpr_5 * '_rnglr_type_yard_rule_yard_many_1_2 * '_rnglr_type_yard_rule_yard_many_1_4 * '_rnglr_type_yard_rule_yard_many_1_6 * '_rnglr_type_yard_start_rule>), 
  [|
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            ((unbox _rnglr_children.[0]) : '_rnglr_type_yard_rule_binExpr_1) 
             |> List.iter (fun (res) -> 
              _rnglr_cycle_res := (
                
# 19 "Calc.yrd"
                                                 res 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 19 "Calc.yrd"
               : '_rnglr_type_expr) 
# 180 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          ((unbox _rnglr_children.[0]) : '_rnglr_type_expr) 
            )
# 19 "Calc.yrd"
               : '_rnglr_type_yard_start_rule) 
# 190 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            ((unbox _rnglr_children.[0]) : '_rnglr_type_term) 
             |> List.iter (fun (l) -> 
              ((unbox _rnglr_children.[1]) : '_rnglr_type_yard_rule_yard_many_1_2) l
               |> List.iter (fun (r) -> 
                _rnglr_cycle_res := (
                  
# 16 "Calc.yrd"
                     List.fold (fun l (op,r) -> op l r) l r 
                    )::!_rnglr_cycle_res ) )
            !_rnglr_cycle_res
          )
            )
# 14 "Calc.yrd"
               : '_rnglr_type_yard_rule_binExpr_1) 
# 212 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( fun l ->
          (
            let _rnglr_cycle_res = ref []
            _rnglr_cycle_res := (
              
# 15 "Calc.yrd"
                                []
                )::!_rnglr_cycle_res
            !_rnglr_cycle_res
          )
            )
# 15 "Calc.yrd"
               : '_rnglr_type_yard_rule_yard_many_1_2) 
# 230 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( fun l ->
          (
            let _rnglr_cycle_res = ref []
            (
              let _rnglr_cycle_res = ref []
              ((unbox _rnglr_children.[0]) : '_rnglr_type_termOp) 
               |> List.iter (fun (op) -> 
                ((unbox _rnglr_children.[1]) : '_rnglr_type_term) 
                 |> List.iter (fun (r) -> 
                  _rnglr_cycle_res := (
                    
# 15 "Calc.yrd"
                                                        op,r 
                      )::!_rnglr_cycle_res ) )
              !_rnglr_cycle_res
            ) |> List.iter (fun (yard_head) -> 
              ((unbox _rnglr_children.[2]) : '_rnglr_type_yard_rule_yard_many_1_2) l
               |> List.iter (fun (yard_tail) -> 
                _rnglr_cycle_res := (
                  
# 15 "Calc.yrd"
                                    yard_head::yard_tail
                    )::!_rnglr_cycle_res ) )
            !_rnglr_cycle_res
          )
            )
# 15 "Calc.yrd"
               : '_rnglr_type_yard_rule_yard_many_1_2) 
# 263 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            (match ((unbox _rnglr_children.[0]) : Token) with PLUS _rnglr_val -> [_rnglr_val] | a -> failwith "PLUS expected, but %A found" a )
             |> List.iter (fun (_) -> 
              _rnglr_cycle_res := (
                
# 21 "Calc.yrd"
                               (+) 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 21 "Calc.yrd"
               : '_rnglr_type_termOp) 
# 283 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            (match ((unbox _rnglr_children.[0]) : Token) with MINUS _rnglr_val -> [_rnglr_val] | a -> failwith "MINUS expected, but %A found" a )
             |> List.iter (fun (_) -> 
              _rnglr_cycle_res := (
                
# 21 "Calc.yrd"
                                               (-) 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 21 "Calc.yrd"
               : '_rnglr_type_termOp) 
# 303 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            ((unbox _rnglr_children.[0]) : '_rnglr_type_yard_rule_binExpr_3) 
             |> List.iter (fun (res) -> 
              _rnglr_cycle_res := (
                
# 23 "Calc.yrd"
                                                     res 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 23 "Calc.yrd"
               : '_rnglr_type_term) 
# 323 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            ((unbox _rnglr_children.[0]) : '_rnglr_type_factor) 
             |> List.iter (fun (l) -> 
              ((unbox _rnglr_children.[1]) : '_rnglr_type_yard_rule_yard_many_1_4) l
               |> List.iter (fun (r) -> 
                _rnglr_cycle_res := (
                  
# 16 "Calc.yrd"
                     List.fold (fun l (op,r) -> op l r) l r 
                    )::!_rnglr_cycle_res ) )
            !_rnglr_cycle_res
          )
            )
# 14 "Calc.yrd"
               : '_rnglr_type_yard_rule_binExpr_3) 
# 345 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( fun l ->
          (
            let _rnglr_cycle_res = ref []
            _rnglr_cycle_res := (
              
# 15 "Calc.yrd"
                                []
                )::!_rnglr_cycle_res
            !_rnglr_cycle_res
          )
            )
# 15 "Calc.yrd"
               : '_rnglr_type_yard_rule_yard_many_1_4) 
# 363 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( fun l ->
          (
            let _rnglr_cycle_res = ref []
            (
              let _rnglr_cycle_res = ref []
              ((unbox _rnglr_children.[0]) : '_rnglr_type_factorOp) 
               |> List.iter (fun (op) -> 
                ((unbox _rnglr_children.[1]) : '_rnglr_type_factor) 
                 |> List.iter (fun (r) -> 
                  _rnglr_cycle_res := (
                    
# 15 "Calc.yrd"
                                                        op,r 
                      )::!_rnglr_cycle_res ) )
              !_rnglr_cycle_res
            ) |> List.iter (fun (yard_head) -> 
              ((unbox _rnglr_children.[2]) : '_rnglr_type_yard_rule_yard_many_1_4) l
               |> List.iter (fun (yard_tail) -> 
                _rnglr_cycle_res := (
                  
# 15 "Calc.yrd"
                                    yard_head::yard_tail
                    )::!_rnglr_cycle_res ) )
            !_rnglr_cycle_res
          )
            )
# 15 "Calc.yrd"
               : '_rnglr_type_yard_rule_yard_many_1_4) 
# 396 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            (match ((unbox _rnglr_children.[0]) : Token) with MULT _rnglr_val -> [_rnglr_val] | a -> failwith "MULT expected, but %A found" a )
             |> List.iter (fun (_) -> 
              _rnglr_cycle_res := (
                
# 25 "Calc.yrd"
                                 ( * ) 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 25 "Calc.yrd"
               : '_rnglr_type_factorOp) 
# 416 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            (match ((unbox _rnglr_children.[0]) : Token) with DIV _rnglr_val -> [_rnglr_val] | a -> failwith "DIV expected, but %A found" a )
             |> List.iter (fun (_) -> 
              _rnglr_cycle_res := (
                
# 25 "Calc.yrd"
                                                 (/) 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 25 "Calc.yrd"
               : '_rnglr_type_factorOp) 
# 436 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            ((unbox _rnglr_children.[0]) : '_rnglr_type_yard_rule_binExpr_5) 
             |> List.iter (fun (res) -> 
              _rnglr_cycle_res := (
                
# 27 "Calc.yrd"
                                                     res 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 27 "Calc.yrd"
               : '_rnglr_type_factor) 
# 456 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            ((unbox _rnglr_children.[0]) : '_rnglr_type_powExpr) 
             |> List.iter (fun (l) -> 
              ((unbox _rnglr_children.[1]) : '_rnglr_type_yard_rule_yard_many_1_6) l
               |> List.iter (fun (r) -> 
                _rnglr_cycle_res := (
                  
# 16 "Calc.yrd"
                     List.fold (fun l (op,r) -> op l r) l r 
                    )::!_rnglr_cycle_res ) )
            !_rnglr_cycle_res
          )
            )
# 14 "Calc.yrd"
               : '_rnglr_type_yard_rule_binExpr_5) 
# 478 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( fun l ->
          (
            let _rnglr_cycle_res = ref []
            _rnglr_cycle_res := (
              
# 15 "Calc.yrd"
                                []
                )::!_rnglr_cycle_res
            !_rnglr_cycle_res
          )
            )
# 15 "Calc.yrd"
               : '_rnglr_type_yard_rule_yard_many_1_6) 
# 496 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( fun l ->
          (
            let _rnglr_cycle_res = ref []
            (
              let _rnglr_cycle_res = ref []
              ((unbox _rnglr_children.[0]) : '_rnglr_type_powOp) 
               |> List.iter (fun (op) -> 
                ((unbox _rnglr_children.[1]) : '_rnglr_type_powExpr) 
                 |> List.iter (fun (r) -> 
                  _rnglr_cycle_res := (
                    
# 15 "Calc.yrd"
                                                        op,r 
                      )::!_rnglr_cycle_res ) )
              !_rnglr_cycle_res
            ) |> List.iter (fun (yard_head) -> 
              ((unbox _rnglr_children.[2]) : '_rnglr_type_yard_rule_yard_many_1_6) l
               |> List.iter (fun (yard_tail) -> 
                _rnglr_cycle_res := (
                  
# 15 "Calc.yrd"
                                    yard_head::yard_tail
                    )::!_rnglr_cycle_res ) )
            !_rnglr_cycle_res
          )
            )
# 15 "Calc.yrd"
               : '_rnglr_type_yard_rule_yard_many_1_6) 
# 529 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            (match ((unbox _rnglr_children.[0]) : Token) with POW _rnglr_val -> [_rnglr_val] | a -> failwith "POW expected, but %A found" a )
             |> List.iter (fun (_) -> 
              _rnglr_cycle_res := (
                
# 29 "Calc.yrd"
                             (fun x y -> (float x ** float y) |> int) 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 29 "Calc.yrd"
               : '_rnglr_type_powOp) 
# 549 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            (match ((unbox _rnglr_children.[0]) : Token) with NUMBER _rnglr_val -> [_rnglr_val] | a -> failwith "NUMBER expected, but %A found" a )
             |> List.iter (fun (n) -> 
              _rnglr_cycle_res := (
                
# 31 "Calc.yrd"
                                    n 
                  )::!_rnglr_cycle_res )
            !_rnglr_cycle_res
          )
            )
# 31 "Calc.yrd"
               : '_rnglr_type_powExpr) 
# 569 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            (match ((unbox _rnglr_children.[0]) : Token) with LBRACE _rnglr_val -> [_rnglr_val] | a -> failwith "LBRACE expected, but %A found" a )
             |> List.iter (fun (_) -> 
              ((unbox _rnglr_children.[1]) : '_rnglr_type_expr) 
               |> List.iter (fun (e) -> 
                (match ((unbox _rnglr_children.[2]) : Token) with RBRACE _rnglr_val -> [_rnglr_val] | a -> failwith "RBRACE expected, but %A found" a )
                 |> List.iter (fun (_) -> 
                  _rnglr_cycle_res := (
                    
# 31 "Calc.yrd"
                                                                     e 
                      )::!_rnglr_cycle_res ) ) )
            !_rnglr_cycle_res
          )
            )
# 31 "Calc.yrd"
               : '_rnglr_type_powExpr) 
# 593 "Calc.yrd.fs"
      );
  (
    fun (_rnglr_children : array<_>) (parserRange : (int * int)) -> 
      box (
        ( 
          (
            let _rnglr_cycle_res = ref []
            _rnglr_cycle_res := (
              

              parserRange
                )::!_rnglr_cycle_res
            !_rnglr_cycle_res
          )
            )

               : '_rnglr_type_error) 
# 611 "Calc.yrd.fs"
      );
  |] , [|
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_error)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_expr)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_factor)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_factorOp)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_powExpr)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_powOp)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_term)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_termOp)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_yard_rule_binExpr_1)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_yard_rule_binExpr_3)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_yard_rule_binExpr_5)   ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( fun l ->
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_yard_rule_yard_many_1_2)  l ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( fun l ->
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_yard_rule_yard_many_1_4)  l ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( fun l ->
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_yard_rule_yard_many_1_6)  l ) |> List.concat));
    (fun (_rnglr_list : list<_>) -> 
      box ( 
        _rnglr_list |> List.map (fun _rnglr_item -> ((unbox _rnglr_item) : '_rnglr_type_yard_start_rule)   ) |> List.concat));
  |] 
let translate (args : TranslateArguments<_,_>) (tree : Tree<_>) : '_rnglr_type_yard_start_rule = 
  unbox (tree.Translate _rnglr_rule_  leftSide _rnglr_concats (if args.filterEpsilons then _rnglr_filtered_epsilons else _rnglr_epsilons) args.tokenToRange args.zeroPosition args.clearAST) : '_rnglr_type_yard_start_rule