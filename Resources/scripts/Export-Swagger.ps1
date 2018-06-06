param(
	$ModulePath,
	$FunctionAppName,
	$ResourceGroup,
	$OutputFilePath
)

Import-Module $ModulePath
$Swagger = Get-Swagger -FunctionAppName $FunctionAppName -ResourceGroup $ResourceGroup
$FileName = "$($FunctionAppName)_swagger-def_$([DateTime]::Now.ToString("yyyyMMdd-hhmmss"))"
$OutputFile = New-Item -Path $OutputFilePath -Name $FileName
Set-Content -Path $OutputFile.FullName -Value $Swagger
Write-Host "##[task.setvariable variable=SwaggerFile;isSecret=false;isOutput=true;]$FileName"