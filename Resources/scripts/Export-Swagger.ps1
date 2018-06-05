param(
	$ModulePath,
	$FunctionAppName,
	$ResourceGroup
)

Import-Module $ModulePath

Get-Swagger -FunctionAppName $FunctionAppName -ResourceGroup $ResourceGroup