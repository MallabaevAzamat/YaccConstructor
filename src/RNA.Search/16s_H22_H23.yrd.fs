
# 2 "16s_H22_H23.yrd.fs"
module GLL.r16s.H22_H23
#nowarn "64";; // From fsyacc: turn off warnings that type variables used in production annotations are instantiated to concrete type
open AbstractAnalysis.Common
open Yard.Generators.GLL
open Yard.Generators.Common.ASTGLL
open Yard.Generators.GLL.ParserCommon
type Token =
    | A of (int)
    | C of (int)
    | G of (int)
    | RNGLR_EOF of (int)
    | U of (int)


let genLiteral (str : string) (data : int) =
    match str.ToLower() with
    | x -> None
let tokenData = function
    | A x -> box x
    | C x -> box x
    | G x -> box x
    | RNGLR_EOF x -> box x
    | U x -> box x

let numToString = function
    | 0 -> "any"
    | 1 -> "any_1_3"
    | 2 -> "any_2_3"
    | 3 -> "error"
    | 4 -> "folded"
    | 5 -> "full"
    | 6 -> "h22"
    | 7 -> "h23"
    | 8 -> "h24"
    | 9 -> "s1"
    | 10 -> "s2"
    | 11 -> "s4"
    | 12 -> "s5"
    | 13 -> "yard_exp_brackets_41"
    | 14 -> "yard_exp_brackets_42"
    | 15 -> "yard_exp_brackets_43"
    | 16 -> "yard_exp_brackets_44"
    | 17 -> "yard_exp_brackets_45"
    | 18 -> "yard_exp_brackets_46"
    | 19 -> "yard_exp_brackets_47"
    | 20 -> "yard_exp_brackets_48"
    | 21 -> "yard_exp_brackets_49"
    | 22 -> "yard_exp_brackets_50"
    | 23 -> "yard_exp_brackets_51"
    | 24 -> "yard_exp_brackets_52"
    | 25 -> "yard_exp_brackets_53"
    | 26 -> "yard_exp_brackets_54"
    | 27 -> "yard_opt_1"
    | 28 -> "yard_rule_gstem_36"
    | 29 -> "yard_rule_stem_32"
    | 30 -> "yard_rule_stem_33"
    | 31 -> "yard_rule_stem_34"
    | 32 -> "yard_rule_stem_35"
    | 33 -> "yard_rule_stem_37"
    | 34 -> "yard_rule_stem_38"
    | 35 -> "yard_rule_stem_39"
    | 36 -> "yard_rule_stem_40"
    | 37 -> "yard_start_rule"
    | 38 -> "A"
    | 39 -> "C"
    | 40 -> "G"
    | 41 -> "RNGLR_EOF"
    | 42 -> "U"
    | _ -> ""

let tokenToNumber = function
    | A _ -> 38
    | C _ -> 39
    | G _ -> 40
    | RNGLR_EOF _ -> 41
    | U _ -> 42

let isLiteral = function
    | A _ -> false
    | C _ -> false
    | G _ -> false
    | RNGLR_EOF _ -> false
    | U _ -> false

let isTerminal = function
    | A _ -> true
    | C _ -> true
    | G _ -> true
    | RNGLR_EOF _ -> true
    | U _ -> true

let numIsTerminal = function
    | 38 -> true
    | 39 -> true
    | 40 -> true
    | 41 -> true
    | 42 -> true
    | _ -> false

let numIsNonTerminal = function
    | 0 -> true
    | 1 -> true
    | 2 -> true
    | 3 -> true
    | 4 -> true
    | 5 -> true
    | 6 -> true
    | 7 -> true
    | 8 -> true
    | 9 -> true
    | 10 -> true
    | 11 -> true
    | 12 -> true
    | 13 -> true
    | 14 -> true
    | 15 -> true
    | 16 -> true
    | 17 -> true
    | 18 -> true
    | 19 -> true
    | 20 -> true
    | 21 -> true
    | 22 -> true
    | 23 -> true
    | 24 -> true
    | 25 -> true
    | 26 -> true
    | 27 -> true
    | 28 -> true
    | 29 -> true
    | 30 -> true
    | 31 -> true
    | 32 -> true
    | 33 -> true
    | 34 -> true
    | 35 -> true
    | 36 -> true
    | 37 -> true
    | _ -> false

