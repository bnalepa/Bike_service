Aby projekt zadziałał należy odpalić:

W konosli menadżera pakietów:

add-migration thirdMigration -context AppDBContext

update-database -context AppDBContext

add-migration thirdMigration -context IdentityContext

update-database -context IdentityContext

W terminalu:
dotnet run seeddata
