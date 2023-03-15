# SoapServicesCore

Example Project playing with SOAP in CoreWCF 


# Install Root Certificate
$cert = New-SelfSignedCertificate -DnsName "localhost" -CertStoreLocation "Cert:\CurrentUser\My" -NotAfter (Get-Date).AddYears(1) -FriendlyName "localhost_certificate_authentication" -KeyUsageProperty All -KeyUsage CertSign, CRLSign, DigitalSignature

$mypwd = ConvertTo-SecureString -String "netcompany-1234" -Force -AsPlainText

Get-ChildItem -Path cert:\CurrentUser\my\92DF3325199BDE39185694BD126E92D0DA3F5C8A | Export-PfxCertificate -FilePath C:\Users\JOAH\Projects\SoapServicesCore\localhost_certificate_authentication.pfx -Password $mypwd

Export-Certificate -Cert cert:\CurrentUser\my\92DF3325199BDE39185694BD126E92D0DA3F5C8A -FilePath localhost_certificate_authentication.crt

# Install child Certificate

$rootcert = $cert

New-SelfSignedCertificate -CertStoreLocation "Cert:\CurrentUser\My" -dnsname "localhost" -Signer $rootcert -NotAfter (Get-Date).AddYears(1) -FriendlyName "child_localhost_certificate_authentication"

$mypwd = ConvertTo-SecureString -String "netcompany-1234" -Force -AsPlainText

Get-ChildItem -Path cert:\CurrentUser\my\9EB07355037B3599A94E7E01D435D13AE02B6122 | Export-PfxCertificate -FilePath child_localhost_certificate_authentication.pfx -Password $mypwd

Export-Certificate -Cert cert:\CurrentUser\my\9EB07355037B3599A94E7E01D435D13AE02B6122 -FilePath child_localhost_certificate_authentication.crt