let numIsLiteral = function
    | _ -> false

let getLiteralNames = []
let mutable private cur = 0

let acceptEmptyInput = false

let leftSide = [|0; 0; 0; 0; 5; 37; 27; 27; 4; 7; 29; 29; 29; 29; 29; 29; 29; 29; 29; 9; 30; 30; 30; 30; 30; 30; 30; 30; 30; 10; 31; 31; 31; 31; 31; 31; 31; 31; 31; 8; 28; 28; 28; 28; 28; 28; 28; 28; 28; 28; 33; 33; 33; 33; 33; 33; 33; 33; 33; 32; 32; 32; 32; 32; 32; 32; 32; 32; 6; 34; 34; 34; 34; 34; 34; 34; 34; 34; 11; 35; 35; 35; 35; 35; 35; 35; 35; 35; 12; 36; 36; 36; 36; 36; 36; 36; 36; 36; 1; 2; 13; 14; 15; 15; 15; 15; 15; 16; 17; 18; 19; 20; 21; 22; 22; 22; 23; 23; 24; 24; 24; 24; 25; 25; 25; 25; 25; 25; 26; 26; 26; 26; 26|]
let table = new System.Collections.Generic.Dictionary<int, int[]>(146)
table.Add(0, [|0|])
table.Add(4, [|1|])
table.Add(2, [|2|])
table.Add(1, [|3|])
table.Add(327680, [|4|])
table.Add(327681, [|4|])
table.Add(327682, [|4|])
table.Add(327684, [|4|])
table.Add(2424832, [|5|])
table.Add(2424833, [|5|])
table.Add(2424834, [|5|])
table.Add(2424836, [|5|])
table.Add(1769475, [|6|])
table.Add(1769472, [|7|])
table.Add(1769473, [|7|])
table.Add(1769474, [|7|])
table.Add(1769476, [|7|])
table.Add(262144, [|8|])
table.Add(262145, [|8|])
table.Add(262146, [|8|])
table.Add(262148, [|8|])
table.Add(458752, [|9|])
table.Add(458753, [|9|])
table.Add(458754, [|9|])
table.Add(458756, [|9|])
table.Add(1900544, [|10;17;18|])
table.Add(1900548, [|11;15;18|])
table.Add(1900545, [|12;18|])
table.Add(1900546, [|13;14;16;18|])
table.Add(589824, [|19|])
table.Add(589825, [|19|])
table.Add(589826, [|19|])
table.Add(589828, [|19|])
table.Add(1966080, [|20;27;28|])
table.Add(1966084, [|21;25;28|])
table.Add(1966081, [|22;28|])
table.Add(1966082, [|23;24;26;28|])
table.Add(655360, [|29|])
table.Add(655361, [|29|])
table.Add(655362, [|29|])
table.Add(655364, [|29|])
table.Add(2031616, [|30;37;38|])
table.Add(2031620, [|31;35;38|])
table.Add(2031617, [|32;38|])
table.Add(2031618, [|33;34;36;38|])
table.Add(524288, [|39|])
table.Add(524289, [|39|])
table.Add(524290, [|39|])
table.Add(524292, [|39|])
table.Add(1835008, [|40;47;49|])
table.Add(1835012, [|41;45;49|])
table.Add(1835009, [|42;49|])
table.Add(1835010, [|43;44;46;48;49|])
table.Add(2162688, [|50;57;58|])
table.Add(2162692, [|51;55;58|])
table.Add(2162689, [|52;58|])
table.Add(2162690, [|53;54;56;58|])
table.Add(2097152, [|59;66|])
table.Add(2097156, [|60;64|])
table.Add(2097153, [|61|])
table.Add(2097154, [|62;63;65;67|])
table.Add(393216, [|68|])
table.Add(393217, [|68|])
table.Add(393218, [|68|])
table.Add(393220, [|68|])
table.Add(2228224, [|69;76;77|])
table.Add(2228228, [|70;74;77|])
table.Add(2228225, [|71;77|])
table.Add(2228226, [|72;73;75;77|])
table.Add(720896, [|78|])
table.Add(720897, [|78|])
table.Add(720898, [|78|])
table.Add(720900, [|78|])
table.Add(2293760, [|79;86;87|])
table.Add(2293764, [|80;84;87|])
table.Add(2293761, [|81;87|])
table.Add(2293762, [|82;83;85;87|])
table.Add(786432, [|88|])
table.Add(786433, [|88|])
table.Add(786434, [|88|])
table.Add(786436, [|88|])
table.Add(2359296, [|89;96;97|])
table.Add(2359300, [|90;94;97|])
table.Add(2359297, [|91;97|])
table.Add(2359298, [|92;93;95;97|])
table.Add(65536, [|98|])
table.Add(65537, [|98|])
table.Add(65538, [|98|])
table.Add(65540, [|98|])
table.Add(131072, [|99|])
table.Add(131073, [|99|])
table.Add(131074, [|99|])
table.Add(131076, [|99|])
table.Add(851968, [|100|])
table.Add(851969, [|100|])
table.Add(851970, [|100|])
table.Add(851972, [|100|])
table.Add(917504, [|101|])
table.Add(917505, [|101|])
table.Add(917506, [|101|])
table.Add(917508, [|101|])
table.Add(983040, [|102;103;104;105;106|])
table.Add(983041, [|102;103;104;105;106|])
table.Add(983042, [|102;103;104;105;106|])
table.Add(983044, [|102;103;104;105;106|])
table.Add(1048576, [|107|])
table.Add(1048577, [|107|])
table.Add(1048578, [|107|])
table.Add(1048580, [|107|])
table.Add(1114112, [|108|])
table.Add(1114113, [|108|])
table.Add(1114114, [|108|])
table.Add(1114116, [|108|])
table.Add(1179650, [|109|])
table.Add(1245184, [|110|])
table.Add(1245185, [|110|])
table.Add(1245186, [|110|])
table.Add(1245188, [|110|])
table.Add(1310720, [|111|])
table.Add(1310721, [|111|])
table.Add(1310722, [|111|])
table.Add(1310724, [|111|])
table.Add(1376256, [|112|])
table.Add(1376257, [|112|])
table.Add(1376258, [|112|])
table.Add(1376260, [|112|])
table.Add(1441792, [|113;114;115|])
table.Add(1441793, [|113;114;115|])
table.Add(1441794, [|113;114;115|])
table.Add(1441796, [|113;114;115|])
table.Add(1507328, [|116;117|])
table.Add(1507329, [|116;117|])
table.Add(1507330, [|116;117|])
table.Add(1507332, [|116;117|])
table.Add(1572864, [|118;119;120;121|])
table.Add(1572865, [|118;119;120;121|])
table.Add(1572866, [|118;119;120;121|])
table.Add(1572868, [|118;119;120;121|])
table.Add(1638400, [|122;123;124;125;126;127|])
table.Add(1638401, [|122;123;124;125;126;127|])
table.Add(1638402, [|122;123;124;125;126;127|])
table.Add(1638404, [|122;123;124;125;126;127|])
table.Add(1703936, [|128;129;130;131;132|])
table.Add(1703937, [|128;129;130;131;132|])
table.Add(1703938, [|128;129;130;131;132|])
table.Add(1703940, [|128;129;130;131;132|])

