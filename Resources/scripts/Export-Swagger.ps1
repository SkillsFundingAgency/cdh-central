[CmdletBinding()]
param(
	$ModulePath,
	$FunctionAppName,
	$ResourceGroup,
	$OutputFilePath
)

Import-Module $ModulePath
$Swagger = Get-Swagger -FunctionAppName $FunctionAppName -ResourceGroup $ResourceGroup
Write-Verbose $($Swagger | ConvertTo-Json)
$FileName = "$($FunctionAppName)_swagger-def_$([DateTime]::Now.ToString("yyyyMMdd-hhmmss"))"
Write-Verbose "Filename: $FileName"
$OutputFile = New-Item -Path $OutputFilePath -Name $FileName
Set-Content -Path $OutputFile.FullName -Value $Swagger
Write-Host "##[task.setvariable variable=SwaggerFile;isSecret=false;isOutput=true;]$FileName"
Write-Verbose $env:SwaggerFile