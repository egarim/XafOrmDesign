;#DropDB XafOrmDesignEasyTest

#Application XafOrmDesign.Win
#Application XafOrmDesign.Web
#IfDef XafOrmDesign.Win

*Action About...
 
*Action OK

#EndIf

#IfDef XafOrmDesign.Web
!Action Navigation(My Details)
#EndIf
