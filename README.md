# EntityFrameworkExerciseInFluentAPI
This is a exercise for EF core, which includes one to many and many to many relations.

依赖：
 
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="2.2.6" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="2.2.6" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.2.6" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="2.2.6">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
    </PackageReference>

  # command：
    + dotnet ef (--start project) migrations add v1
    + dotnet ef database  update