let private rules = [|38; 42; 40; 39; 4; 27; 5; 41; 0; 6; 29; 38; 29; 42; 42; 29; 38; 39; 29; 40; 40; 29; 39; 40; 29; 42; 42; 29; 40; 40; 29; 38; 38; 29; 40; 13; 30; 38; 30; 42; 42; 30; 38; 39; 30; 40; 40; 30; 39; 40; 30; 42; 42; 30; 40; 40; 30; 38; 38; 30; 40; 14; 31; 38; 31; 42; 42; 31; 38; 39; 31; 40; 40; 31; 39; 40; 31; 42; 42; 31; 40; 40; 31; 38; 38; 31; 40; 15; 28; 38; 33; 42; 42; 33; 38; 39; 33; 40; 40; 33; 39; 40; 33; 42; 42; 33; 40; 40; 33; 38; 38; 33; 40; 40; 33; 40; 16; 38; 33; 42; 42; 33; 38; 39; 33; 40; 40; 33; 39; 40; 33; 42; 42; 33; 40; 40; 33; 38; 38; 33; 40; 17; 38; 32; 42; 42; 32; 38; 39; 32; 40; 40; 32; 39; 40; 32; 42; 42; 32; 40; 40; 32; 38; 38; 32; 40; 18; 34; 38; 34; 42; 42; 34; 38; 39; 34; 40; 40; 34; 39; 40; 34; 42; 42; 34; 40; 40; 34; 38; 38; 34; 40; 19; 35; 38; 35; 42; 42; 35; 38; 39; 35; 40; 40; 35; 39; 40; 35; 42; 42; 35; 40; 40; 35; 38; 38; 35; 40; 20; 36; 38; 36; 42; 42; 36; 38; 39; 36; 40; 40; 36; 39; 40; 36; 42; 42; 36; 40; 40; 36; 38; 38; 36; 40; 21; 22; 23; 1; 9; 1; 24; 10; 25; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 1; 32; 1; 32; 40; 38; 38; 40; 11; 0; 1; 12; 1; 7; 26; 8; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0|]
let private canInferEpsilon = [|false; false; false; true; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false; true; false; false; false; false; false; false; false; false; false; false; false; false; false; false; false|]
let defaultAstToDot =
    (fun (tree : Yard.Generators.Common.ASTGLL.Tree<Token>) -> tree.AstToDot numToString)

