sudo systemctl stop oapi
sudo systemctl stop oauth
sudo systemctl stop sso

dotnet publish ../src/Skoruba.Duende.IdentityServer.STS.Identity/Skoruba.Duende.IdentityServer.STS.Identity.csproj -c Release -o ./SSO
dotnet publish ../src/Skoruba.Duende.IdentityServer.Admin/Skoruba.Duende.IdentityServer.Admin.csproj -c Release -o ./Admin
dotnet publish ../src/Skoruba.Duende.IdentityServer.Admin.Api/Skoruba.Duende.IdentityServer.Admin.Api.csproj -c Release -o ./Api

sudo systemctl start sso
sudo systemctl start oauth
sudo systemctl start oapi