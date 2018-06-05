param(
	$ModulePath,
	$FunctionAppName,
	$ResourceGroup
)

Import-Module $ModulePath
#test
Get-Swagger -FunctionAppName $FunctionAppName -ResourceGroup $ResourceGroup