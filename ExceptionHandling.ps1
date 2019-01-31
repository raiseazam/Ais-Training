
function Test1
{
param([int]$x,[int]$y)
try
{
$z = $x / $y
[Math]::Floor($z)
# Write-Host $z
}
catch
{
 $e=$_.Exception.Message
 Write-Host $e
# Write-Error $_
}
}
[int]$x =  Read-Host "Enter Numerator "
[int]$y = Read-Host  "Enter Denominator "
Test1 $x $y