let private rulesStart = [|0; 1; 2; 3; 4; 6; 8; 8; 9; 10; 11; 14; 17; 20; 23; 26; 29; 32; 35; 36; 37; 40; 43; 46; 49; 52; 55; 58; 61; 62; 63; 66; 69; 72; 75; 78; 81; 84; 87; 88; 89; 92; 95; 98; 101; 104; 107; 110; 113; 116; 117; 120; 123; 126; 129; 132; 135; 138; 141; 142; 145; 148; 151; 154; 157; 160; 163; 166; 167; 168; 171; 174; 177; 180; 183; 186; 189; 192; 193; 194; 197; 200; 203; 206; 209; 212; 215; 218; 219; 220; 223; 226; 229; 232; 235; 238; 241; 244; 245; 246; 247; 250; 253; 257; 262; 268; 275; 283; 285; 287; 291; 293; 296; 299; 300; 302; 305; 307; 310; 311; 313; 316; 320; 322; 325; 329; 334; 340; 347; 350; 354; 359; 365; 372|]
let private probabilities = [|1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0; 1.0|]
let startRule = 5
let indexatorFullCount = 43
let rulesCount = 133
let indexEOF = 41
let nonTermCount = 38
let termCount = 5
let termStart = 38
let termEnd = 42
let literalStart = 43
let literalEnd = 42
let literalsCount = 0

