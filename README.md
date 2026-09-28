# MyWebApi - Toko Jus

Demo ASP.NET Core Web API CRUD untuk Toko Jus. Data tersimpan in-memory dan reset saat aplikasi restart.

## Run

```powershell
dotnet run
```

Buka Swagger URL dari output aplikasi, lalu pakai endpoint `api/Juices`.

## Credential demo

Commit pertama sengaja pernah menyimpan fake GitHub PAT dan OpenWeatherMap API key untuk presentasi `gitleaks git`.

Credential sekarang disimpan di `.env`, yang di-ignore Git. `appsettings.json` hanya berisi placeholder environment variable. Nilai credential tersebut dummy dan tidak boleh dipakai di aplikasi nyata.

# toko-jus
