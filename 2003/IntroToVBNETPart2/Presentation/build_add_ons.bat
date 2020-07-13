vbc /nologo /optionstrict+ /optionexplicit+ /target:exe /out:Exception4_vb.exe Exception4.vb
csc /nologo /target:exe /out:Exception4_cs.exe Exception4.cs

vbc /nologo /optionstrict+ /optionexplicit+ /target:library /out:NamespaceTest_vb.dll NamespaceTest.vb
vbc /nologo /optionstrict+ /optionexplicit+ /target:exe /r:NamespaceTest_vb.dll /out:NamespaceUsage_vb.exe NamespaceUsage.vb

csc /nologo /target:library /out:NamespaceTest_cs.dll NamespaceTest.cs
csc /nologo /target:exe /r:NamespaceTest_cs.dll /out:NamespaceUsage_cs.exe NamespaceUsage.cs

vbc /nologo /optionstrict+ /optionexplicit+ /target:exe /out:Interface1_vb.exe Interface1.vb
csc /nologo /target:exe /out:Interface1_cs.exe Interface1.cs