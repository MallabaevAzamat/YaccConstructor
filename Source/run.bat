@echo off
echo get new Generator.dll

if .%1 == .r (
   xcopy /y /s Generator\bin\Release\Generator.dll Runner\bin\Release\Generator.dll 
) else       (
   if .%1 == .d (
      xcopy /y /s Generator\bin\Debug\Generator.dll Runner\bin\Debug\Generator.dll
   ) else       (
      echo Incorrect first argument.
   )
)

echo Generating...

if .%1 == .r (
   Runner\bin\Release\Runner.exe
) else       (
   if .%1 == .d (
      Runner\bin\Debug\Runner.exe
   ) else       ( 
      echo Incorrect first argument.
   )
)

pause

echo Copy data files...

if .%1 == .r (
   xcopy /y  goto.dta  Pasrser\bin\Release\
   xcopy /y  items.dta  Pasrser\bin\Release\
) else       (
   if .%1 == .d (
      xcopy /y  goto.dta  Pasrser\bin\Debug\
      xcopy /y  items.dta  Pasrser\bin\Debug\
   ) else       ( 
      echo Incorrect first argument.
   )
)

echo Parsing...

if .%1 == .r (
   if .%2 == .o (
      Pasrser\bin\Release\pasrser.exe >> parser_result_r.txt
   ) else      (
      Pasrser\bin\Release\pasrser.exe
   )
) else       (
   if .%1 == .d (
      if .%2 == .o (
         Pasrser\bin\Debug\pasrser.exe >> parser_result_d.txt
      ) else      (
         Pasrser\bin\Release\pasrser.exe
      )

   ) else       (
      echo Incorrect first argument.
   )
)

echo Parsing is successfuly finished.