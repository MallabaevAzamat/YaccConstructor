@echo off

del log.txt

for %%i in (Epsilon, Longest, InfEpsilon) do (
		echo . >> log.txt
		echo %%i >> log.txt
    ..\..\bin\Release\v40\YaccConstructor_min_base.exe -i %%i.yrd -c ExpandEbnf -c ExpandMeta ^
        -g "RNGLRGenerator -pos int -token int -module RNGLR.Parse%%i -translate true -table LR -o %%i.yrd.fs" >> log.txt
)

for %%i in (Order,Cond,Attrs,Calc,Counter,Cycle,LongCycle,Resolvers, LolCalc) do (
		echo . >> log.txt
		echo %%i >> log.txt
    ..\..\bin\Release\v40\YaccConstructor_min_base.exe -i %%i.yrd ^
        -g "RNGLRGenerator -pos int -token int -module RNGLR.Parse%%i -translate true -table LR -o %%i.yrd.fs" >> log.txt
)

for %%i in (ComplexRightNull,Expr,First,List,SimpleRightNull) do (
		echo . >> log.txt
		echo %%i >> log.txt
    ..\..\bin\Release\v40\YaccConstructor_min_base.exe -i %%i.yrd ^
        -g "RNGLRGenerator -pos int -token int -module RNGLR.Parse%%i -translate false -table LR -o %%i.yrd.fs" >> log.txt
)

