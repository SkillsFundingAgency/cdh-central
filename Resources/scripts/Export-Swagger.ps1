[CmdletBinding()]
param(
	$ModulePath,
	$FunctionAppName,
	$ResourceGroup,
	$OutputFilePath
)

Import-Module $ModulePath
$Swagger = Get-Swagger -FunctionAppName $FunctionAppName -ResourceGroup $ResourceGroup
Write-Verbose -Message $($Swagger | ConvertTo-Json)
$FileName = "$($FunctionAppName)_swagger-def_$([DateTime]::Now.ToString("yyyyMMdd-hhmmss")).json"
Write-Verbose -Message "Filename: $FileName"
$OutputFile = New-Item -Path $OutputFilePath -Name $FileName
Set-Content -Path $OutputFile.FullName -Value ($Swagger | ConvertTo-Json)
Write-Host "##[task.setvariable variable=SwaggerFile;]FileName"