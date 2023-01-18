dotnet dev-certs https --clean
dotnet dev-certs https -ep RestApiCertificateTest.pfx -p crypticpassword
dotnet dev-certs https --trust
dotnet user-secrets -p RestApiCertificateTest\RestApiCertificateTest.csproj set "Kestrel:Certificates:Development:Password" "crypticpassword"


docker run --rm -it 
	-p 8000:80 
	-p 8001:443 
	-e ASPNETCORE_URLS="https://+;http://+" 
	-e ASPNETCORE_HTTPS_PORT=8001 
	-e ASPNETCORE_ENVIRONMENT=Development 
	-v $env:APPDATA\microsoft\UserSecrets\:C:\Users\ContainerUser\AppData\Roaming\microsoft\UserSecrets 
	-v $env:USERPROFILE\.aspnet\https:C:\Users\ContainerUser\AppData\Roaming\ASP.NET\Https mcr.microsoft.com/dotnet/samples:aspnetapp



	$cert = New-SelfSignedCertificate -certstorelocation cert:\CurrentUser\my -dnsname localhost
	$pwd = ConvertTo-SecureString -String 'netcompany-1234' -Force -AsPlainText
	$path = 'cert:\currentuser\my\' + $cert.thumbprint
	Export-PfxCertificate -cert $path -FilePath seflsignedlocalhost.pfx -Password $pwd

	Tilgå seflsignedlocalhost.pfx certifikatet i den folder som er contexten for Powershell og installere certifikatet.