let slots = dict <| [|(-1, 0); (262145, 1); (262146, 2); (327681, 3); (458753, 4); (524289, 5); (589825, 6); (655362, 7); (720898, 8); (786434, 9); (851970, 10); (917506, 11); (983042, 12); (1048578, 13); (1114114, 14); (1179649, 15); (1245185, 16); (1310722, 17); (1376258, 18); (1441794, 19); (1507330, 20); (1572866, 21); (1638402, 22); (1703938, 23); (1769474, 24); (1835009, 25); (1900545, 26); (1966082, 27); (2031618, 28); (2097154, 29); (2162690, 30); (2228226, 31); (2293762, 32); (2359298, 33); (2424834, 34); (2490369, 35); (2555905, 36); (2621442, 37); (2686978, 38); (2752514, 39); (2818050, 40); (2883586, 41); (2949122, 42); (3014658, 43); (3080194, 44); (3145730, 45); (3211265, 46); (3276802, 47); (3342338, 48); (3407874, 49); (3473410, 50); (3538946, 51); (3604482, 52); (3670018, 53); (3735554, 54); (3801089, 55); (3866626, 56); (3932162, 57); (3997698, 58); (4063234, 59); (4128770, 60); (4194306, 61); (4259842, 62); (4325378, 63); (4390913, 64); (4456449, 65); (4521986, 66); (4587522, 67); (4653058, 68); (4718594, 69); (4784130, 70); (4849666, 71); (4915202, 72); (4980738, 73); (5046273, 74); (5111809, 75); (5177346, 76); (5242882, 77); (5308418, 78); (5373954, 79); (5439490, 80); (5505026, 81); (5570562, 82); (5636098, 83); (5701633, 84); (5767169, 85); (5832706, 86); (5898242, 87); (5963778, 88); (6029314, 89); (6094850, 90); (6160386, 91); (6225922, 92); (6291458, 93); (6356993, 94); (6422529, 95); (6488065, 96); (6553601, 97); (6553602, 98); (6553603, 99); (6619137, 100); (6619138, 101); (6619139, 102); (6684673, 103); (6684674, 104); (6684675, 105); (6684676, 106); (6750209, 107); (6750210, 108); (6750211, 109); (6750212, 110); (6750213, 111); (6815745, 112); (6815746, 113); (6815747, 114); (6815748, 115); (6815749, 116); (6815750, 117); (6881281, 118); (6881282, 119); (6881283, 120); (6881284, 121); (6881285, 122); (6881286, 123); (6881287, 124); (6946817, 125); (6946818, 126); (6946819, 127); (6946820, 128); (6946821, 129); (6946822, 130); (6946823, 131); (6946824, 132); (7012353, 133); (7012354, 134); (7077889, 135); (7077890, 136); (7208961, 137); (7208962, 138); (7274497, 139); (7274498, 140); (7274499, 141); (7340033, 142); (7340034, 143); (7340035, 144); (7405569, 145); (7471105, 146); (7471106, 147); (7536641, 148); (7536642, 149); (7536643, 150); (7602177, 151); (7602178, 152); (7667713, 153); (7667714, 154); (7667715, 155); (7733249, 156); (7798785, 157); (7798786, 158); (7864321, 159); (7864322, 160); (7864323, 161); (7929857, 162); (7929858, 163); (7929859, 164); (7929860, 165); (7995393, 166); (7995394, 167); (8060929, 168); (8060930, 169); (8060931, 170); (8126465, 171); (8126466, 172); (8126467, 173); (8126468, 174); (8192001, 175); (8192002, 176); (8192003, 177); (8192004, 178); (8192005, 179); (8257537, 180); (8257538, 181); (8257539, 182); (8257540, 183); (8257541, 184); (8257542, 185); (8323073, 186); (8323074, 187); (8323075, 188); (8323076, 189); (8323077, 190); (8323078, 191); (8323079, 192); (8388609, 193); (8388610, 194); (8388611, 195); (8454145, 196); (8454146, 197); (8454147, 198); (8454148, 199); (8519681, 200); (8519682, 201); (8519683, 202); (8519684, 203); (8519685, 204); (8585217, 205); (8585218, 206); (8585219, 207); (8585220, 208); (8585221, 209); (8585222, 210); (8650753, 211); (8650754, 212); (8650755, 213); (8650756, 214); (8650757, 215); (8650758, 216); (8650759, 217)|]

let private parserSource = new ParserSourceGLL<Token> (Token.RNGLR_EOF 0, tokenToNumber, genLiteral, numToString, tokenData, isLiteral, isTerminal, getLiteralNames, table, rules, rulesStart, leftSide, startRule, literalEnd, literalStart, termEnd, termStart, termCount, nonTermCount, literalsCount, indexEOF, rulesCount, indexatorFullCount, acceptEmptyInput,numIsTerminal, numIsNonTerminal, numIsLiteral, canInferEpsilon, slots, probabilities)
let buildAbstractAst : (AbstractAnalysis.Common.ParserInputGraph<_> -> ParserCommon.ParseResult<_>) =
    Yard.Generators.GLL.AbstractParser.buildAbstractAst<Token> parserSource
let buildAbstract : (AbstractAnalysis.Common.BioParserInputGraph -> int -> ParserCommon.ParseResult<_>) =
    Yard.Generators.GLL.AbstractParserWithoutTree.buildAbstract<Token> parserSource


