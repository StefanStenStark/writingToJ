dotnet run
if ($?) {
    Write-Host "Execution succeeded"
} else {
    Write-Host "Execution Failed"
}
Write-Host "Return value = $?"